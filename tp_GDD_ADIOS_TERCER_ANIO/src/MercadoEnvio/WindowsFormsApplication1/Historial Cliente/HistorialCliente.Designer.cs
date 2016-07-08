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
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.txtPagina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDeCompras
            // 
            this.grillaDeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeCompras.Location = new System.Drawing.Point(60, 45);
            this.grillaDeCompras.Margin = new System.Windows.Forms.Padding(4);
            this.grillaDeCompras.Name = "grillaDeCompras";
            this.grillaDeCompras.Size = new System.Drawing.Size(917, 320);
            this.grillaDeCompras.TabIndex = 0;
            this.grillaDeCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(828, 436);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(149, 31);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(922, 375);
            this.btnSgte.Margin = new System.Windows.Forms.Padding(4);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(55, 41);
            this.btnSgte.TabIndex = 2;
            this.btnSgte.Text = ">>>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(60, 376);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(55, 41);
            this.btnAnt.TabIndex = 1;
            this.btnAnt.Text = "<<<";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnHistorialCalif
            // 
            this.btnHistorialCalif.Location = new System.Drawing.Point(446, 381);
            this.btnHistorialCalif.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorialCalif.Name = "btnHistorialCalif";
            this.btnHistorialCalif.Size = new System.Drawing.Size(149, 31);
            this.btnHistorialCalif.TabIndex = 3;
            this.btnHistorialCalif.Text = "Calificaciones dadas";
            this.btnHistorialCalif.UseVisualStyleBackColor = true;
            this.btnHistorialCalif.Click += new System.EventHandler(this.btnHistorialCalif_Click);
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.Location = new System.Drawing.Point(124, 373);
            this.btnPrimeraPag.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Size = new System.Drawing.Size(184, 46);
            this.btnPrimeraPag.TabIndex = 5;
            this.btnPrimeraPag.Text = "<<<   Primera página";
            this.btnPrimeraPag.UseVisualStyleBackColor = true;
            this.btnPrimeraPag.Click += new System.EventHandler(this.btnPrimeraPag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Última página   >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(480, 416);
            this.lblPagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(79, 25);
            this.lblPagina.TabIndex = 17;
            this.lblPagina.Text = "Página:";
            // 
            // txtPagina
            // 
            this.txtPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagina.Location = new System.Drawing.Point(484, 445);
            this.txtPagina.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagina.MaxLength = 10;
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(75, 30);
            this.txtPagina.TabIndex = 16;
            this.txtPagina.Text = "0";
            this.txtPagina.TextChanged += new System.EventHandler(this.txtPagina_TextChanged);
            this.txtPagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagina_KeyPress);
            // 
            // frmHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 486);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrimeraPag);
            this.Controls.Add(this.btnHistorialCalif);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grillaDeCompras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Cliente";
            this.Load += new System.EventHandler(this.frmHistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDeCompras;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSgte;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnHistorialCalif;
        private System.Windows.Forms.Button btnPrimeraPag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.TextBox txtPagina;
    }
}