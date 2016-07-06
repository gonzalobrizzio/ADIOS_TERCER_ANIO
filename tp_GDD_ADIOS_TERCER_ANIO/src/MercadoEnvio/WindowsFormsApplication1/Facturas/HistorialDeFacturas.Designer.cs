namespace MercadoEnvios.Facturas
{
    partial class HistorialDeFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSgte = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.destinatarioTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.usuarioLbl = new System.Windows.Forms.Label();
            this.hastaPrecioTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desdePrecioTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.fechaDesdeDtp = new System.Windows.Forms.DateTimePicker();
            this.fechaHastaDtp = new System.Windows.Forms.DateTimePicker();
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(831, 553);
            this.btnSgte.Margin = new System.Windows.Forms.Padding(4);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(55, 41);
            this.btnSgte.TabIndex = 3;
            this.btnSgte.Text = ">>>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(29, 553);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(55, 41);
            this.btnAnt.TabIndex = 0;
            this.btnAnt.Text = "<<<";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // dgvFacturas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.Location = new System.Drawing.Point(29, 239);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturas.Name = "dgvFacturas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.Size = new System.Drawing.Size(857, 306);
            this.dgvFacturas.TabIndex = 70;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(786, 647);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 110;
            this.label9.Text = "Usuario:";
            // 
            // destinatarioTxt
            // 
            this.destinatarioTxt.Location = new System.Drawing.Point(521, 160);
            this.destinatarioTxt.Margin = new System.Windows.Forms.Padding(4);
            this.destinatarioTxt.MaxLength = 15;
            this.destinatarioTxt.Name = "destinatarioTxt";
            this.destinatarioTxt.ReadOnly = true;
            this.destinatarioTxt.Size = new System.Drawing.Size(112, 22);
            this.destinatarioTxt.TabIndex = 9;
            this.destinatarioTxt.TextChanged += new System.EventHandler(this.destinatarioTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(475, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "Destinatario Factura:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(135, 169);
            this.descripcionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTxt.MaxLength = 200;
            this.descripcionTxt.Multiline = true;
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.ReadOnly = true;
            this.descripcionTxt.Size = new System.Drawing.Size(171, 50);
            this.descripcionTxt.TabIndex = 8;
            this.descripcionTxt.TextChanged += new System.EventHandler(this.descripcionTxt_TextChanged);
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.AutoSize = true;
            this.usuarioLbl.Location = new System.Drawing.Point(39, 169);
            this.usuarioLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(86, 17);
            this.usuarioLbl.TabIndex = 102;
            this.usuarioLbl.Text = "Descripcion:";
            // 
            // hastaPrecioTxt
            // 
            this.hastaPrecioTxt.Location = new System.Drawing.Point(695, 86);
            this.hastaPrecioTxt.Margin = new System.Windows.Forms.Padding(4);
            this.hastaPrecioTxt.MaxLength = 10;
            this.hastaPrecioTxt.Name = "hastaPrecioTxt";
            this.hastaPrecioTxt.ReadOnly = true;
            this.hastaPrecioTxt.Size = new System.Drawing.Size(112, 22);
            this.hastaPrecioTxt.TabIndex = 7;
            this.hastaPrecioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hastaPrecioTxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 98;
            this.label5.Text = "Desde:";
            // 
            // desdePrecioTxt
            // 
            this.desdePrecioTxt.Location = new System.Drawing.Point(515, 87);
            this.desdePrecioTxt.Margin = new System.Windows.Forms.Padding(4);
            this.desdePrecioTxt.MaxLength = 10;
            this.desdePrecioTxt.Name = "desdePrecioTxt";
            this.desdePrecioTxt.ReadOnly = true;
            this.desdePrecioTxt.Size = new System.Drawing.Size(112, 22);
            this.desdePrecioTxt.TabIndex = 6;
            this.desdePrecioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desdePrecioTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Desde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 17);
            this.label10.TabIndex = 91;
            this.label10.Text = "Seleccione opciones de busqueda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(39, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 101;
            this.label7.Text = "      Detalle Factura:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "      Rango Fechas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(452, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "      Rango Precios:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(816, 86);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(33, 26);
            this.btnFiltrar.TabIndex = 111;
            this.btnFiltrar.Text = ">";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 60);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 112;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(456, 60);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 113;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(456, 137);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 114;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(43, 137);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 115;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // fechaDesdeDtp
            // 
            this.fechaDesdeDtp.Enabled = false;
            this.fechaDesdeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesdeDtp.Location = new System.Drawing.Point(101, 84);
            this.fechaDesdeDtp.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDesdeDtp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fechaDesdeDtp.Name = "fechaDesdeDtp";
            this.fechaDesdeDtp.Size = new System.Drawing.Size(112, 22);
            this.fechaDesdeDtp.TabIndex = 4;
            this.fechaDesdeDtp.ValueChanged += new System.EventHandler(this.fechaDesdeDtp_ValueChanged);
            // 
            // fechaHastaDtp
            // 
            this.fechaHastaDtp.Enabled = false;
            this.fechaHastaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHastaDtp.Location = new System.Drawing.Point(295, 84);
            this.fechaHastaDtp.Margin = new System.Windows.Forms.Padding(4);
            this.fechaHastaDtp.Name = "fechaHastaDtp";
            this.fechaHastaDtp.Size = new System.Drawing.Size(112, 22);
            this.fechaHastaDtp.TabIndex = 5;
            this.fechaHastaDtp.ValueChanged += new System.EventHandler(this.fechaHastaDtp_ValueChanged);
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.Location = new System.Drawing.Point(94, 553);
            this.btnPrimeraPag.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Size = new System.Drawing.Size(163, 41);
            this.btnPrimeraPag.TabIndex = 1;
            this.btnPrimeraPag.Text = "<<<   Primera página";
            this.btnPrimeraPag.UseVisualStyleBackColor = true;
            this.btnPrimeraPag.Click += new System.EventHandler(this.btnPrimeraPag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Última página   >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistorialDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrimeraPag);
            this.Controls.Add(this.fechaHastaDtp);
            this.Controls.Add(this.fechaDesdeDtp);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.destinatarioTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descripcionTxt);
            this.Controls.Add(this.usuarioLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hastaPrecioTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.desdePrecioTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.dgvFacturas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HistorialDeFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.HistorialDeFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSgte;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox destinatarioTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.Label usuarioLbl;
        private System.Windows.Forms.TextBox hastaPrecioTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desdePrecioTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DateTimePicker fechaDesdeDtp;
        private System.Windows.Forms.DateTimePicker fechaHastaDtp;
        private System.Windows.Forms.Button btnPrimeraPag;
        private System.Windows.Forms.Button button1;
    }
}