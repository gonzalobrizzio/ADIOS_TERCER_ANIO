namespace MercadoEnvios.ABM_Rol
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
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblElegir.Location = new System.Drawing.Point(119, 32);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(144, 34);
            this.lblElegir.TabIndex = 0;
            this.lblElegir.Text = "Elija el rol que desee \r\npara esta sesión:";
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(122, 236);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(141, 32);
            this.btnElegir.TabIndex = 2;
            this.btnElegir.Text = "Seleccionar";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(122, 144);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(141, 21);
            this.cboRol.TabIndex = 3;
            // 
            // frmElegirRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 334);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.lblElegir);
            this.Name = "frmElegirRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElegirRol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmElegirRol_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.ComboBox cboRol;
    }
}