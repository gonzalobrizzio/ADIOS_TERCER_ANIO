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
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.buscarClienteEmailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarClienteDniTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.TabControl();
            this.busquedaClienteTp = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.mailC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.TabPage();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.mailE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.E.SuspendLayout();
            this.busquedaClienteTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.Empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(501, 194);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(104, 26);
            this.btnBuscarClientes.TabIndex = 2;
            this.btnBuscarClientes.Text = "Buscar Clientes";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(726, 462);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 25);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // buscarClienteEmailTxt
            // 
            this.buscarClienteEmailTxt.Location = new System.Drawing.Point(401, 197);
            this.buscarClienteEmailTxt.MaxLength = 75;
            this.buscarClienteEmailTxt.Name = "buscarClienteEmailTxt";
            this.buscarClienteEmailTxt.Size = new System.Drawing.Size(76, 20);
            this.buscarClienteEmailTxt.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 115;
            this.label5.Text = "Email:";
            // 
            // buscarClienteDniTxt
            // 
            this.buscarClienteDniTxt.Location = new System.Drawing.Point(271, 197);
            this.buscarClienteDniTxt.MaxLength = 12;
            this.buscarClienteDniTxt.Name = "buscarClienteDniTxt";
            this.buscarClienteDniTxt.Size = new System.Drawing.Size(76, 20);
            this.buscarClienteDniTxt.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 113;
            this.label4.Text = "DNI:";
            // 
            // E
            // 
            this.E.Controls.Add(this.busquedaClienteTp);
            this.E.Controls.Add(this.Empresa);
            this.E.ItemSize = new System.Drawing.Size(50, 25);
            this.E.Location = new System.Drawing.Point(26, 50);
            this.E.Name = "E";
            this.E.SelectedIndex = 0;
            this.E.Size = new System.Drawing.Size(819, 391);
            this.E.TabIndex = 118;
            this.E.SelectedIndexChanged += new System.EventHandler(this.E_SelectedIndexChanged);
            // 
            // busquedaClienteTp
            // 
            this.busquedaClienteTp.Controls.Add(this.dgvClientes);
            this.busquedaClienteTp.Controls.Add(this.mailC);
            this.busquedaClienteTp.Controls.Add(this.label2);
            this.busquedaClienteTp.Controls.Add(this.dni);
            this.busquedaClienteTp.Controls.Add(this.label8);
            this.busquedaClienteTp.Controls.Add(this.apellido);
            this.busquedaClienteTp.Controls.Add(this.label10);
            this.busquedaClienteTp.Controls.Add(this.nombre);
            this.busquedaClienteTp.Controls.Add(this.label11);
            this.busquedaClienteTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaClienteTp.Location = new System.Drawing.Point(4, 29);
            this.busquedaClienteTp.Name = "busquedaClienteTp";
            this.busquedaClienteTp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.busquedaClienteTp.Size = new System.Drawing.Size(811, 358);
            this.busquedaClienteTp.TabIndex = 0;
            this.busquedaClienteTp.Text = "Cliente";
            this.busquedaClienteTp.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 61);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(799, 282);
            this.dgvClientes.TabIndex = 95;
            // 
            // mailC
            // 
            this.mailC.Location = new System.Drawing.Point(445, 19);
            this.mailC.MaxLength = 75;
            this.mailC.Name = "mailC";
            this.mailC.Size = new System.Drawing.Size(76, 20);
            this.mailC.TabIndex = 94;
            this.mailC.TextChanged += new System.EventHandler(this.mailC_TextChanged);
            this.mailC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 93;
            this.label2.Text = "Email:";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(324, 19);
            this.dni.MaxLength = 12;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(76, 20);
            this.dni.TabIndex = 92;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 91;
            this.label8.Text = "DNI:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(205, 20);
            this.apellido.MaxLength = 29;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(76, 20);
            this.apellido.TabIndex = 90;
            this.apellido.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellido_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 89;
            this.label10.Text = "Apellido:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(63, 19);
            this.nombre.MaxLength = 29;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(76, 20);
            this.nombre.TabIndex = 88;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 87;
            this.label11.Text = "Nombre:";
            // 
            // Empresa
            // 
            this.Empresa.Controls.Add(this.dgvEmpresas);
            this.Empresa.Controls.Add(this.mailE);
            this.Empresa.Controls.Add(this.label12);
            this.Empresa.Controls.Add(this.cuit);
            this.Empresa.Controls.Add(this.label13);
            this.Empresa.Controls.Add(this.razonSocial);
            this.Empresa.Controls.Add(this.label14);
            this.Empresa.Location = new System.Drawing.Point(4, 29);
            this.Empresa.Name = "Empresa";
            this.Empresa.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Empresa.Size = new System.Drawing.Size(811, 358);
            this.Empresa.TabIndex = 1;
            this.Empresa.Text = "Empresa";
            this.Empresa.UseVisualStyleBackColor = true;
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Location = new System.Drawing.Point(6, 61);
            this.dgvEmpresas.MultiSelect = false;
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresas.Size = new System.Drawing.Size(799, 282);
            this.dgvEmpresas.TabIndex = 103;
            // 
            // mailE
            // 
            this.mailE.Location = new System.Drawing.Point(385, 18);
            this.mailE.MaxLength = 75;
            this.mailE.Name = "mailE";
            this.mailE.Size = new System.Drawing.Size(103, 20);
            this.mailE.TabIndex = 102;
            this.mailE.TextChanged += new System.EventHandler(this.mailE_TextChanged);
            this.mailE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailE_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(337, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 101;
            this.label12.Text = "Email:";
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(233, 18);
            this.cuit.MaxLength = 20;
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(98, 20);
            this.cuit.TabIndex = 100;
            this.cuit.TextChanged += new System.EventHandler(this.cuit_TextChanged);
            this.cuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cuit_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(190, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 99;
            this.label13.Text = "CUIT:";
            // 
            // razonSocial
            // 
            this.razonSocial.Location = new System.Drawing.Point(97, 18);
            this.razonSocial.MaxLength = 75;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(87, 20);
            this.razonSocial.TabIndex = 98;
            this.razonSocial.TextChanged += new System.EventHandler(this.razonSocial_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 97;
            this.label14.Text = "Razon Social:";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(165, 462);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(109, 25);
            this.btnHabilitar.TabIndex = 124;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(280, 462);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(115, 25);
            this.btnDeshabilitar.TabIndex = 125;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(401, 462);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(109, 25);
            this.btnAgregarUsuario.TabIndex = 119;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(50, 462);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 25);
            this.btnModificar.TabIndex = 120;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 512);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.E);
            this.Controls.Add(this.buscarClienteEmailTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscarClienteDniTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscarClientes);
            this.Name = "frmABMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Usuarios";
            this.E.ResumeLayout(false);
            this.busquedaClienteTp.ResumeLayout(false);
            this.busquedaClienteTp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.Empresa.ResumeLayout(false);
            this.Empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox buscarClienteEmailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buscarClienteDniTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl E;
        private System.Windows.Forms.TabPage busquedaClienteTp;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox mailC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage Empresa;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.TextBox mailE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificar;

    }
}