namespace WindowsFormsApplication1
{
    partial class frmPantallaAdministrador
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
            this.btnRol = new System.Windows.Forms.Button();
            this.btnUsr = new System.Windows.Forms.Button();
            this.btnVisibilidad = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(56, 12);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(179, 49);
            this.btnRol.TabIndex = 0;
            this.btnRol.Text = "ABM de Rol";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsr
            // 
            this.btnUsr.Location = new System.Drawing.Point(56, 67);
            this.btnUsr.Name = "btnUsr";
            this.btnUsr.Size = new System.Drawing.Size(179, 49);
            this.btnUsr.TabIndex = 1;
            this.btnUsr.Text = "ABM de Usuarios";
            this.btnUsr.UseVisualStyleBackColor = true;
            // 
            // btnVisibilidad
            // 
            this.btnVisibilidad.Location = new System.Drawing.Point(56, 122);
            this.btnVisibilidad.Name = "btnVisibilidad";
            this.btnVisibilidad.Size = new System.Drawing.Size(179, 49);
            this.btnVisibilidad.TabIndex = 2;
            this.btnVisibilidad.Text = "ABM de Visibilidad";
            this.btnVisibilidad.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(82, 185);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(135, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmPantallaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 232);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVisibilidad);
            this.Controls.Add(this.btnUsr);
            this.Controls.Add(this.btnRol);
            this.Name = "frmPantallaAdministrador";
            this.Text = "Pantalla_Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnUsr;
        private System.Windows.Forms.Button btnVisibilidad;
        private System.Windows.Forms.Button btnCerrar;
    }
}