namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class frmGestionUsuario
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
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.btnAgregarEmpresa = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(136, 20);
            this.lblListaUsuarios.TabIndex = 1;
            this.lblListaUsuarios.Text = "Lista de Usuarios:";
            // 
            // btnAgregarEmpresa
            // 
            this.btnAgregarEmpresa.Location = new System.Drawing.Point(193, 158);
            this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
            this.btnAgregarEmpresa.Size = new System.Drawing.Size(119, 36);
            this.btnAgregarEmpresa.TabIndex = 3;
            this.btnAgregarEmpresa.Text = "Agregar Empresa";
            this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(194, 116);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(119, 36);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscado.Location = new System.Drawing.Point(193, 38);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(118, 26);
            this.txtBuscado.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(194, 200);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 36);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar Usuario";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(194, 242);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(194, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 36);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar Usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(16, 38);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(172, 238);
            this.lstUsuarios.TabIndex = 9;
            // 
            // frmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 290);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBuscado);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnAgregarEmpresa);
            this.Controls.Add(this.lblListaUsuarios);
            this.Name = "frmGestionUsuario";
            this.Text = "GestionUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Button btnAgregarEmpresa;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstUsuarios;

    }
}