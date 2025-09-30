using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        // aca lo que hago es crear diferentes métodos. 

        public SqlDataReader Lector
        {
            get { return lector; }

        }

        //Constructor
        public AccesoDatos()
        //1: server, el nombre de la instancia de la db: 2: nombre de la base de datos: 3: forma de conectarse
        { 
            conexion = new SqlConnection("server=localhost,1433; database=CATALOGO_P3_DB; user=sa;PASSWORD=Doc39805119");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            //comando realiza la acción e inyecta la consulta SQL de tipo texto .
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            //ejecuta el comando (consulta SQL (SELECT)) en la conexion (BD)
            comando.Connection = conexion;
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                //ejecuta una acción que no sea de lectura (insert, delete, update)
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  


        public int ejecutarScalar()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                //ejecuta una acción que no sea de lectura (insert, delete, update)
                return (int)comando.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void setearParametro(string nombre, object valor)
        {
            //Seteo de parametros recibidos para ejecutar acciones en BD (NombreTabla; Valor a insertar)
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void cerrarConexion()
        {
            //En caso de haber un lector activo cuando se llama al método, también se cierra junto con la conexión.
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}