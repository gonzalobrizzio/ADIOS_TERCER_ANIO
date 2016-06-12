namespace MercadoEnvios.ABM_Usuario
{
    partial class frmNuevoCliente
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.calendarioNac = new System.Windows.Forms.MonthCalendar();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellido = new System.Windows.Forms.TextBox();
            this.campoNroDeDoc = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoNroDeDireccion = new System.Windows.Forms.TextBox();
            this.campoDepto = new System.Windows.Forms.TextBox();
            this.campoPiso = new System.Windows.Forms.TextBox();
            this.campoCodigoPostal = new System.Windows.Forms.TextBox();
            this.comboLocalidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoMail = new System.Windows.Forms.TextBox();
            this.campoContrasenia = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.campoFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(486, 411);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(594, 411);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro de Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código Postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tipo de Documento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Apellido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Número de documento:";
            // 
            // calendarioNac
            // 
            this.calendarioNac.Location = new System.Drawing.Point(466, 72);
            this.calendarioNac.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.calendarioNac.Name = "calendarioNac";
            this.calendarioNac.TabIndex = 15;
            this.calendarioNac.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Dirección:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Piso:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Depto.:";
            // 
            // comboTipoDeDocumento
            // 
            this.comboTipoDeDocumento.FormattingEnabled = true;
            this.comboTipoDeDocumento.Location = new System.Drawing.Point(149, 191);
            this.comboTipoDeDocumento.Name = "comboTipoDeDocumento";
            this.comboTipoDeDocumento.Size = new System.Drawing.Size(81, 21);
            this.comboTipoDeDocumento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Localidad:";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(149, 113);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(100, 20);
            this.campoNombre.TabIndex = 4;
            // 
            // campoApellido
            // 
            this.campoApellido.Location = new System.Drawing.Point(149, 139);
            this.campoApellido.Name = "campoApellido";
            this.campoApellido.Size = new System.Drawing.Size(100, 20);
            this.campoApellido.TabIndex = 5;
            // 
            // campoNroDeDoc
            // 
            this.campoNroDeDoc.Location = new System.Drawing.Point(167, 165);
            this.campoNroDeDoc.Name = "campoNroDeDoc";
            this.campoNroDeDoc.Size = new System.Drawing.Size(100, 20);
            this.campoNroDeDoc.TabIndex = 6;
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(149, 218);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(100, 20);
            this.campoTelefono.TabIndex = 8;
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(149, 244);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(100, 20);
            this.campoDireccion.TabIndex = 9;
            // 
            // campoNroDeDireccion
            // 
            this.campoNroDeDireccion.Location = new System.Drawing.Point(149, 277);
            this.campoNroDeDireccion.Name = "campoNroDeDireccion";
            this.campoNroDeDireccion.Size = new System.Drawing.Size(81, 20);
            this.campoNroDeDireccion.TabIndex = 10;
            // 
            // campoDepto
            // 
            this.campoDepto.Location = new System.Drawing.Point(149, 306);
            this.campoDepto.Name = "campoDepto";
            this.campoDepto.Size = new System.Drawing.Size(49, 20);
            this.campoDepto.TabIndex = 11;
            // 
            // campoPiso
            // 
            this.campoPiso.Location = new System.Drawing.Point(149, 332);
            this.campoPiso.Name = "campoPiso";
            this.campoPiso.Size = new System.Drawing.Size(57, 20);
            this.campoPiso.TabIndex = 12;
            // 
            // campoCodigoPostal
            // 
            this.campoCodigoPostal.Location = new System.Drawing.Point(149, 385);
            this.campoCodigoPostal.Name = "campoCodigoPostal";
            this.campoCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.campoCodigoPostal.TabIndex = 14;
            // 
            // comboLocalidad
            // 
            this.comboLocalidad.FormattingEnabled = true;
            this.comboLocalidad.Location = new System.Drawing.Point(149, 358);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(130, 21);
            this.comboLocalidad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Dirección de Mail:";
            // 
            // campoMail
            // 
            this.campoMail.Location = new System.Drawing.Point(149, 87);
            this.campoMail.Name = "campoMail";
            this.campoMail.Size = new System.Drawing.Size(159, 20);
            this.campoMail.TabIndex = 3;
            // 
            // campoContrasenia
            // 
            this.campoContrasenia.Location = new System.Drawing.Point(149, 61);
            this.campoContrasenia.MaxLength = 8;
            this.campoContrasenia.Name = "campoContrasenia";
            this.campoContrasenia.PasswordChar = '*';
            this.campoContrasenia.Size = new System.Drawing.Size(159, 20);
            this.campoContrasenia.TabIndex = 2;
            // 
            // campoUsuario
            // 
            this.campoUsuario.AcceptsReturn = true;
            this.campoUsuario.Location = new System.Drawing.Point(149, 35);
            this.campoUsuario.MaxLength = 11;
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(159, 20);
            this.campoUsuario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Usuario: ";
            // 
            // campoFechaDeNacimiento
            // 
            this.campoFechaDeNacimiento.Location = new System.Drawing.Point(501, 247);
            this.campoFechaDeNacimiento.Name = "campoFechaDeNacimiento";
            this.campoFechaDeNacimiento.Size = new System.Drawing.Size(133, 20);
            this.campoFechaDeNacimiento.TabIndex = 49;
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 455);
            this.Controls.Add(this.campoFechaDeNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoMail);
            this.Controls.Add(this.campoContrasenia);
            this.Controls.Add(this.campoUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboLocalidad);
            this.Controls.Add(this.campoCodigoPostal);
            this.Controls.Add(this.campoPiso);
            this.Controls.Add(this.campoDepto);
            this.Controls.Add(this.campoNroDeDireccion);
            this.Controls.Add(this.campoDireccion);
            this.Controls.Add(this.campoTelefono);
            this.Controls.Add(this.campoNroDeDoc);
            this.Controls.Add(this.campoApellido);
            this.Controls.Add(this.campoNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTipoDeDocumento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.calendarioNac);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmNuevoCliente";
            this.Text = "Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MonthCalendar calendarioNac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboTipoDeDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellido;
        private System.Windows.Forms.TextBox campoNroDeDoc;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoNroDeDireccion;
        private System.Windows.Forms.TextBox campoDepto;
        private System.Windows.Forms.TextBox campoPiso;
        private System.Windows.Forms.TextBox campoCodigoPostal;
        private System.Windows.Forms.ComboBox comboLocalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoMail;
        private System.Windows.Forms.TextBox campoContrasenia;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoFechaDeNacimiento;
    }
}