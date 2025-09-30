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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 90);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(30, 130);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(30, 170);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(30, 210);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría: ";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(30, 250);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(400, 300);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(360, 550);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(70, 30);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(30, 550);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(70, 30);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(10, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(20, 20);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "←";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombreTitle
            // 
            this.lblNombreTitle.AutoSize = true;
            this.lblNombreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreTitle.Location = new System.Drawing.Point(30, 30);
            this.lblNombreTitle.Name = "lblNombreTitle";
            this.lblNombreTitle.Size = new System.Drawing.Size(70, 20);
            this.lblNombreTitle.TabIndex = 9;
            this.lblNombreTitle.Text = "Nombre:";
            // 
            // lblDescripcionTitle
            // 
            this.lblDescripcionTitle.AutoSize = true;
            this.lblDescripcionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionTitle.Location = new System.Drawing.Point(30, 70);
            this.lblDescripcionTitle.Name = "lblDescripcionTitle";
            this.lblDescripcionTitle.Size = new System.Drawing.Size(100, 20);
            this.lblDescripcionTitle.TabIndex = 10;
            this.lblDescripcionTitle.Text = "Descripción:";
            // 
            // lblPrecioTitle
            // 
            this.lblPrecioTitle.AutoSize = true;
            this.lblPrecioTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecioTitle.Location = new System.Drawing.Point(30, 110);
            this.lblPrecioTitle.Name = "lblPrecioTitle";
            this.lblPrecioTitle.Size = new System.Drawing.Size(60, 20);
            this.lblPrecioTitle.TabIndex = 11;
            this.lblPrecioTitle.Text = "Precio:";
            // 
            // lblMarcaTitle
            // 
            this.lblMarcaTitle.AutoSize = true;
            this.lblMarcaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarcaTitle.Location = new System.Drawing.Point(30, 150);
            this.lblMarcaTitle.Name = "lblMarcaTitle";
            this.lblMarcaTitle.Size = new System.Drawing.Size(60, 20);
            this.lblMarcaTitle.TabIndex = 12;
            this.lblMarcaTitle.Text = "Marca:";
            // 
            // lblCategoriaTitle
            // 
            this.lblCategoriaTitle.AutoSize = true;
            this.lblCategoriaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoriaTitle.Location = new System.Drawing.Point(30, 190);
            this.lblCategoriaTitle.Name = "lblCategoriaTitle";
            this.lblCategoriaTitle.Size = new System.Drawing.Size(85, 20);
            this.lblCategoriaTitle.TabIndex = 13;
            this.lblCategoriaTitle.Text = "Categoría:";
            // 
            // FrmDetalleArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 650);
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
    }
}