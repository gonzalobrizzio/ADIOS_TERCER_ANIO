namespace MercadoEnvios.Generar_Publicación
{
    partial class frmModificarPublicacion
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
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvPublication = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statePublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublication)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(148, 469);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(93, 35);
            this.btnActivar.TabIndex = 28;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(346, 469);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(93, 35);
            this.btnFinalizar.TabIndex = 27;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(247, 469);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(93, 35);
            this.btnPausar.TabIndex = 26;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(49, 469);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 35);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            // 
            // dgvPublication
            // 
            this.dgvPublication.AllowUserToOrderColumns = true;
            this.dgvPublication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.description,
            this.stock,
            this.price,
            this.publishedDate,
            this.expireDate,
            this.qEnabled,
            this.mode,
            this.visibility,
            this.statePublication});
            this.dgvPublication.Location = new System.Drawing.Point(49, 82);
            this.dgvPublication.Name = "dgvPublication";
            this.dgvPublication.Size = new System.Drawing.Size(1105, 368);
            this.dgvPublication.TabIndex = 24;
            // 
            // number
            // 
            this.number.HeaderText = "Numero de Publicación";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Descripcion";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 150;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // publishedDate
            // 
            this.publishedDate.HeaderText = "Día de Publicación";
            this.publishedDate.Name = "publishedDate";
            this.publishedDate.ReadOnly = true;
            // 
            // expireDate
            // 
            this.expireDate.HeaderText = "Día de Finalización";
            this.expireDate.Name = "expireDate";
            this.expireDate.ReadOnly = true;
            // 
            // qEnabled
            // 
            this.qEnabled.HeaderText = "¿Acepta Preguntas?";
            this.qEnabled.Name = "qEnabled";
            this.qEnabled.ReadOnly = true;
            // 
            // mode
            // 
            this.mode.HeaderText = "Compra Inmediata / Subasta";
            this.mode.Name = "mode";
            this.mode.ReadOnly = true;
            // 
            // visibility
            // 
            this.visibility.HeaderText = "Visibilidad";
            this.visibility.Name = "visibility";
            this.visibility.ReadOnly = true;
            // 
            // statePublication
            // 
            this.statePublication.HeaderText = "Estado de la Publicación";
            this.statePublication.Name = "statePublication";
            this.statePublication.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seleccione una publicación para modificar:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1061, 469);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 35);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            // 
            // frmModificarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 529);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvPublication);
            this.Name = "frmModificarPublicacion";
            this.Text = "Modificar Publicación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvPublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn statePublication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
    }
}