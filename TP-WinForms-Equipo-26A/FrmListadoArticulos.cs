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

        private void ConfigurarColumnas()
        {
            if (dgvArticulos.Columns.Count == 0)
            {
                // Columna Nombre
                DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
                colNombre.DataPropertyName = "Nombre";   // Propiedad de Articulo
                colNombre.HeaderText = "Nombre";
                dgvArticulos.Columns.Add(colNombre);

                // Columna Marca
                DataGridViewTextBoxColumn colMarca = new DataGridViewTextBoxColumn();
                colMarca.DataPropertyName = "Marca";
                colMarca.HeaderText = "Marca";
                dgvArticulos.Columns.Add(colMarca);

                // Columna Categoría
                DataGridViewTextBoxColumn colCategoria = new DataGridViewTextBoxColumn();
                colCategoria.DataPropertyName = "Categoria";
                colCategoria.HeaderText = "Categoría";
                dgvArticulos.Columns.Add(colCategoria);

                // Columna Precio
                DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
                colPrecio.DataPropertyName = "Precio";
                colPrecio.HeaderText = "Precio";
                dgvArticulos.Columns.Add(colPrecio);

                // Botón Ver Detalle
                DataGridViewButtonColumn btnVerDetalle = new DataGridViewButtonColumn();
                btnVerDetalle.Name = "btnVerDetalle";
                btnVerDetalle.HeaderText = "Acciones";
                btnVerDetalle.Text = "Ver Detalle";
                btnVerDetalle.UseColumnTextForButtonValue = true;
                dgvArticulos.Columns.Add(btnVerDetalle);

                // Botón Modificar
                DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
                btnModificar.Name = "btnModificar";
                btnModificar.HeaderText = "Modificar";
                btnModificar.Text = "Modificar";
                btnModificar.UseColumnTextForButtonValue = true;
                dgvArticulos.Columns.Add(btnModificar);

                // Botón Eliminar
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvArticulos.Columns.Add(btnEliminar);
            }
        }

        private void FrmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();

                dgvArticulos.AutoGenerateColumns = false; 
                ConfigurarColumnas();

                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                if (e.RowIndex >= 0)
                {
                    if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnModificar")
                    {
                        Articulo artSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
                        FrmModificarArticulos modificarForm = new FrmModificarArticulos(artSeleccionado);
                        modificarForm.ShowDialog();
                    }
                    else if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnEliminar")
                    {
                        Articulo artSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
                        DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este artículo?",
                                                              "Confirmar eliminación",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                ArticuloNegocio negocio = new ArticuloNegocio();
                                negocio.eliminar(artSeleccionado.Id);
                                MessageBox.Show("Artículo eliminado correctamente.");
                                FrmListadoArticulos_Load(sender, e); // Recargar la lista
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al eliminar el artículo: " + ex.Message,
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (dgvArticulos.Columns[e.ColumnIndex].Name == "btnVerDetalle")
                    {
                        Articulo artSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
                        FrmDetalleArticulos detalleForm = new FrmDetalleArticulos(artSeleccionado);
                        detalleForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                return;

            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagenArticulo(artSeleccionado);
            lblArticulo.Text = artSeleccionado != null ? artSeleccionado.Nombre : "Artículo";
        }

        private void CargarImagenArticulo(Articulo articulo)
        {
            try
            {
                if (articulo != null && articulo.Imagen != null && articulo.Imagen.Count > 0)
                    pbListado.LoadAsync(articulo.Imagen[0].Url);
                else
                    pbListado.LoadAsync("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
            }
            catch
            {
                pbListado.LoadAsync("https://www1.lovethatdesign.com/wp-content/uploads/2022/01/placeholder-image.png");
            }
        }

        public Articulo ArticuloSeleccionado { get; private set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string Filtro = txtBuscar.Text;

            if (!string.IsNullOrEmpty(Filtro))
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(Filtro.ToLower()) || x.Marca.Descripcion.ToLower().Contains(Filtro.ToLower()) || x.Categoria.Descripcion.ToLower().Contains(Filtro.ToLower()));

            else
                listaFiltrada = listaArticulos;

            dgvArticulos.DataSource = listaFiltrada;
        }
    }
}
