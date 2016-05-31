namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class frmPantallaUsuario
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
            this.btnGenerarPublicacion = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarPublicacion
            // 
            this.btnGenerarPublicacion.Location = new System.Drawing.Point(62, 10);
            this.btnGenerarPublicacion.Name = "btnGenerarPublicacion";
            this.btnGenerarPublicacion.Size = new System.Drawing.Size(158, 39);
            this.btnGenerarPublicacion.TabIndex = 0;
            this.btnGenerarPublicacion.Text = "Generar Publicación";
            this.btnGenerarPublicacion.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(62, 55);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(158, 39);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar / Ofertar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(62, 100);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(158, 39);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial de Compras / Subastas";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(62, 145);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(158, 39);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar Vendedor";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Location = new System.Drawing.Point(62, 190);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(158, 39);
            this.btnFacturas.TabIndex = 4;
            this.btnFacturas.Text = "Consultar Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(62, 242);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(158, 39);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmPantallaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 296);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnGenerarPublicacion);
            this.Name = "frmPantallaUsuario";
            this.Text = "Pantalla_de_Usuario";
            this.Load += new System.EventHandler(this.frmPantallaUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPublicacion;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnCerrar;
    }
}