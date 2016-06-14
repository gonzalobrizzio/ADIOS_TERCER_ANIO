namespace MercadoEnvios.ABM_Usuario
{
    partial class frmABMUsuario
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
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.btnModificarEmpresa = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnHabilitarEmpresa = new System.Windows.Forms.Button();
            this.btnDeshabilitarEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscado.Location = new System.Drawing.Point(33, 12);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(343, 26);
            this.txtBuscado.TabIndex = 1;
            // 
            // btnModificarEmpresa
            // 
            this.btnModificarEmpresa.Location = new System.Drawing.Point(51, 515);
            this.btnModificarEmpresa.Name = "btnModificarEmpresa";
            this.btnModificarEmpresa.Size = new System.Drawing.Size(129, 25);
            this.btnModificarEmpresa.TabIndex = 4;
            this.btnModificarEmpresa.Text = "Modificar Cliente";
            this.btnModificarEmpresa.UseVisualStyleBackColor = true;
            this.btnModificarEmpresa.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 515);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 25);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Deshabilitar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(382, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(33, 89);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(455, 420);
            this.dgvClientes.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(928, 564);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 25);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(456, 515);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 25);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(186, 515);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(129, 25);
            this.btnHabilitar.TabIndex = 5;
            this.btnHabilitar.Text = "Habilitar Cliente";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Location = new System.Drawing.Point(555, 89);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(455, 420);
            this.dgvEmpresas.TabIndex = 12;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(591, 515);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(129, 25);
            this.btnModificarCliente.TabIndex = 7;
            this.btnModificarCliente.Text = "Modificar Empresa";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnHabilitarEmpresa
            // 
            this.btnHabilitarEmpresa.Location = new System.Drawing.Point(726, 515);
            this.btnHabilitarEmpresa.Name = "btnHabilitarEmpresa";
            this.btnHabilitarEmpresa.Size = new System.Drawing.Size(129, 25);
            this.btnHabilitarEmpresa.TabIndex = 8;
            this.btnHabilitarEmpresa.Text = "Habilitar Empresa";
            this.btnHabilitarEmpresa.UseVisualStyleBackColor = true;
            this.btnHabilitarEmpresa.Click += new System.EventHandler(this.btnHabilitarEmpresa_Click);
            // 
            // btnDeshabilitarEmpresa
            // 
            this.btnDeshabilitarEmpresa.Location = new System.Drawing.Point(861, 515);
            this.btnDeshabilitarEmpresa.Name = "btnDeshabilitarEmpresa";
            this.btnDeshabilitarEmpresa.Size = new System.Drawing.Size(129, 25);
            this.btnDeshabilitarEmpresa.TabIndex = 9;
            this.btnDeshabilitarEmpresa.Text = "Deshabilitar Empresa";
            this.btnDeshabilitarEmpresa.UseVisualStyleBackColor = true;
            this.btnDeshabilitarEmpresa.Click += new System.EventHandler(this.btnDeshabilitarEmpresa_Click);
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.btnDeshabilitarEmpresa);
            this.Controls.Add(this.btnHabilitarEmpresa);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarEmpresa);
            this.Controls.Add(this.txtBuscado);
            this.Name = "frmABMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmABMUsuario_FormClosed);
            this.Shown += new System.EventHandler(this.frmABMUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button btnModificarEmpresa;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnHabilitarEmpresa;
        private System.Windows.Forms.Button btnDeshabilitarEmpresa;

    }
}