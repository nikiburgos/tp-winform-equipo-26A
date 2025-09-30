using System;
using System.Windows.Forms;
using dominio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmDetalleArticulos : Form
    {
        private Articulo articulo;
        private int indiceImagenActual;

        public FrmDetalleArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.indiceImagenActual = 0;
        }

        private void FrmDetalleArticulos_Load(object sender, EventArgs e)
        {
            if (articulo == null)
                return;

            // Reiniciar el índice de navegación de imágenes
            indiceImagenActual = 0;

            // Mostrar información detallada del artículo
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString("C");
            lblMarca.Text = articulo.Marca != null ? articulo.Marca.Descripcion : "Sin marca";
            lblCategoria.Text = articulo.Categoria != null ? articulo.Categoria.Descripcion : "Sin categoría";

            // Cargar la primera imagen del artículo
            CargarImagen();
        }

        private void CargarImagen()
        {
            try
            {
                if (articulo.Imagen != null && articulo.Imagen.Count > 0)
                {
                    string url = articulo.Imagen[indiceImagenActual].Url;
                    if (!string.IsNullOrEmpty(url))
                    {
                        using (var client = new System.Net.WebClient())
                        {
                            // Agregar un encabezado User-Agent para evitar restricciones del servidor
                            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                            // Descargar la imagen como un stream
                            var imageData = client.DownloadData(url);

                            using (var stream = new System.IO.MemoryStream(imageData))
                            {
                                pbImagen.Image = System.Drawing.Image.FromStream(stream);
                            }
                        }
                    }
                    else
                    {
                        pbImagen.Load("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
                    }
                }
                else
                {
                    pbImagen.Load("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
                pbImagen.Load("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (articulo.Imagen != null && articulo.Imagen.Count > 0)
            {
                indiceImagenActual = (indiceImagenActual + 1) % articulo.Imagen.Count;
                CargarImagen();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (articulo.Imagen != null && articulo.Imagen.Count > 0)
            {
                indiceImagenActual = (indiceImagenActual - 1 + articulo.Imagen.Count) % articulo.Imagen.Count;
                CargarImagen();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario en lugar de cerrarlo
        }
    }
}