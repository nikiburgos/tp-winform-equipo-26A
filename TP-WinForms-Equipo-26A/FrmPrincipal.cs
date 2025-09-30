using dominio; // Agregado para acceder a la clase Articulo
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForms_Equipo_26A
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmListadoArticulos ventana = new FrmListadoArticulos();
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBusquedaArticulos ventana = new FrmBusquedaArticulos();
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulos ventana = new FrmAgregarArticulos();
            ventana.ShowDialog();
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    // Abrir un formulario de selección de artículos
        //    FrmSeleccionarArticulo seleccionarArticuloForm = new FrmSeleccionarArticulo();
        //    if (seleccionarArticuloForm.ShowDialog() == DialogResult.OK)
        //    {
        //        Articulo articuloSeleccionado = seleccionarArticuloForm.ArticuloSeleccionado;
        //        if (articuloSeleccionado != null)
        //        {
        //            FrmModificarArticulos ventana = new FrmModificarArticulos(articuloSeleccionado);
        //            ventana.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Debe seleccionar un artículo para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    FrmEliminarArticulos ventana = new FrmEliminarArticulos();  
        //    ventana.ShowDialog();
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    FrmListadoArticulos listado = new FrmListadoArticulos(); listado.ShowDialog();
        //    if (listado.ShowDialog() == DialogResult.OK && listado.ArticuloSeleccionado != null)
        //    {
        //        FrmDetalleArticulos detalle = new FrmDetalleArticulos(listado.ArticuloSeleccionado);
        //        detalle.ShowDialog();
        //    }
        //}
    }
}
