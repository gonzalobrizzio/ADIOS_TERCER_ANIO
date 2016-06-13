namespace MercadoEnvios.ABM_Rol
{
    partial class frmModificarRoles
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
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvFuncionalidadesDisponibles = new System.Windows.Forms.DataGridView();
            this.NombreDeFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFuncionalidadesActuales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreAnterior = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFuncionalidadesTotales = new System.Windows.Forms.Label();
            this.lblFuncionalidadesActuales = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(14, 10);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(131, 13);
            this.lblNuevoNombre.TabIndex = 0;
            this.lblNuevoNombre.Text = "Ingrese un nuevo nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // dgvFuncionalidadesDisponibles
            // 
            this.dgvFuncionalidadesDisponibles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFuncionalidadesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidadesDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDeFuncionalidad});
            this.dgvFuncionalidadesDisponibles.Location = new System.Drawing.Point(20, 50);
            this.dgvFuncionalidadesDisponibles.Name = "dgvFuncionalidadesDisponibles";
            this.dgvFuncionalidadesDisponibles.ReadOnly = true;
            this.dgvFuncionalidadesDisponibles.Size = new System.Drawing.Size(355, 395);
            this.dgvFuncionalidadesDisponibles.TabIndex = 2;
            // 
            // NombreDeFuncionalidad
            // 
            this.NombreDeFuncionalidad.HeaderText = "Funcionalidad";
            this.NombreDeFuncionalidad.Name = "NombreDeFuncionalidad";
            this.NombreDeFuncionalidad.ReadOnly = true;
            // 
            // dgvFuncionalidadesActuales
            // 
            this.dgvFuncionalidadesActuales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFuncionalidadesActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidadesActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvFuncionalidadesActuales.Location = new System.Drawing.Point(460, 50);
            this.dgvFuncionalidadesActuales.Name = "dgvFuncionalidadesActuales";
            this.dgvFuncionalidadesActuales.ReadOnly = true;
            this.dgvFuncionalidadesActuales.Size = new System.Drawing.Size(366, 395);
            this.dgvFuncionalidadesActuales.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Funcionalidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblNombreAnterior
            // 
            this.lblNombreAnterior.AutoSize = true;
            this.lblNombreAnterior.Enabled = false;
            this.lblNombreAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreAnterior.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNombreAnterior.Location = new System.Drawing.Point(354, 10);
            this.lblNombreAnterior.Name = "lblNombreAnterior";
            this.lblNombreAnterior.Size = new System.Drawing.Size(117, 18);
            this.lblNombreAnterior.TabIndex = 4;
            this.lblNombreAnterior.Text = "Nombre Anterior";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(381, 166);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(73, 23);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar funcionalidad";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 75);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFuncionalidadesTotales
            // 
            this.lblFuncionalidadesTotales.AutoSize = true;
            this.lblFuncionalidadesTotales.Location = new System.Drawing.Point(17, 34);
            this.lblFuncionalidadesTotales.Name = "lblFuncionalidadesTotales";
            this.lblFuncionalidadesTotales.Size = new System.Drawing.Size(136, 13);
            this.lblFuncionalidadesTotales.TabIndex = 8;
            this.lblFuncionalidadesTotales.Text = "Listado de Funcionalidades";
            // 
            // lblFuncionalidadesActuales
            // 
            this.lblFuncionalidadesActuales.AutoSize = true;
            this.lblFuncionalidadesActuales.Location = new System.Drawing.Point(520, 34);
            this.lblFuncionalidadesActuales.Name = "lblFuncionalidadesActuales";
            this.lblFuncionalidadesActuales.Size = new System.Drawing.Size(128, 13);
            this.lblFuncionalidadesActuales.TabIndex = 9;
            this.lblFuncionalidadesActuales.Text = "Funcionalidades Actuales";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(609, 451);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(192, 36);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModficar
            // 
            this.btnModficar.Location = new System.Drawing.Point(78, 451);
            this.btnModficar.Name = "btnModficar";
            this.btnModficar.Size = new System.Drawing.Size(192, 36);
            this.btnModficar.TabIndex = 12;
            this.btnModficar.Text = "Modificar";
            this.btnModficar.UseVisualStyleBackColor = true;
            this.btnModficar.Click += new System.EventHandler(this.btnModficar_Click);
            // 
            // frmModificarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 489);
            this.Controls.Add(this.btnModficar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFuncionalidadesActuales);
            this.Controls.Add(this.lblFuncionalidadesTotales);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblNombreAnterior);
            this.Controls.Add(this.dgvFuncionalidadesActuales);
            this.Controls.Add(this.dgvFuncionalidadesDisponibles);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNuevoNombre);
            this.Name = "frmModificarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Roles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModificarRoles_FormClosed_1);
            this.Load += new System.EventHandler(this.frmModificarRoles_Load);
            this.Shown += new System.EventHandler(this.frmModificarRoles_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvFuncionalidadesDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeFuncionalidad;
        private System.Windows.Forms.DataGridView dgvFuncionalidadesActuales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblNombreAnterior;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFuncionalidadesTotales;
        private System.Windows.Forms.Label lblFuncionalidadesActuales;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModficar;
    }
}