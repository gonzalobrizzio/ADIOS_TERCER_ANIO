namespace MercadoEnvios.ABM_Usuario
{
    partial class frmModificarCliente
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
            this.Fecha_De_Nacimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Localidad = new System.Windows.Forms.ComboBox();
            this.CodigoPostal = new System.Windows.Forms.TextBox();
            this.Piso = new System.Windows.Forms.TextBox();
            this.Depto = new System.Windows.Forms.TextBox();
            this.Nro_de_Direccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Nro_de_Documento = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.calendarioNac = new System.Windows.Forms.MonthCalendar();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Tipo_de_Documento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fecha_De_Nacimiento
            // 
            this.Fecha_De_Nacimiento.Location = new System.Drawing.Point(485, 243);
            this.Fecha_De_Nacimiento.Name = "Fecha_De_Nacimiento";
            this.Fecha_De_Nacimiento.Size = new System.Drawing.Size(133, 20);
            this.Fecha_De_Nacimiento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Dirección de Mail:";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(153, 83);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(159, 20);
            this.Mail.TabIndex = 3;
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(153, 57);
            this.Contraseña.MaxLength = 8;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(159, 20);
            this.Contraseña.TabIndex = 2;
            // 
            // Usuario
            // 
            this.Usuario.AcceptsReturn = true;
            this.Usuario.Location = new System.Drawing.Point(153, 31);
            this.Usuario.MaxLength = 11;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(159, 20);
            this.Usuario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Nueva contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Usuario: ";
            // 
            // Localidad
            // 
            this.Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Localidad.FormattingEnabled = true;
            this.Localidad.Location = new System.Drawing.Point(153, 354);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(159, 21);
            this.Localidad.TabIndex = 12;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Location = new System.Drawing.Point(153, 381);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.CodigoPostal.TabIndex = 13;
            // 
            // Piso
            // 
            this.Piso.Location = new System.Drawing.Point(153, 328);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(57, 20);
            this.Piso.TabIndex = 11;
            // 
            // Depto
            // 
            this.Depto.Location = new System.Drawing.Point(153, 302);
            this.Depto.Name = "Depto";
            this.Depto.Size = new System.Drawing.Size(49, 20);
            this.Depto.TabIndex = 10;
            // 
            // Nro_de_Direccion
            // 
            this.Nro_de_Direccion.Location = new System.Drawing.Point(153, 273);
            this.Nro_de_Direccion.Name = "Nro_de_Direccion";
            this.Nro_de_Direccion.Size = new System.Drawing.Size(81, 20);
            this.Nro_de_Direccion.TabIndex = 9;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(153, 240);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 20);
            this.Direccion.TabIndex = 8;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(153, 214);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 20);
            this.Telefono.TabIndex = 7;
            // 
            // Nro_de_Documento
            // 
            this.Nro_de_Documento.Location = new System.Drawing.Point(153, 188);
            this.Nro_de_Documento.Name = "Nro_de_Documento";
            this.Nro_de_Documento.Size = new System.Drawing.Size(100, 20);
            this.Nro_de_Documento.TabIndex = 60;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(153, 135);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(153, 109);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Localidad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Depto.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Piso:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Dirección:";
            // 
            // calendarioNac
            // 
            this.calendarioNac.Location = new System.Drawing.Point(450, 68);
            this.calendarioNac.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.calendarioNac.Name = "calendarioNac";
            this.calendarioNac.TabIndex = 73;
            this.calendarioNac.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioNac_DateSelected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Nro de Doc.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Codigo Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nro de Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(588, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(483, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(42, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 15);
            this.label28.TabIndex = 273;
            this.label28.Text = "* : Campos Obligatorios";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(318, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 288;
            this.label18.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(318, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 16);
            this.label16.TabIndex = 287;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(318, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 16);
            this.label17.TabIndex = 286;
            this.label17.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(259, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 16);
            this.label19.TabIndex = 291;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(259, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 16);
            this.label20.TabIndex = 290;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(259, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 16);
            this.label21.TabIndex = 289;
            this.label21.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(259, 240);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 16);
            this.label23.TabIndex = 293;
            this.label23.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(628, 244);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 16);
            this.label24.TabIndex = 294;
            this.label24.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(259, 382);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 16);
            this.label25.TabIndex = 295;
            this.label25.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(260, 163);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 16);
            this.label22.TabIndex = 298;
            this.label22.Text = "*";
            // 
            // Tipo_de_Documento
            // 
            this.Tipo_de_Documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_de_Documento.FormattingEnabled = true;
            this.Tipo_de_Documento.Location = new System.Drawing.Point(154, 162);
            this.Tipo_de_Documento.Name = "Tipo_de_Documento";
            this.Tipo_de_Documento.Size = new System.Drawing.Size(100, 21);
            this.Tipo_de_Documento.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 297;
            this.label10.Text = "Tipo de Documento:";
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 455);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Tipo_de_Documento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Fecha_De_Nacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Localidad);
            this.Controls.Add(this.CodigoPostal);
            this.Controls.Add(this.Piso);
            this.Controls.Add(this.Depto);
            this.Controls.Add(this.Nro_de_Direccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Nro_de_Documento);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.calendarioNac);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fecha_De_Nacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Localidad;
        private System.Windows.Forms.TextBox CodigoPostal;
        private System.Windows.Forms.TextBox Piso;
        private System.Windows.Forms.TextBox Depto;
        private System.Windows.Forms.TextBox Nro_de_Direccion;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nro_de_Documento;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MonthCalendar calendarioNac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox Tipo_de_Documento;
        private System.Windows.Forms.Label label10;
    }
}