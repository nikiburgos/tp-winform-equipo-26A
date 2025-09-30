using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmMarcas : Form
    {
        private MarcaNegocio marcaNegocio;

        public FrmMarcas()
        {
            InitializeComponent();
            marcaNegocio = new MarcaNegocio();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            try
            {
                List<Marca> marcas = marcaNegocio.Listar();
                dgvMarcas.DataSource = marcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las marcas: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNuevaMarca.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para la nueva marca.");
                    return;
                }

                Marca nuevaMarca = new Marca { Descripcion = txtNuevaMarca.Text };
                marcaNegocio.Agregar(nuevaMarca);

                MessageBox.Show("Marca agregada correctamente.");
                txtNuevaMarca.Clear();
                CargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la marca: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}