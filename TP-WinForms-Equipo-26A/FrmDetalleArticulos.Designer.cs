namespace TP_WinForms_Equipo_26A
{
    partial class FrmDetalleArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombreTitle = new System.Windows.Forms.Label();
            this.lblDescripcionTitle = new System.Windows.Forms.Label();
            this.lblPrecioTitle = new System.Windows.Forms.Label();
            this.lblMarcaTitle = new System.Windows.Forms.Label();
            this.lblCategoriaTitle = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(331, 94);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 170);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(85, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(40, 240);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(440, 170);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(440, 240);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 16);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría: ";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(151, 325);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(356, 331);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(515, 485);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(93, 37);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(43, 485);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(93, 37);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 46);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombreTitle
            // 
            this.lblNombreTitle.AutoSize = true;
            this.lblNombreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreTitle.Location = new System.Drawing.Point(243, 90);
            this.lblNombreTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTitle.Name = "lblNombreTitle";
            this.lblNombreTitle.Size = new System.Drawing.Size(80, 20);
            this.lblNombreTitle.TabIndex = 9;
            this.lblNombreTitle.Text = "Nombre:";
            // 
            // lblDescripcionTitle
            // 
            this.lblDescripcionTitle.AutoSize = true;
            this.lblDescripcionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionTitle.Location = new System.Drawing.Point(39, 141);
            this.lblDescripcionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionTitle.Name = "lblDescripcionTitle";
            this.lblDescripcionTitle.Size = new System.Drawing.Size(116, 20);
            this.lblDescripcionTitle.TabIndex = 10;
            this.lblDescripcionTitle.Text = "Descripción:";
            // 
            // lblPrecioTitle
            // 
            this.lblPrecioTitle.AutoSize = true;
            this.lblPrecioTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecioTitle.Location = new System.Drawing.Point(39, 210);
            this.lblPrecioTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioTitle.Name = "lblPrecioTitle";
            this.lblPrecioTitle.Size = new System.Drawing.Size(69, 20);
            this.lblPrecioTitle.TabIndex = 11;
            this.lblPrecioTitle.Text = "Precio:";
            // 
            // lblMarcaTitle
            // 
            this.lblMarcaTitle.AutoSize = true;
            this.lblMarcaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarcaTitle.Location = new System.Drawing.Point(439, 141);
            this.lblMarcaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaTitle.Name = "lblMarcaTitle";
            this.lblMarcaTitle.Size = new System.Drawing.Size(67, 20);
            this.lblMarcaTitle.TabIndex = 12;
            this.lblMarcaTitle.Text = "Marca:";
            // 
            // lblCategoriaTitle
            // 
            this.lblCategoriaTitle.AutoSize = true;
            this.lblCategoriaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoriaTitle.Location = new System.Drawing.Point(439, 210);
            this.lblCategoriaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaTitle.Name = "lblCategoriaTitle";
            this.lblCategoriaTitle.Size = new System.Drawing.Size(96, 20);
            this.lblCategoriaTitle.TabIndex = 13;
            this.lblCategoriaTitle.Text = "Categoría:";
            // 
            // FrmDetalleArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 800);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCategoriaTitle);
            this.Controls.Add(this.lblMarcaTitle);
            this.Controls.Add(this.lblPrecioTitle);
            this.Controls.Add(this.lblDescripcionTitle);
            this.Controls.Add(this.lblNombreTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDetalleArticulos";
            this.Text = "Detalle del Artículo";
            this.Load += new System.EventHandler(this.FrmDetalleArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombreTitle;
        private System.Windows.Forms.Label lblDescripcionTitle;
        private System.Windows.Forms.Label lblPrecioTitle;
        private System.Windows.Forms.Label lblMarcaTitle;
        private System.Windows.Forms.Label lblCategoriaTitle;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}