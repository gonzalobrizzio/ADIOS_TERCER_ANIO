namespace WindowsFormsApplication1.Calificar
{
    partial class frmCalificacion
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
            this.tkbCalificacion = new System.Windows.Forms.TrackBar();
            this.lblCalificar = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.lblEstrellas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbCalificacion
            // 
            this.tkbCalificacion.Location = new System.Drawing.Point(23, 81);
            this.tkbCalificacion.Maximum = 5;
            this.tkbCalificacion.Minimum = 1;
            this.tkbCalificacion.Name = "tkbCalificacion";
            this.tkbCalificacion.Size = new System.Drawing.Size(187, 45);
            this.tkbCalificacion.TabIndex = 0;
            this.tkbCalificacion.Value = 1;
            this.tkbCalificacion.Scroll += new System.EventHandler(this.tkbCalificacion_Scroll);
            // 
            // lblCalificar
            // 
            this.lblCalificar.AutoSize = true;
            this.lblCalificar.Location = new System.Drawing.Point(20, 21);
            this.lblCalificar.Name = "lblCalificar";
            this.lblCalificar.Size = new System.Drawing.Size(95, 13);
            this.lblCalificar.TabIndex = 1;
            this.lblCalificar.Text = "Calificar al usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(37, 47);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 2;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(40, 149);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(152, 34);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Location = new System.Drawing.Point(156, 47);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(0, 13);
            this.lblEstrellas.TabIndex = 4;
            // 
            // frmCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 220);
            this.Controls.Add(this.lblEstrellas);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCalificar);
            this.Controls.Add(this.tkbCalificacion);
            this.Name = "frmCalificacion";
            this.Text = "Calificar un usuario";
            ((System.ComponentModel.ISupportInitialize)(this.tkbCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbCalificacion;
        private System.Windows.Forms.Label lblCalificar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label lblEstrellas;
    }
}