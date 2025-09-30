using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmSeleccionarArticulo : Form
    {
        public Articulo ArticuloSeleccionado { get; private set; }
        private List<Articulo> listaArticulos;

        public FrmSeleccionarArticulo()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                lstArticulos.DataSource = listaArticulos;
                lstArticulos.DisplayMember = "Nombre";
                lstArticulos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloSeleccionado = (Articulo)lstArticulos.SelectedItem;
            if (ArticuloSeleccionado != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}