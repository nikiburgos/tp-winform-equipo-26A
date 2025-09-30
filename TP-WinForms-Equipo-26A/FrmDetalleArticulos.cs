using System;
using System.Windows.Forms;
using dominio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmDetalleArticulos : Form
    {
        private Articulo articulo;

        public FrmDetalleArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmDetalleArticulos_Load(object sender, EventArgs e)
        {
            if (articulo == null)
                return;

            // Ejemplo: Asumiendo que tienes controles como lblNombre, lblDescripcion, lblPrecio, pbImagen
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString("C");

            if (articulo.Imagen != null && articulo.Imagen.Count > 0 && !string.IsNullOrEmpty(articulo.Imagen[0].Url))
                pbImagen.Load(articulo.Imagen[0].Url);
            else
                pbImagen.Load("https://via.placeholder.com/150");
        }
    }
}