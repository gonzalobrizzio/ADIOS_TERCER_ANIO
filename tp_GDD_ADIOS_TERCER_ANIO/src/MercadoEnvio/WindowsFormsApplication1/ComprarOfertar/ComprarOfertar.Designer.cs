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
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.lblPagina = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
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
            this.dgvPublicaciones.Location = new System.Drawing.Point(336, 127);
            this.dgvPublicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPublicaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPublicaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPublicaciones.Size = new System.Drawing.Size(991, 302);
            this.dgvPublicaciones.TabIndex = 0;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(16, 7);
            this.lblListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(199, 25);
            this.lblListado.TabIndex = 1;
            this.lblListado.Text = "Listado de productos:";
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(336, 82);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(133, 37);
            this.btnAnt.TabIndex = 4;
            this.btnAnt.Text = "<< Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnSgte
            // 
            this.btnSgte.Location = new System.Drawing.Point(1193, 82);
            this.btnSgte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSgte.Name = "btnSgte";
            this.btnSgte.Size = new System.Drawing.Size(133, 37);
            this.btnSgte.TabIndex = 6;
            this.btnSgte.Text = "Siguiente >>";
            this.btnSgte.UseVisualStyleBackColor = true;
            this.btnSgte.Click += new System.EventHandler(this.btnSgte_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1100, 436);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(227, 37);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(336, 436);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(259, 37);
            this.btnDetalle.TabIndex = 7;
            this.btnDetalle.Text = "Ver publicación en detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // dgvRubros
            // 
            this.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubros.Location = new System.Drawing.Point(17, 39);
            this.dgvRubros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRubros.Name = "dgvRubros";
            this.dgvRubros.Size = new System.Drawing.Size(295, 228);
            this.dgvRubros.TabIndex = 6;
            this.dgvRubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubros_CellClick);
            // 
            // dgvFiltros
            // 
            this.dgvFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltros.Location = new System.Drawing.Point(17, 310);
            this.dgvFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFiltros.Name = "dgvFiltros";
            this.dgvFiltros.Size = new System.Drawing.Size(295, 162);
            this.dgvFiltros.TabIndex = 7;
            this.dgvFiltros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltros_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 274);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 28);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Activar filtro ↓";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(164, 274);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(148, 28);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Desactivar filtro ↑";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(331, 7);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(216, 25);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar por descripción:";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripción.Location = new System.Drawing.Point(591, 4);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripción.MaxLength = 255;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(328, 26);
            this.txtDescripción.TabIndex = 1;
            this.txtDescripción.TextChanged += new System.EventHandler(this.txtDescripción_TextChanged);
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.Location = new System.Drawing.Point(336, 39);
            this.btnPrimeraPag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Size = new System.Drawing.Size(161, 36);
            this.btnPrimeraPag.TabIndex = 2;
            this.btnPrimeraPag.Text = "<<<   Primera página";
            this.btnPrimeraPag.UseVisualStyleBackColor = true;
            this.btnPrimeraPag.Click += new System.EventHandler(this.btnPrimeraPag_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1165, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Última página   >>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPagina
            // 
            this.txtPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagina.Location = new System.Drawing.Point(741, 79);
            this.txtPagina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPagina.MaxLength = 10;
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(75, 30);
            this.txtPagina.TabIndex = 5;
            this.txtPagina.TextChanged += new System.EventHandler(this.txtPagina_TextChanged);
            this.txtPagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagina_KeyPress);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(784, 50);
            this.lblPagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(79, 25);
            this.lblPagina.TabIndex = 15;
            this.lblPagina.Text = "Página:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(825, 86);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 25);
            this.lblMax.TabIndex = 16;
            // 
            // frmComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1340, 487);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrimeraPag);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnPrimeraPag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label lblMax;

    }
}