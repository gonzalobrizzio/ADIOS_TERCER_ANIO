namespace MercadoEnvios.Listado_Estadistico
{
    partial class frmListadoDeMayorFacturado
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
            this.listado = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.SuspendLayout();
            // 
            // listado
            // 
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Location = new System.Drawing.Point(20, 27);
            this.listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(736, 193);
            this.listado.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(635, 244);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 39);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListadoDeMayorFacturado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 302);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoDeMayorFacturado";
            this.Text = "ListadoDeMayorFacturado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListadoDeMayorFacturado_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.Button btnVolver;
    }
}