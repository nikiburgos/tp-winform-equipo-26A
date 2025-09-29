using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public FrmListadoArticulos()
        {
            InitializeComponent();
        }

        private void FrmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;

                // Carga la imagen del primer artículo si existe
                if (listaArticulos.Count > 0 && listaArticulos[0].Imagen != null && listaArticulos[0].Imagen.Count > 0 && !string.IsNullOrEmpty(listaArticulos[0].Imagen[0].Url))
                    pbListado.Load(listaArticulos[0].Imagen[0].Url);
                else
                    pbListado.Load("https://via.placeholder.com/150");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                return;

            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                if (artSeleccionado.Imagen != null && artSeleccionado.Imagen.Count > 0 && !string.IsNullOrEmpty(artSeleccionado.Imagen[0].Url))
                    pbListado.LoadAsync(artSeleccionado.Imagen[0].Url);
                else
                    pbListado.LoadAsync("https://via.placeholder.com/150");
            }
            catch
            {
                pbListado.LoadAsync("https://via.placeholder.com/150");
            }
        }
    }
}