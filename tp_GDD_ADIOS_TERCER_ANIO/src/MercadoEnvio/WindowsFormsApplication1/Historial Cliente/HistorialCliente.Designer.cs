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
            this.grillaDeCompras.Location = new System.Drawing.Point(66, 43);
            this.grillaDeCompras.Name = "grillaDeCompras";
            this.grillaDeCompras.Size = new System.Drawing.Size(688, 260);
            this.grillaDeCompras.TabIndex = 0;
            this.grillaDeCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(642, 326);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 25);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(765, 159);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(41, 33);
            this.btnSgte.TabIndex = 2;
            this.btnSgte.Text = ">>>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(12, 159);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(41, 33);
            this.btnAnt.TabIndex = 1;
            this.btnAnt.Text = "<<<";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnHistorialCalif
            // 
            this.btnHistorialCalif.Location = new System.Drawing.Point(66, 326);
            this.btnHistorialCalif.Name = "btnHistorialCalif";
            this.btnHistorialCalif.Size = new System.Drawing.Size(112, 25);
            this.btnHistorialCalif.TabIndex = 3;
            this.btnHistorialCalif.Text = "Calificaciones dadas";
            this.btnHistorialCalif.UseVisualStyleBackColor = true;
            this.btnHistorialCalif.Click += new System.EventHandler(this.btnHistorialCalif_Click);
            // 
            // frmHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 367);
            this.Controls.Add(this.btnHistorialCalif);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grillaDeCompras);
            this.Name = "frmHistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Cliente";
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