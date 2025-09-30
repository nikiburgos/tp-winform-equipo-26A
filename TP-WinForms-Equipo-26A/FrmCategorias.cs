using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmCategorias : Form
    {
        private CategoriaNegocio categoriaNegocio;

        public FrmCategorias()
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                List<Categoria> categorias = categoriaNegocio.Listar();
                dgvCategorias.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categor�as: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNuevaCategoria.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para la nueva categor�a.");
                    return;
                }

                Categoria nuevaCategoria = new Categoria { Descripcion = txtNuevaCategoria.Text };
                categoriaNegocio.Agregar(nuevaCategoria);

                MessageBox.Show("Categor�a agregada correctamente.");
                txtNuevaCategoria.Clear();
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la categor�a: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}