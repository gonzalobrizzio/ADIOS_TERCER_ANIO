namespace MercadoEnvios.Generar_Publicación
{
    partial class frmGenerarPublicacion
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
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoDePublicacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.visibilidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.habilitarPreguntas = new System.Windows.Forms.CheckBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblnameErr = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.rubros = new System.Windows.Forms.DataGridView();
            this.rubrosSeleccionados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(59, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 284;
            this.label9.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 282;
            this.label6.Text = "Tipo de Publicación";
            // 
            // tipoDePublicacion
            // 
            this.tipoDePublicacion.FormattingEnabled = true;
            this.tipoDePublicacion.Items.AddRange(new object[] {
            "Compra inmediata",
            "Subasta"});
            this.tipoDePublicacion.Location = new System.Drawing.Point(450, 254);
            this.tipoDePublicacion.Name = "tipoDePublicacion";
            this.tipoDePublicacion.Size = new System.Drawing.Size(180, 21);
            this.tipoDePublicacion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 281;
            this.label2.Text = "Rubros Sellecionados:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(351, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 21);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "<<";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(351, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 21);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(636, 578);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // visibilidad
            // 
            this.visibilidad.FormattingEnabled = true;
            this.visibilidad.Location = new System.Drawing.Point(16, 254);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Size = new System.Drawing.Size(177, 21);
            this.visibilidad.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 276;
            this.label8.Text = "Visibilidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 274;
            this.label4.Text = "Rubros:";
            // 
            // habilitarPreguntas
            // 
            this.habilitarPreguntas.AutoSize = true;
            this.habilitarPreguntas.Location = new System.Drawing.Point(23, 528);
            this.habilitarPreguntas.Name = "habilitarPreguntas";
            this.habilitarPreguntas.Size = new System.Drawing.Size(109, 17);
            this.habilitarPreguntas.TabIndex = 8;
            this.habilitarPreguntas.Text = "Habilitar pregunta";
            this.habilitarPreguntas.UseVisualStyleBackColor = true;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(16, 198);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(177, 20);
            this.precio.TabIndex = 2;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(450, 198);
            this.stock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(180, 20);
            this.stock.TabIndex = 3;
            this.stock.Value = new decimal(new int[] {
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
            this.label28.Location = new System.Drawing.Point(12, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 15);
            this.label28.TabIndex = 272;
            this.label28.Text = "* : Campos Obligatorios";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(83, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 271;
            this.label18.Text = "*";
            // 
            // lblnameErr
            // 
            this.lblnameErr.AutoSize = true;
            this.lblnameErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameErr.ForeColor = System.Drawing.Color.Red;
            this.lblnameErr.Location = new System.Drawing.Point(84, 60);
            this.lblnameErr.Name = "lblnameErr";
            this.lblnameErr.Size = new System.Drawing.Size(0, 13);
            this.lblnameErr.TabIndex = 270;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(501, 578);
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
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 269;
            this.label5.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 268;
            this.label3.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 267;
            this.label1.Text = "Descripción:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(15, 76);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(472, 79);
            this.descripcion.TabIndex = 1;
            // 
            // rubros
            // 
            this.rubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rubros.Location = new System.Drawing.Point(16, 317);
            this.rubros.Name = "rubros";
            this.rubros.Size = new System.Drawing.Size(315, 205);
            this.rubros.TabIndex = 800;
            // 
            // rubrosSeleccionados
            // 
            this.rubrosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rubrosSeleccionados.Location = new System.Drawing.Point(450, 317);
            this.rubrosSeleccionados.Name = "rubrosSeleccionados";
            this.rubrosSeleccionados.Size = new System.Drawing.Size(315, 205);
            this.rubrosSeleccionados.TabIndex = 286;
            // 
            // frmGenerarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 636);
            this.Controls.Add(this.rubrosSeleccionados);
            this.Controls.Add(this.rubros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipoDePublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.visibilidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.habilitarPreguntas);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblnameErr);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcion);
            this.Name = "frmGenerarPublicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Publicación";
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoDePublicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox visibilidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox habilitarPreguntas;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.NumericUpDown stock;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblnameErr;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.DataGridView rubros;
        private System.Windows.Forms.DataGridView rubrosSeleccionados;

    }
}