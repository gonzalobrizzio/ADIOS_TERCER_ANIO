namespace WindowsFormsApplication1.ABM_Rol
{
    partial class frmElegirRol
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
            this.lblElegir = new System.Windows.Forms.Label();
            this.btnElegir = new System.Windows.Forms.Button();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblElegir.Location = new System.Drawing.Point(22, 19);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(144, 34);
            this.lblElegir.TabIndex = 0;
            this.lblElegir.Text = "Elija el rol que desee \r\npara esta sesión:";
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(25, 167);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(75, 23);
            this.btnElegir.TabIndex = 2;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRol
            // 
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rol});
            this.dgvRol.Location = new System.Drawing.Point(25, 56);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvRol.Size = new System.Drawing.Size(141, 105);
            this.dgvRol.TabIndex = 3;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // frmElegirRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 199);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.lblElegir);
            this.Name = "frmElegirRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ElegirRol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmElegirRol_FormClosed);
            this.Load += new System.EventHandler(this.ElegirRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}