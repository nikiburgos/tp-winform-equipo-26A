namespace TP_WinForms_Equipo_26A
{
    partial class FrmSeleccionarArticulo
    {
        private System.Windows.Forms.ListBox lstArticulos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

        private void InitializeComponent()
        {
            this.lstArticulos = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lstArticulos
            // 
            this.lstArticulos.FormattingEnabled = true;
            this.lstArticulos.Location = new System.Drawing.Point(12, 12);
            this.lstArticulos.Name = "lstArticulos";
            this.lstArticulos.Size = new System.Drawing.Size(360, 290);
            this.lstArticulos.TabIndex = 0;

            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(216, 320);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(297, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // FrmSeleccionarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstArticulos);
            this.Name = "FrmSeleccionarArticulo";
            this.Text = "Seleccionar Artículo";
            this.Load += new System.EventHandler(this.FrmSeleccionarArticulo_Load);
            this.ResumeLayout(false);
        }
    }
}