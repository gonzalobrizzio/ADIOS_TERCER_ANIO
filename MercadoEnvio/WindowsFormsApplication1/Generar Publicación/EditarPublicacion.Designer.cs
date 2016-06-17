namespace MercadoEnvios.Generar_Publicación
{
    partial class EditarPublicacion
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
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.habilitarEnvios = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tipo_de_Publicacion = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Visibilidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.habilitarPreguntas = new System.Windows.Forms.CheckBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblnameErr = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Rubro
            // 
            this.Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(22, 293);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(177, 21);
            this.Rubro.TabIndex = 6;
            // 
            // habilitarEnvios
            // 
            this.habilitarEnvios.AutoSize = true;
            this.habilitarEnvios.Location = new System.Drawing.Point(22, 354);
            this.habilitarEnvios.Name = "habilitarEnvios";
            this.habilitarEnvios.Size = new System.Drawing.Size(98, 17);
            this.habilitarEnvios.TabIndex = 8;
            this.habilitarEnvios.Text = "Habilitar envios";
            this.habilitarEnvios.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(65, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 820;
            this.label9.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 819;
            this.label6.Text = "Tipo de Publicación";
            // 
            // Tipo_de_Publicacion
            // 
            this.Tipo_de_Publicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_de_Publicacion.FormattingEnabled = true;
            this.Tipo_de_Publicacion.Location = new System.Drawing.Point(266, 244);
            this.Tipo_de_Publicacion.Name = "Tipo_de_Publicacion";
            this.Tipo_de_Publicacion.Size = new System.Drawing.Size(180, 21);
            this.Tipo_de_Publicacion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(361, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Visibilidad
            // 
            this.Visibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Visibilidad.FormattingEnabled = true;
            this.Visibilidad.Location = new System.Drawing.Point(22, 244);
            this.Visibilidad.Name = "Visibilidad";
            this.Visibilidad.Size = new System.Drawing.Size(177, 21);
            this.Visibilidad.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 818;
            this.label8.Text = "Visibilidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 817;
            this.label4.Text = "Rubro:";
            // 
            // habilitarPreguntas
            // 
            this.habilitarPreguntas.AutoSize = true;
            this.habilitarPreguntas.Location = new System.Drawing.Point(22, 331);
            this.habilitarPreguntas.Name = "habilitarPreguntas";
            this.habilitarPreguntas.Size = new System.Drawing.Size(114, 17);
            this.habilitarPreguntas.TabIndex = 7;
            this.habilitarPreguntas.Text = "Habilitar preguntas";
            this.habilitarPreguntas.UseVisualStyleBackColor = true;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(22, 188);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(177, 20);
            this.Precio.TabIndex = 2;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(266, 188);
            this.Stock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Stock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(180, 20);
            this.Stock.TabIndex = 3;
            this.Stock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(18, 22);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 15);
            this.label28.TabIndex = 816;
            this.label28.Text = "* : Campos Obligatorios";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(89, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 815;
            this.label18.Text = "*";
            // 
            // lblnameErr
            // 
            this.lblnameErr.AutoSize = true;
            this.lblnameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameErr.ForeColor = System.Drawing.Color.Red;
            this.lblnameErr.Location = new System.Drawing.Point(90, 50);
            this.lblnameErr.Name = "lblnameErr";
            this.lblnameErr.Size = new System.Drawing.Size(0, 13);
            this.lblnameErr.TabIndex = 814;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(226, 391);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 34);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 813;
            this.label5.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 812;
            this.label3.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 811;
            this.label1.Text = "Descripción:";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(21, 66);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(472, 79);
            this.Descripcion.TabIndex = 1;
            // 
            // EditarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 452);
            this.Controls.Add(this.Rubro);
            this.Controls.Add(this.habilitarEnvios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tipo_de_Publicacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Visibilidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.habilitarPreguntas);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblnameErr);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descripcion);
            this.Name = "EditarPublicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarPublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Rubro;
        private System.Windows.Forms.CheckBox habilitarEnvios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Tipo_de_Publicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox Visibilidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox habilitarPreguntas;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.NumericUpDown Stock;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblnameErr;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Descripcion;
    }
}