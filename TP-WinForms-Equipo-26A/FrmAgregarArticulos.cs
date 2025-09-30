using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.IO;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmAgregarArticulos : Form
    {
        private Articulo articulo = null;
        private List<Imagen> listaImagenes;
        private int indiceImagenActual;

        public FrmAgregarArticulos()
        {
            InitializeComponent();
            listaImagenes = new List<Imagen>();
            indiceImagenActual = 0;
            MostrarImagenPorDefecto();
        }

        public FrmAgregarArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            listaImagenes = new List<Imagen>();
            indiceImagenActual = 0;
            Text = "Modificar Artículo";
            txtCabeceraArticulo.Text = "MODIFICAR ARTÍCULO";
            CargarImagenesArticulo();
        }

        private void FrmAgregarArticulos_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcaNegocio.Listar();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                    cboMarca.SelectedIndex < 0 || cboCategoria.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe completar los campos obligatorios");
                    return;
                }

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo, listaImagenes);
                    MessageBox.Show("Artículo modificado correctamente");
                }
                else
                {
                    negocio.agregar(articulo, listaImagenes);
                    MessageBox.Show("Artículo agregado correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el artículo: " + ex.Message);
            }
        }

        private void CargarImagenesArticulo()
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            listaImagenes = imagenNegocio.listImagenes().FindAll(img => img.IdArticulo == articulo.Id);
            if (listaImagenes.Count > 0)
            {
                pbxAgregarImagen.Load(listaImagenes[0].Url);
            }
            else
            {
                MostrarImagenPorDefecto();
            }
        }

        private void MostrarImagenPorDefecto()
        {
            pbxAgregarImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUwCJYSnbBLMEGWKfSnWRGC_34iCCKkxePpg&s");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }                                   
    }
}
