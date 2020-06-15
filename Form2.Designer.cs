namespace Sistema_interior
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnautos = new System.Windows.Forms.Button();
            this.btnpiezas = new System.Windows.Forms.Button();
            this.btnfactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 25.25F);
            this.label1.Location = new System.Drawing.Point(287, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema del Taller.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(43, 159);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(92, 33);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnautos
            // 
            this.btnautos.Location = new System.Drawing.Point(231, 159);
            this.btnautos.Name = "btnautos";
            this.btnautos.Size = new System.Drawing.Size(92, 33);
            this.btnautos.TabIndex = 2;
            this.btnautos.Text = "Autos";
            this.btnautos.UseVisualStyleBackColor = true;
            this.btnautos.Click += new System.EventHandler(this.btnautos_Click);
            // 
            // btnpiezas
            // 
            this.btnpiezas.Location = new System.Drawing.Point(472, 159);
            this.btnpiezas.Name = "btnpiezas";
            this.btnpiezas.Size = new System.Drawing.Size(92, 33);
            this.btnpiezas.TabIndex = 3;
            this.btnpiezas.Text = "Piezas";
            this.btnpiezas.UseVisualStyleBackColor = true;
            // 
            // btnfactura
            // 
            this.btnfactura.Location = new System.Drawing.Point(665, 159);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(92, 33);
            this.btnfactura.TabIndex = 4;
            this.btnfactura.Text = "Facturacion";
            this.btnfactura.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfactura);
            this.Controls.Add(this.btnpiezas);
            this.Controls.Add(this.btnautos);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnautos;
        private System.Windows.Forms.Button btnpiezas;
        private System.Windows.Forms.Button btnfactura;
    }
}

