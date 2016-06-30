namespace MercadoEnvios.ComprarOfertar
{
    partial class frmComprarOfertar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPublicaciones = new System.Windows.Forms.DataGridView();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnSgte = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.dgvRubros = new System.Windows.Forms.DataGridView();
            this.dgvFiltros = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublicaciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPublicaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPublicaciones.Location = new System.Drawing.Point(252, 46);
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublicaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPublicaciones.Size = new System.Drawing.Size(646, 284);
            this.dgvPublicaciones.TabIndex = 0;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(12, 9);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(162, 20);
            this.lblListado.TabIndex = 1;
            this.lblListado.Text = "Listado de productos:";
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(252, 336);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(41, 33);
            this.btnAnt.TabIndex = 2;
            this.btnAnt.Text = "<<<";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(860, 336);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(41, 33);
            this.btnSgte.TabIndex = 3;
            this.btnSgte.Text = ">>>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(684, 336);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 33);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(298, 336);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(194, 33);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Ver publicación en detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dgvRubros
            // 
            this.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubros.Location = new System.Drawing.Point(13, 46);
            this.dgvRubros.Name = "dgvRubros";
            this.dgvRubros.Size = new System.Drawing.Size(221, 156);
            this.dgvRubros.TabIndex = 6;
            this.dgvRubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubros_CellClick);
            // 
            // dgvFiltros
            // 
            this.dgvFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltros.Location = new System.Drawing.Point(13, 237);
            this.dgvFiltros.Name = "dgvFiltros";
            this.dgvFiltros.Size = new System.Drawing.Size(221, 132);
            this.dgvFiltros.TabIndex = 7;
            this.dgvFiltros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltros_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Activar filtro ↓";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(123, 209);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(111, 23);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Desactivar filtro ↑";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(252, 13);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(174, 20);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar por descripción:";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.Location = new System.Drawing.Point(448, 12);
            this.txtDescripción.MaxLength = 255;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(247, 23);
            this.txtDescripción.TabIndex = 11;
            // 
            // frmComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(912, 381);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvFiltros);
            this.Controls.Add(this.dgvRubros);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSgte);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvPublicaciones);
            this.Name = "frmComprarOfertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.frmComprarOfertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublicaciones;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnSgte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.DataGridView dgvRubros;
        private System.Windows.Forms.DataGridView dgvFiltros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtDescripción;

    }
}