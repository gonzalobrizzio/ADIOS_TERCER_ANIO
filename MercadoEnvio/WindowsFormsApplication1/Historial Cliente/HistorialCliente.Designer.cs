namespace MercadoEnvios.Historial_Cliente
{
    partial class frmHistorialCliente
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
            this.grillaDeCompras = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSgte = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnHistorialCalif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDeCompras
            // 
            this.grillaDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeCompras.Location = new System.Drawing.Point(88, 53);
            this.grillaDeCompras.Margin = new System.Windows.Forms.Padding(4);
            this.grillaDeCompras.Name = "grillaDeCompras";
            this.grillaDeCompras.Size = new System.Drawing.Size(917, 320);
            this.grillaDeCompras.TabIndex = 0;
            this.grillaDeCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(856, 401);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(149, 31);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(1020, 196);
            this.btnSgte.Margin = new System.Windows.Forms.Padding(4);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(55, 41);
            this.btnSgte.TabIndex = 8;
            this.btnSgte.Text = ">>>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(16, 196);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(55, 41);
            this.btnAnt.TabIndex = 9;
            this.btnAnt.Text = "<<<";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnHistorialCalif
            // 
            this.btnHistorialCalif.Location = new System.Drawing.Point(88, 401);
            this.btnHistorialCalif.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorialCalif.Name = "btnHistorialCalif";
            this.btnHistorialCalif.Size = new System.Drawing.Size(149, 31);
            this.btnHistorialCalif.TabIndex = 10;
            this.btnHistorialCalif.Text = "Calificaciones dadas";
            this.btnHistorialCalif.UseVisualStyleBackColor = true;
            this.btnHistorialCalif.Click += new System.EventHandler(this.btnHistorialCalif_Click);
            // 
            // frmHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 452);
            this.Controls.Add(this.btnHistorialCalif);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grillaDeCompras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHistorialCliente_FormClosed);
            this.Load += new System.EventHandler(this.frmHistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDeCompras;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSgte;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnHistorialCalif;
    }
}