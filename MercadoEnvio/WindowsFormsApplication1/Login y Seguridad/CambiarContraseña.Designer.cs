namespace MercadoEnvios.Login_y_Seguridad
{
    partial class frmCambiarContraseña
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.contraseñaNueva = new System.Windows.Forms.TextBox();
            this.contraseñaConfirmada = new System.Windows.Forms.TextBox();
            this.contraseñaActual = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirme contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña nueva:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña actual:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(97, 210);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(144, 41);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // contraseñaNueva
            // 
            this.contraseñaNueva.Location = new System.Drawing.Point(252, 113);
            this.contraseñaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñaNueva.MaxLength = 50;
            this.contraseñaNueva.Name = "contraseñaNueva";
            this.contraseñaNueva.PasswordChar = '•';
            this.contraseñaNueva.Size = new System.Drawing.Size(212, 22);
            this.contraseñaNueva.TabIndex = 10;
            // 
            // contraseñaConfirmada
            // 
            this.contraseñaConfirmada.Location = new System.Drawing.Point(252, 145);
            this.contraseñaConfirmada.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñaConfirmada.MaxLength = 50;
            this.contraseñaConfirmada.Name = "contraseñaConfirmada";
            this.contraseñaConfirmada.PasswordChar = '•';
            this.contraseñaConfirmada.Size = new System.Drawing.Size(212, 22);
            this.contraseñaConfirmada.TabIndex = 9;
            // 
            // contraseñaActual
            // 
            this.contraseñaActual.Location = new System.Drawing.Point(252, 81);
            this.contraseñaActual.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñaActual.MaxLength = 50;
            this.contraseñaActual.Name = "contraseñaActual";
            this.contraseñaActual.PasswordChar = '•';
            this.contraseñaActual.Size = new System.Drawing.Size(212, 22);
            this.contraseñaActual.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 210);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 287);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.contraseñaNueva);
            this.Controls.Add(this.contraseñaConfirmada);
            this.Controls.Add(this.contraseñaActual);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCambiarContraseña_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox contraseñaNueva;
        private System.Windows.Forms.TextBox contraseñaConfirmada;
        private System.Windows.Forms.TextBox contraseñaActual;
        private System.Windows.Forms.Button btnCancelar;
    }
}