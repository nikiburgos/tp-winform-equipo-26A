using System;
using System.Collections.Generic;
using dominio;
using System.CodeDom;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT a.id AS ArticuloId, a.codigo, a.Nombre, a.Descripcion, 
                                        a.idMarca, m.Descripcion AS MarcaDescripcion, 
                                        a.idCategoria, c.Descripcion AS CategoriaDescripcion, 
                                        a.Precio
                                        FROM ARTICULOS a
                                        INNER JOIN MARCAS m ON a.idMarca = m.Id
                                        INNER JOIN CATEGORIAS c ON a.idCategoria = c.Id
                                        ORDER BY a.id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["ArticuloId"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["idMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["MarcaDescripcion"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["idCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["CategoriaDescripcion"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    // Inicializar la lista de imágenes
                    aux.Imagen = new List<Imagen>();

                    // Cargar las imágenes asociadas al artículo
                    AccesoDatos datosImagen = new AccesoDatos();
                    try
                    {
                        datosImagen.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                        datosImagen.setearParametro("@idArticulo", aux.Id);
                        datosImagen.ejecutarLectura();

                        while (datosImagen.Lector.Read())
                        {
                            Imagen img = new Imagen();
                            img.Id = (int)datosImagen.Lector["Id"];
                            img.IdArticulo = (int)datosImagen.Lector["IdArticulo"];
                            img.Url = (string)datosImagen.Lector["ImagenUrl"];

                            aux.Imagen.Add(img);
                        }
                    }
                    finally
                    {
                        datosImagen.cerrarConexion();
                    }

                    lista.Add(aux);
                }
                return lista;
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

        public void agregar(Articulo nuevo, List<Imagen> listaImagenes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Insertar el artículo
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "output inserted.Id VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)");
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);

                // Obtener el ID generado
                int idArticulo = datos.ejecutarScalar();
                datos.cerrarConexion();

                // Insertar imágenes si existen
                if (listaImagenes != null && listaImagenes.Count > 0)
                {
                    foreach (var img in listaImagenes)
                    {
                        AccesoDatos datosImagen = new AccesoDatos();
                        datosImagen.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                        datosImagen.setearParametro("@idArticulo", idArticulo);
                        datosImagen.setearParametro("@imagenUrl", img.Url);
                        datosImagen.ejecutarAccion();
                        datosImagen.cerrarConexion();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; // Propagar la excepción para que la UI la maneje
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo, List<Imagen> imagenes)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Actualizar el artículo
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @precio WHERE Id = @id;");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);
                datos.ejecutarAccion();

                // Eliminar imágenes existentes
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", articulo.Id);
                datos.ejecutarAccion();

                // Insertar nuevas imágenes si existen
                if (imagenes != null && imagenes.Count > 0)
                {
                    foreach (Imagen img in imagenes)
                    {
                        try
                        {
                            AccesoDatos datosImagen = new AccesoDatos();
                            datosImagen.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                            datosImagen.setearParametro("@idArticulo", articulo.Id);
                            datosImagen.setearParametro("@imagenUrl", img.Url);
                            datosImagen.ejecutarAccion();
                            datosImagen.cerrarConexion();
                        }
                        catch (Exception imgEx)
                        {
                            // Registrar el error de la imagen pero continuar con el flujo principal
                            Console.WriteLine("Error al insertar imagen: " + imgEx.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el artículo: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Eliminar el artículo
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id;");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

                // Eliminar imágenes asociadas al artículo
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el artículo: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}