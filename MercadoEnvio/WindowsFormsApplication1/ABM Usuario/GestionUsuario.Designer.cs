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
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnDeshabilitarCliente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnHabilitarCliente = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.btnModificarEmpresa = new System.Windows.Forms.Button();
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
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(33, 302);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(109, 25);
            this.btnModificarCliente.TabIndex = 4;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnDeshabilitarCliente
            // 
            this.btnDeshabilitarCliente.Location = new System.Drawing.Point(418, 302);
            this.btnDeshabilitarCliente.Name = "btnDeshabilitarCliente";
            this.btnDeshabilitarCliente.Size = new System.Drawing.Size(109, 25);
            this.btnDeshabilitarCliente.TabIndex = 6;
            this.btnDeshabilitarCliente.Text = "Deshabilitar Cliente";
            this.btnDeshabilitarCliente.UseVisualStyleBackColor = true;
            this.btnDeshabilitarCliente.Click += new System.EventHandler(this.btnDeshabilitarCliente_Click);
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
            this.dgvClientes.Location = new System.Drawing.Point(33, 79);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(923, 207);
            this.dgvClientes.TabIndex = 11;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(900, 574);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 25);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(847, 302);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 25);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnHabilitarCliente
            // 
            this.btnHabilitarCliente.Location = new System.Drawing.Point(303, 302);
            this.btnHabilitarCliente.Name = "btnHabilitarCliente";
            this.btnHabilitarCliente.Size = new System.Drawing.Size(109, 25);
            this.btnHabilitarCliente.TabIndex = 5;
            this.btnHabilitarCliente.Text = "Habilitar Cliente";
            this.btnHabilitarCliente.UseVisualStyleBackColor = true;
            this.btnHabilitarCliente.Click += new System.EventHandler(this.btnHabilitarCliente_Click);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Location = new System.Drawing.Point(33, 348);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(923, 207);
            this.dgvEmpresas.TabIndex = 12;
            this.dgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellClick);
            // 
            // btnModificarEmpresa
            // 
            this.btnModificarEmpresa.Location = new System.Drawing.Point(148, 302);
            this.btnModificarEmpresa.Name = "btnModificarEmpresa";
            this.btnModificarEmpresa.Size = new System.Drawing.Size(109, 25);
            this.btnModificarEmpresa.TabIndex = 13;
            this.btnModificarEmpresa.Text = "Modificar Empresa";
            this.btnModificarEmpresa.UseVisualStyleBackColor = true;
            this.btnModificarEmpresa.Click += new System.EventHandler(this.btnModificarEmpresa_Click);
            // 
            // btnHabilitarEmpresa
            // 
            this.btnHabilitarEmpresa.Location = new System.Drawing.Point(572, 302);
            this.btnHabilitarEmpresa.Name = "btnHabilitarEmpresa";
            this.btnHabilitarEmpresa.Size = new System.Drawing.Size(109, 25);
            this.btnHabilitarEmpresa.TabIndex = 14;
            this.btnHabilitarEmpresa.Text = "Habilitar Empresa";
            this.btnHabilitarEmpresa.UseVisualStyleBackColor = true;
            this.btnHabilitarEmpresa.Click += new System.EventHandler(this.btnHabilitarEmpresa_Click);
            // 
            // btnDeshabilitarEmpresa
            // 
            this.btnDeshabilitarEmpresa.Location = new System.Drawing.Point(687, 302);
            this.btnDeshabilitarEmpresa.Name = "btnDeshabilitarEmpresa";
            this.btnDeshabilitarEmpresa.Size = new System.Drawing.Size(115, 25);
            this.btnDeshabilitarEmpresa.TabIndex = 15;
            this.btnDeshabilitarEmpresa.Text = "Deshabilitar Empresa";
            this.btnDeshabilitarEmpresa.UseVisualStyleBackColor = true;
            this.btnDeshabilitarEmpresa.Click += new System.EventHandler(this.btnDeshabilitarEmpresa_Click);
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 611);
            this.Controls.Add(this.btnHabilitarEmpresa);
            this.Controls.Add(this.btnDeshabilitarEmpresa);
            this.Controls.Add(this.btnModificarEmpresa);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.btnHabilitarCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDeshabilitarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.txtBuscado);
            this.Name = "frmABMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Usuarios";
            this.Shown += new System.EventHandler(this.frmABMUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnDeshabilitarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnHabilitarCliente;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.Button btnModificarEmpresa;
        private System.Windows.Forms.Button btnHabilitarEmpresa;
        private System.Windows.Forms.Button btnDeshabilitarEmpresa;

    }
}