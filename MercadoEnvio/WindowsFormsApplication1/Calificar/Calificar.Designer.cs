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
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbCalificacion
            // 
            this.tkbCalificacion.Location = new System.Drawing.Point(643, 134);
            this.tkbCalificacion.Margin = new System.Windows.Forms.Padding(4);
            this.tkbCalificacion.Maximum = 5;
            this.tkbCalificacion.Minimum = 1;
            this.tkbCalificacion.Name = "tkbCalificacion";
            this.tkbCalificacion.Size = new System.Drawing.Size(400, 56);
            this.tkbCalificacion.TabIndex = 0;
            this.tkbCalificacion.Value = 1;
            this.tkbCalificacion.Scroll += new System.EventHandler(this.tkbCalificacion_Scroll);
            // 
            // lblCalificar
            // 
            this.lblCalificar.AutoSize = true;
            this.lblCalificar.Location = new System.Drawing.Point(639, 16);
            this.lblCalificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalificar.Name = "lblCalificar";
            this.lblCalificar.Size = new System.Drawing.Size(128, 17);
            this.lblCalificar.TabIndex = 1;
            this.lblCalificar.Text = "Calificar al usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(796, 16);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblUsuario.TabIndex = 2;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(643, 272);
            this.btnCalificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(400, 57);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Location = new System.Drawing.Point(656, 97);
            this.lblEstrellas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(0, 17);
            this.lblEstrellas.TabIndex = 4;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(16, 46);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCompras.Size = new System.Drawing.Size(609, 219);
            this.dgvCompras.TabIndex = 5;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            // 
            // lblPorCompra
            // 
            this.lblPorCompra.AutoSize = true;
            this.lblPorCompra.Location = new System.Drawing.Point(639, 52);
            this.lblPorCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorCompra.Name = "lblPorCompra";
            this.lblPorCompra.Size = new System.Drawing.Size(99, 17);
            this.lblPorCompra.TabIndex = 6;
            this.lblPorCompra.Text = "por la compra:";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(796, 52);
            this.lblCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(0, 17);
            this.lblCompra.TabIndex = 7;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(643, 198);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.MaxLength = 255;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(399, 66);
            this.txtDetalle.TabIndex = 1;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Location = new System.Drawing.Point(17, 16);
            this.lblCompras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(168, 17);
            this.lblCompras.TabIndex = 9;
            this.lblCompras.Text = "Lista de últimas compras:";
            // 
            // btnReputacion
            // 
            this.btnReputacion.Location = new System.Drawing.Point(16, 272);
            this.btnReputacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnReputacion.Name = "btnReputacion";
            this.btnReputacion.Size = new System.Drawing.Size(611, 57);
            this.btnReputacion.TabIndex = 3;
            this.btnReputacion.Text = "Reputación e historial";
            this.btnReputacion.UseVisualStyleBackColor = true;
            this.btnReputacion.Click += new System.EventHandler(this.btnReputacion_Click);
            // 
            // lblIdCompra
            // 
            this.lblIdCompra.AutoSize = true;
            this.lblIdCompra.Location = new System.Drawing.Point(635, 326);
            this.lblIdCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCompra.Name = "lblIdCompra";
            this.lblIdCompra.Size = new System.Drawing.Size(0, 17);
            this.lblIdCompra.TabIndex = 10;
            this.lblIdCompra.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1004, 350);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 41);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 401);
            this.Controls.Add(this.btnCancelar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificar un usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalificacion_FormClosed);
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
        private System.Windows.Forms.Button btnCancelar;
    }
}