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
            this.btnCerrarSesion.Location = new System.Drawing.Point(208, 277);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(191, 41);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // funcionalidadesR
            // 
            this.funcionalidadesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionalidadesR.Location = new System.Drawing.Point(16, 15);
            this.funcionalidadesR.Margin = new System.Windows.Forms.Padding(4);
            this.funcionalidadesR.Name = "funcionalidadesR";
            this.funcionalidadesR.Size = new System.Drawing.Size(383, 246);
            this.funcionalidadesR.TabIndex = 10;
            this.funcionalidadesR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionalidadesR_CellClick);
            // 
            // btnElegirFuncionalidad
            // 
            this.btnElegirFuncionalidad.Location = new System.Drawing.Point(16, 277);
            this.btnElegirFuncionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnElegirFuncionalidad.Name = "btnElegirFuncionalidad";
            this.btnElegirFuncionalidad.Size = new System.Drawing.Size(184, 41);
            this.btnElegirFuncionalidad.TabIndex = 11;
            this.btnElegirFuncionalidad.Text = "Elegir funcionalidad";
            this.btnElegirFuncionalidad.UseVisualStyleBackColor = true;
            this.btnElegirFuncionalidad.Click += new System.EventHandler(this.btnElegirFuncionalidad_Click);
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 332);
            this.Controls.Add(this.btnElegirFuncionalidad);
            this.Controls.Add(this.funcionalidadesR);
            this.Controls.Add(this.btnCerrarSesion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPantallaPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadesR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataGridView funcionalidadesR;
        private System.Windows.Forms.Button btnElegirFuncionalidad;
    }
}