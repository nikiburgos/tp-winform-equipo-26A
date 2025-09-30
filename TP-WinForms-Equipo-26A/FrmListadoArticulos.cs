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

                // Configurar las columnas visibles del DataGridView
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Codigo"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false;

                dgvArticulos.Columns["Nombre"].HeaderText = "Nombre";
                dgvArticulos.Columns["Marca"].HeaderText = "Marca";
                dgvArticulos.Columns["Categoria"].HeaderText = "Categoría";
                dgvArticulos.Columns["Precio"].HeaderText = "Precio";

                // Agregar columna de botón para ver detalles
                DataGridViewButtonColumn btnVerDetalle = new DataGridViewButtonColumn();
                btnVerDetalle.HeaderText = "Acciones";
                btnVerDetalle.Text = "Ver Detalle";
                btnVerDetalle.UseColumnTextForButtonValue = true;
                dgvArticulos.Columns.Add(btnVerDetalle);

                // Vincular el evento CellClick
                dgvArticulos.CellClick += dgvArticulos_CellClick;

                // Cargar la imagen del primer artículo si existe
                CargarImagenArticulo(listaArticulos.Count > 0 ? listaArticulos[0] : null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar si se hizo clic en la columna de botones
                if (e.RowIndex >= 0 && dgvArticulos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    Articulo artSeleccionado = listaArticulos[e.RowIndex];
                    if (artSeleccionado != null)
                    {
                        FrmDetalleArticulos detalleForm = new FrmDetalleArticulos(artSeleccionado);
                        detalleForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo seleccionar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                return;

            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagenArticulo(artSeleccionado);
        }

        private void CargarImagenArticulo(Articulo articulo)
        {
            try
            {
                if (articulo != null && articulo.Imagen != null && articulo.Imagen.Count > 0 && !string.IsNullOrEmpty(articulo.Imagen[0].Url))
                {
                    pbListado.LoadAsync(articulo.Imagen[0].Url);
                }
                else
                {
                    pbListado.LoadAsync("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
                }
            }
            catch
            {
                pbListado.LoadAsync("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
            }
        }

        public Articulo ArticuloSeleccionado { get; private set; }
    }
}