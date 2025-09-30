using System;
using System.Collections.Generic;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> categorias = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = (int)datos.Lector["Id"],
                        Descripcion = (string)datos.Lector["Descripcion"]
                    };
                    categorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return categorias;
        }

        public void Agregar(Categoria nuevaCategoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@descripcion)");
                datos.setearParametro("@descripcion", nuevaCategoria.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}