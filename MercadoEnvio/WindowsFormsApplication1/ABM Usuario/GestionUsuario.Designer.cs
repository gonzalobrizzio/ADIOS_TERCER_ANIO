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
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnDeshabilitarCliente = new System.Windows.Forms.Button();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnHabilitarCliente = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.btnModificarEmpresa = new System.Windows.Forms.Button();
            this.btnHabilitarEmpresa = new System.Windows.Forms.Button();
            this.btnDeshabilitarEmpresa = new System.Windows.Forms.Button();
            this.buscarEmpresaEmailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buscarEmpresaCuitTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buscarEmpresaRazonSTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buscarClienteEmailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarClienteDniTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buscarClienteApellidoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarClienteNombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEmpresas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
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
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(582, 32);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(104, 26);
            this.btnBuscarClientes.TabIndex = 2;
            this.btnBuscarClientes.Text = "Buscar Clientes";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(904, 568);
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
            // buscarEmpresaEmailTxt
            // 
            this.buscarEmpresaEmailTxt.Location = new System.Drawing.Point(448, 573);
            this.buscarEmpresaEmailTxt.MaxLength = 75;
            this.buscarEmpresaEmailTxt.Name = "buscarEmpresaEmailTxt";
            this.buscarEmpresaEmailTxt.Size = new System.Drawing.Size(103, 20);
            this.buscarEmpresaEmailTxt.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Email:";
            // 
            // buscarEmpresaCuitTxt
            // 
            this.buscarEmpresaCuitTxt.Location = new System.Drawing.Point(282, 573);
            this.buscarEmpresaCuitTxt.MaxLength = 20;
            this.buscarEmpresaCuitTxt.Name = "buscarEmpresaCuitTxt";
            this.buscarEmpresaCuitTxt.Size = new System.Drawing.Size(98, 20);
            this.buscarEmpresaCuitTxt.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 105;
            this.label7.Text = "CUIT:";
            // 
            // buscarEmpresaRazonSTxt
            // 
            this.buscarEmpresaRazonSTxt.Location = new System.Drawing.Point(129, 574);
            this.buscarEmpresaRazonSTxt.MaxLength = 75;
            this.buscarEmpresaRazonSTxt.Name = "buscarEmpresaRazonSTxt";
            this.buscarEmpresaRazonSTxt.Size = new System.Drawing.Size(87, 20);
            this.buscarEmpresaRazonSTxt.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 103;
            this.label9.Text = "Razon Social:";
            // 
            // buscarClienteEmailTxt
            // 
            this.buscarClienteEmailTxt.Location = new System.Drawing.Point(482, 35);
            this.buscarClienteEmailTxt.MaxLength = 75;
            this.buscarClienteEmailTxt.Name = "buscarClienteEmailTxt";
            this.buscarClienteEmailTxt.Size = new System.Drawing.Size(76, 20);
            this.buscarClienteEmailTxt.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 115;
            this.label5.Text = "Email:";
            // 
            // buscarClienteDniTxt
            // 
            this.buscarClienteDniTxt.Location = new System.Drawing.Point(352, 35);
            this.buscarClienteDniTxt.MaxLength = 12;
            this.buscarClienteDniTxt.Name = "buscarClienteDniTxt";
            this.buscarClienteDniTxt.Size = new System.Drawing.Size(76, 20);
            this.buscarClienteDniTxt.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 113;
            this.label4.Text = "DNI:";
            // 
            // buscarClienteApellidoTxt
            // 
            this.buscarClienteApellidoTxt.Location = new System.Drawing.Point(233, 35);
            this.buscarClienteApellidoTxt.MaxLength = 29;
            this.buscarClienteApellidoTxt.Name = "buscarClienteApellidoTxt";
            this.buscarClienteApellidoTxt.Size = new System.Drawing.Size(76, 20);
            this.buscarClienteApellidoTxt.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 111;
            this.label3.Text = "Apellido:";
            // 
            // buscarClienteNombreTxt
            // 
            this.buscarClienteNombreTxt.Location = new System.Drawing.Point(91, 36);
            this.buscarClienteNombreTxt.MaxLength = 29;
            this.buscarClienteNombreTxt.Name = "buscarClienteNombreTxt";
            this.buscarClienteNombreTxt.Size = new System.Drawing.Size(76, 20);
            this.buscarClienteNombreTxt.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nombre:";
            // 
            // btnBuscarEmpresas
            // 
            this.btnBuscarEmpresas.Location = new System.Drawing.Point(577, 570);
            this.btnBuscarEmpresas.Name = "btnBuscarEmpresas";
            this.btnBuscarEmpresas.Size = new System.Drawing.Size(104, 26);
            this.btnBuscarEmpresas.TabIndex = 117;
            this.btnBuscarEmpresas.Text = "Buscar Empresas";
            this.btnBuscarEmpresas.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresas.Click += new System.EventHandler(this.btnBuscarEmpresas_Click);
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 611);
            this.Controls.Add(this.btnBuscarEmpresas);
            this.Controls.Add(this.buscarClienteEmailTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscarClienteDniTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscarClienteApellidoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscarClienteNombreTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarEmpresaEmailTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buscarEmpresaCuitTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buscarEmpresaRazonSTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHabilitarEmpresa);
            this.Controls.Add(this.btnDeshabilitarEmpresa);
            this.Controls.Add(this.btnModificarEmpresa);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.btnHabilitarCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscarClientes);
            this.Controls.Add(this.btnDeshabilitarCliente);
            this.Controls.Add(this.btnModificarCliente);
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

        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnDeshabilitarCliente;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnHabilitarCliente;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.Button btnModificarEmpresa;
        private System.Windows.Forms.Button btnHabilitarEmpresa;
        private System.Windows.Forms.Button btnDeshabilitarEmpresa;
        private System.Windows.Forms.TextBox buscarEmpresaEmailTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buscarEmpresaCuitTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox buscarEmpresaRazonSTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox buscarClienteEmailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buscarClienteDniTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buscarClienteApellidoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buscarClienteNombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEmpresas;

    }
}