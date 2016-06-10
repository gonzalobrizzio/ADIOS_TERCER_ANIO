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
            this.label3.Location = new System.Drawing.Point(25, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirme contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña nueva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraeña actual";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(153, 273);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(108, 33);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // contraseñaNueva
            // 
            this.contraseñaNueva.Location = new System.Drawing.Point(153, 120);
            this.contraseñaNueva.Name = "contraseñaNueva";
            this.contraseñaNueva.PasswordChar = '•';
            this.contraseñaNueva.Size = new System.Drawing.Size(160, 20);
            this.contraseñaNueva.TabIndex = 10;
            // 
            // contraseñaConfirmada
            // 
            this.contraseñaConfirmada.Location = new System.Drawing.Point(153, 178);
            this.contraseñaConfirmada.Name = "contraseñaConfirmada";
            this.contraseñaConfirmada.PasswordChar = '•';
            this.contraseñaConfirmada.Size = new System.Drawing.Size(160, 20);
            this.contraseñaConfirmada.TabIndex = 9;
            // 
            // contraseñaActual
            // 
            this.contraseñaActual.Location = new System.Drawing.Point(153, 66);
            this.contraseñaActual.Name = "contraseñaActual";
            this.contraseñaActual.PasswordChar = '•';
            this.contraseñaActual.Size = new System.Drawing.Size(160, 20);
            this.contraseñaActual.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 33);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 335);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.contraseñaNueva);
            this.Controls.Add(this.contraseñaConfirmada);
            this.Controls.Add(this.contraseñaActual);
            this.Name = "frmCambiarContraseña";
            this.Text = "Cambiar Contraseña";
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