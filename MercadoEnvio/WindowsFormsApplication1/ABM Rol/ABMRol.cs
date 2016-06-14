using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MercadoEnvios.ABM_Usuario;

namespace MercadoEnvios.ABM_Rol
{
    public partial class frmABMRol : Form
    {
        Conexion conn;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmABMRol()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getData();
        }

        private void getData(){
            String queryHabilitados = "SELECT id,nombre, iif(deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado FROM ADIOS_TERCER_ANIO.Rol";
            conn = Conexion.Instance;
            da = new SqlDataAdapter(queryHabilitados, conn.getConexion);
            DataTable tablaDeRoles = new DataTable("Roles");
            da.Fill(tablaDeRoles);
            dgvRoles.DataSource = tablaDeRoles;
            dgvRoles.Columns[0].Visible = false;
            dgvRoles.Columns[1].Width = 300;
            dgvRoles.Columns[2].Width = 300;
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Rol.frmAgregarRol().Show();
            this.Hide();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

            if (dgvRoles.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Rol SET deleted = 1 WHERE @idRol = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idRol = new SqlParameter("@idRol", SqlDbType.Int);
                idRol.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idRol);
                foreach(DataGridViewRow rows in dgvRoles.SelectedRows){
                    idRol.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }
                this.getData();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Rol SET deleted = 0 WHERE @idRol = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idRol = new SqlParameter("@idRol", SqlDbType.Int);
                idRol.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idRol);
                foreach (DataGridViewRow row in dgvRoles.SelectedRows)
                {
                    idRol.SqlValue = Convert.ToInt32(row.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }
                this.getData();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvRoles.SelectedRows == null || dgvRoles.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe elegir un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                sesion.anterior = this;
                new ABM_Rol.frmModificarRoles(Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value), Convert.ToString(dgvRoles.CurrentRow.Cells[1].Value)).Show();
                this.Hide();
            }
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            sesion.anterior.Show();
            this.Close();
        }

        private void btnFuncRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            if(dgvRoles.SelectedRows.Count == 1){
                DataGridViewRow rowPrincipal =  dgvRoles.SelectedRows[0];
                sesion.anterior = this;
                new ABM_Rol.frmVerFuncRol(Convert.ToInt32(rowPrincipal.Cells[0].Value), Convert.ToString(rowPrincipal.Cells[1].Value)).Show();
                this.Hide();
            }
            else{
                MessageBox.Show("Debe seleccionar un rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmABMRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            sesion.anterior.Show();
        }

        private void frmABMRol_Shown(object sender, EventArgs e)
        {
            sesion.anterior = anterior;
        }

    }
}
