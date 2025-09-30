using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmModificarArticulos : Form
    {
        private Articulo articulo;
        private List<Imagen> listaImagenes;
        private int indiceImagenActual;

        public FrmModificarArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            listaImagenes = new List<Imagen>();
            indiceImagenActual = 0;
            Text = "Modificar Artículo";
        }

        private void FrmModificarArticulos_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;

                    CargarImagenesArticulo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void CargarImagenesArticulo()
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagenes = imagenNegocio.listImagenes().FindAll(img => img.IdArticulo == articulo.Id);
            if (listaImagenes.Count > 0)
            {
                try
                {
                    pbImagen.Load(listaImagenes[0].Url);
                }
                catch (System.Net.WebException)
                {
                    MostrarImagenPorDefecto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MostrarImagenPorDefecto();
                }
            }
            else
            {
                MostrarImagenPorDefecto();
            }
        }

        private void MostrarImagenPorDefecto()
        {
            pbImagen.Load("https://via.placeholder.com/300x200");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                    cboMarca.SelectedIndex < 0 || cboCategoria.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe completar los campos obligatorios");
                    return;
                }

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.modificar(articulo, listaImagenes);

                MessageBox.Show("Artículo modificado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
