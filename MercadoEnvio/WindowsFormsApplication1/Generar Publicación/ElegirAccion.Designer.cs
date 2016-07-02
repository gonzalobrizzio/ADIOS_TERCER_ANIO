namespace MercadoEnvios.Generar_Publicación
{
    partial class frmElegirAccion
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
            this.btnModificarPublicacion = new System.Windows.Forms.Button();
            this.btnNuevaPublicacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificarPublicacion
            // 
            this.btnModificarPublicacion.Location = new System.Drawing.Point(72, 155);
            this.btnModificarPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarPublicacion.Name = "btnModificarPublicacion";
            this.btnModificarPublicacion.Size = new System.Drawing.Size(257, 59);
            this.btnModificarPublicacion.TabIndex = 2;
            this.btnModificarPublicacion.Text = "Modificar Publicación";
            this.btnModificarPublicacion.UseVisualStyleBackColor = true;
            this.btnModificarPublicacion.Click += new System.EventHandler(this.btnModificarPublicacion_Click);
            // 
            // btnNuevaPublicacion
            // 
            this.btnNuevaPublicacion.Location = new System.Drawing.Point(72, 62);
            this.btnNuevaPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaPublicacion.Name = "btnNuevaPublicacion";
            this.btnNuevaPublicacion.Size = new System.Drawing.Size(257, 59);
            this.btnNuevaPublicacion.TabIndex = 1;
            this.btnNuevaPublicacion.Text = "Nueva Publicación";
            this.btnNuevaPublicacion.UseVisualStyleBackColor = true;
            this.btnNuevaPublicacion.Click += new System.EventHandler(this.btnNuevaPublicacion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 354);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContestar
            // 
            this.btnContestar.Location = new System.Drawing.Point(72, 256);
            this.btnContestar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContestar.Name = "btnContestar";
            this.btnContestar.Size = new System.Drawing.Size(257, 59);
            this.btnContestar.TabIndex = 3;
            this.btnContestar.Text = "Contestar Preguntas";
            this.btnContestar.UseVisualStyleBackColor = true;
            this.btnContestar.Click += new System.EventHandler(this.btnContestar_Click);
            // 
            // frmElegirAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 411);
            this.Controls.Add(this.btnContestar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevaPublicacion);
            this.Controls.Add(this.btnModificarPublicacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmElegirAccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Acción";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmElegirAccion_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarPublicacion;
        private System.Windows.Forms.Button btnNuevaPublicacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContestar;
    }
}