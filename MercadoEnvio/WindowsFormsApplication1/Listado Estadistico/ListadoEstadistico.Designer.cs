namespace MercadoEnvios.Listado_Estadistico
{
    partial class frmListadoEstadistico
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.ComboBox();
            this.trimestre = new System.Windows.Forms.ComboBox();
            this.tipo_de_listado = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.visibilidad = new System.Windows.Forms.ComboBox();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblVisibilidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(111, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 34);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trimestre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de Listado:";
            // 
            // anio
            // 
            this.anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anio.FormattingEnabled = true;
            this.anio.Location = new System.Drawing.Point(111, 225);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(121, 21);
            this.anio.TabIndex = 11;
            // 
            // trimestre
            // 
            this.trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimestre.FormattingEnabled = true;
            this.trimestre.Location = new System.Drawing.Point(111, 161);
            this.trimestre.Name = "trimestre";
            this.trimestre.Size = new System.Drawing.Size(121, 21);
            this.trimestre.TabIndex = 10;
            // 
            // tipo_de_listado
            // 
            this.tipo_de_listado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_de_listado.FormattingEnabled = true;
            this.tipo_de_listado.Location = new System.Drawing.Point(111, 101);
            this.tipo_de_listado.Name = "tipo_de_listado";
            this.tipo_de_listado.Size = new System.Drawing.Size(309, 21);
            this.tipo_de_listado.TabIndex = 9;
            this.tipo_de_listado.SelectedIndexChanged += new System.EventHandler(this.tipo_de_listado_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(284, 290);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 34);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // visibilidad
            // 
            this.visibilidad.BackColor = System.Drawing.SystemColors.Window;
            this.visibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visibilidad.FormattingEnabled = true;
            this.visibilidad.Location = new System.Drawing.Point(266, 161);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Size = new System.Drawing.Size(154, 21);
            this.visibilidad.TabIndex = 17;
            // 
            // rubro
            // 
            this.rubro.BackColor = System.Drawing.SystemColors.Window;
            this.rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(266, 161);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(154, 21);
            this.rubro.TabIndex = 18;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(263, 145);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(39, 13);
            this.lblRubro.TabIndex = 19;
            this.lblRubro.Text = "Rubro:";
            // 
            // lblVisibilidad
            // 
            this.lblVisibilidad.AutoSize = true;
            this.lblVisibilidad.Location = new System.Drawing.Point(263, 145);
            this.lblVisibilidad.Name = "lblVisibilidad";
            this.lblVisibilidad.Size = new System.Drawing.Size(56, 13);
            this.lblVisibilidad.TabIndex = 20;
            this.lblVisibilidad.Text = "Visibilidad:";
            // 
            // frmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 384);
            this.Controls.Add(this.lblVisibilidad);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.visibilidad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.trimestre);
            this.Controls.Add(this.tipo_de_listado);
            this.Name = "frmListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Estadistico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anio;
        private System.Windows.Forms.ComboBox trimestre;
        private System.Windows.Forms.ComboBox tipo_de_listado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox visibilidad;
        private System.Windows.Forms.ComboBox rubro;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblVisibilidad;
    }
}