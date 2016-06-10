namespace MercadoEnvios.Calificar
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.lblPorCompra = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblCompras = new System.Windows.Forms.Label();
            this.btnReputacion = new System.Windows.Forms.Button();
            this.lblIdCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbCalificacion
            // 
            this.tkbCalificacion.Location = new System.Drawing.Point(482, 109);
            this.tkbCalificacion.Maximum = 5;
            this.tkbCalificacion.Minimum = 1;
            this.tkbCalificacion.Name = "tkbCalificacion";
            this.tkbCalificacion.Size = new System.Drawing.Size(300, 45);
            this.tkbCalificacion.TabIndex = 0;
            this.tkbCalificacion.Value = 1;
            this.tkbCalificacion.Scroll += new System.EventHandler(this.tkbCalificacion_Scroll);
            // 
            // lblCalificar
            // 
            this.lblCalificar.AutoSize = true;
            this.lblCalificar.Location = new System.Drawing.Point(479, 13);
            this.lblCalificar.Name = "lblCalificar";
            this.lblCalificar.Size = new System.Drawing.Size(95, 13);
            this.lblCalificar.TabIndex = 1;
            this.lblCalificar.Text = "Calificar al usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(597, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 2;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(482, 221);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(300, 46);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Location = new System.Drawing.Point(492, 79);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(0, 13);
            this.lblEstrellas.TabIndex = 4;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(12, 37);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(457, 178);
            this.dgvCompras.TabIndex = 5;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            // 
            // lblPorCompra
            // 
            this.lblPorCompra.AutoSize = true;
            this.lblPorCompra.Location = new System.Drawing.Point(479, 42);
            this.lblPorCompra.Name = "lblPorCompra";
            this.lblPorCompra.Size = new System.Drawing.Size(74, 13);
            this.lblPorCompra.TabIndex = 6;
            this.lblPorCompra.Text = "por la compra:";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(597, 42);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(0, 13);
            this.lblCompra.TabIndex = 7;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(482, 161);
            this.txtDetalle.MaxLength = 255;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(300, 54);
            this.txtDetalle.TabIndex = 8;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Location = new System.Drawing.Point(13, 13);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(125, 13);
            this.lblCompras.TabIndex = 9;
            this.lblCompras.Text = "Lista de últimas compras:";
            // 
            // btnReputacion
            // 
            this.btnReputacion.Location = new System.Drawing.Point(12, 221);
            this.btnReputacion.Name = "btnReputacion";
            this.btnReputacion.Size = new System.Drawing.Size(458, 46);
            this.btnReputacion.TabIndex = 11;
            this.btnReputacion.Text = "Reputación e historial";
            this.btnReputacion.UseVisualStyleBackColor = true;
            this.btnReputacion.Click += new System.EventHandler(this.btnReputacion_Click);
            // 
            // lblIdCompra
            // 
            this.lblIdCompra.AutoSize = true;
            this.lblIdCompra.Location = new System.Drawing.Point(476, 265);
            this.lblIdCompra.Name = "lblIdCompra";
            this.lblIdCompra.Size = new System.Drawing.Size(0, 13);
            this.lblIdCompra.TabIndex = 10;
            this.lblIdCompra.Visible = false;
            // 
            // frmCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 274);
            this.Controls.Add(this.btnReputacion);
            this.Controls.Add(this.lblIdCompra);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.lblPorCompra);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.lblEstrellas);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCalificar);
            this.Controls.Add(this.tkbCalificacion);
            this.Name = "frmCalificacion";
            this.Text = "Calificar un usuario";
            ((System.ComponentModel.ISupportInitialize)(this.tkbCalificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbCalificacion;
        private System.Windows.Forms.Label lblCalificar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label lblPorCompra;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Button btnReputacion;
        private System.Windows.Forms.Label lblIdCompra;
    }
}