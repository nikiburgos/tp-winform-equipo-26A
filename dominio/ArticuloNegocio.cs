using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dominio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Server=localhost,1433;Database=CATALOGO_P3_DB;User Id=sa;Password=Doc39805119;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = @"SELECT a.id AS ArticuloId, a.codigo, a.Nombre, a.Descripcion, 
                                        a.idMarca, m.Descripcion AS MarcaDescripcion, 
                                        a.idCategoria, c.Descripcion AS CategoriaDescripcion, 
                                        a.Precio,
                                        i.Id AS ImagenId, i.IdArticulo, i.ImagenUrl
                                        FROM ARTICULOS a
                                        INNER JOIN MARCAS m ON a.idMarca = m.Id
                                        INNER JOIN CATEGORIAS c ON a.idCategoria = c.Id
                                        LEFT JOIN IMAGENES i ON a.id = i.IdArticulo
                                        ORDER BY a.id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["ArticuloId"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["idMarca"];
                    aux.Marca.Descripcion = (string)lector["MarcaDescripcion"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["idCategoria"];
                    aux.Categoria.Descripcion = (string)lector["CategoriaDescripcion"];

                    aux.Imagen = new List<Imagen>();
                    aux.Imagen.Add(new Imagen
                    {
                        Id = lector["ImagenId"] != DBNull.Value ? (int)lector["ImagenId"] : 0,
                        IdArticulo = (int)lector["ArticuloId"],
                        Url = lector["ImagenUrl"] != DBNull.Value ? (string)lector["ImagenUrl"] : null
                    });


                    aux.Precio = (decimal)lector["Precio"];


                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
