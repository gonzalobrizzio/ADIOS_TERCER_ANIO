﻿namespace MercadoEnvios.Generar_Publicación
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
            this.lblPregunta.Location = new System.Drawing.Point(60, 49);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(46, 17);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "label1";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(64, 196);
            this.txtRespuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRespuesta.MaxLength = 255;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(600, 190);
            this.txtRespuesta.TabIndex = 3;
            this.txtRespuesta.Text = "";
            // 
            // btnContestar
            // 
            this.btnContestar.Location = new System.Drawing.Point(375, 462);
            this.btnContestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContestar.Name = "btnContestar";
            this.btnContestar.Size = new System.Drawing.Size(148, 43);
            this.btnContestar.TabIndex = 15;
            this.btnContestar.Text = "Contestar";
            this.btnContestar.UseVisualStyleBackColor = true;
            this.btnContestar.Click += new System.EventHandler(this.btnContestar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(531, 462);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 42);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVerPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 533);
            this.Controls.Add(this.btnContestar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblPregunta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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