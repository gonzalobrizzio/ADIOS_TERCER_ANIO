namespace MercadoEnvios.ABM_Usuario
{
    partial class frmPantallaPrincipal
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.funcionalidadesR = new System.Windows.Forms.DataGridView();
            this.btnElegirFuncionalidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(189, 225);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 33);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // funcionalidadesR
            // 
            this.funcionalidadesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionalidadesR.Location = new System.Drawing.Point(12, 12);
            this.funcionalidadesR.Name = "funcionalidadesR";
            this.funcionalidadesR.Size = new System.Drawing.Size(330, 200);
            this.funcionalidadesR.TabIndex = 10;
            this.funcionalidadesR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionalidadesR_CellClick);
            // 
            // btnElegirFuncionalidad
            // 
            this.btnElegirFuncionalidad.Location = new System.Drawing.Point(12, 225);
            this.btnElegirFuncionalidad.Name = "btnElegirFuncionalidad";
            this.btnElegirFuncionalidad.Size = new System.Drawing.Size(155, 33);
            this.btnElegirFuncionalidad.TabIndex = 11;
            this.btnElegirFuncionalidad.Text = "Elegir funcionalidad";
            this.btnElegirFuncionalidad.UseVisualStyleBackColor = true;
            this.btnElegirFuncionalidad.Click += new System.EventHandler(this.btnElegirFuncionalidad_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 270);
            this.Controls.Add(this.btnElegirFuncionalidad);
            this.Controls.Add(this.funcionalidadesR);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataGridView funcionalidadesR;
        private System.Windows.Forms.Button btnElegirFuncionalidad;
    }
}