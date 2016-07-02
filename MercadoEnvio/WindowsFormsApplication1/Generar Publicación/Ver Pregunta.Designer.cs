namespace MercadoEnvios.Generar_Publicación
{
    partial class frmVerPregunta
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.RichTextBox();
            this.btnContestar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(45, 40);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "label1";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(48, 159);
            this.txtRespuesta.MaxLength = 255;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(451, 155);
            this.txtRespuesta.TabIndex = 1;
            this.txtRespuesta.Text = "";
            // 
            // btnContestar
            // 
            this.btnContestar.Location = new System.Drawing.Point(281, 375);
            this.btnContestar.Name = "btnContestar";
            this.btnContestar.Size = new System.Drawing.Size(111, 35);
            this.btnContestar.TabIndex = 2;
            this.btnContestar.Text = "Contestar";
            this.btnContestar.UseVisualStyleBackColor = true;
            this.btnContestar.Click += new System.EventHandler(this.btnContestar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(398, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 34);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVerPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 433);
            this.Controls.Add(this.btnContestar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblPregunta);
            this.Name = "frmVerPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta";
            this.Load += new System.EventHandler(this.Ver_Pregunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RichTextBox txtRespuesta;
        private System.Windows.Forms.Button btnContestar;
        private System.Windows.Forms.Button btnVolver;
    }
}