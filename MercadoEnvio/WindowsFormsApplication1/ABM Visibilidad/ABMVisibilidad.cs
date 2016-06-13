using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MercadoEnvios.ABM_Usuario;

namespace MercadoEnvios.ABM_Visibilidad
{
    public partial class frmABMVisibilidad : Form
    {
        Conexion conn;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmABMVisibilidad()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getData();
        }

        private void getData()
        {
            String queryHabilitados = "SELECT id,descripcion, iif(deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado FROM ADIOS_TERCER_ANIO.Visibilidad";
            conn = Conexion.Instance;
            SqlCommand buscarRoles = new SqlCommand(queryHabilitados, conn.getConexion);
            da = new SqlDataAdapter(queryHabilitados, conn.getConexion);
            DataTable tablaDeRoles = new DataTable("Roles");
            da.Fill(tablaDeRoles);
            dgvVisibilidad.DataSource = tablaDeRoles;
            dgvVisibilidad.Columns[0].Visible = false;
            dgvVisibilidad.Columns[1].Width = 300;
            dgvVisibilidad.Columns[2].Width = 300;
            dgvVisibilidad.AllowUserToAddRows = false;
            dgvVisibilidad.AllowUserToDeleteRows = false;
            dgvVisibilidad.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Rol.frmAgregarRol().Show();
            this.Hide();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

            if (dgvVisibilidad.SelectedRows == null)
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
                foreach (DataGridViewRow rows in dgvVisibilidad.SelectedRows)
                {
                    idRol.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }
                this.getData();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvVisibilidad.SelectedRows == null)
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
                foreach (DataGridViewRow row in dgvVisibilidad.SelectedRows)
                {
                    idRol.SqlValue = Convert.ToInt32(row.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }
                this.getData();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvVisibilidad.SelectedRows == null || dgvVisibilidad.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe elegir un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                sesion.anterior = this;
                new ABM_Rol.frmModificarRoles(Convert.ToInt32(dgvVisibilidad.CurrentRow.Cells[0].Value), Convert.ToString(dgvVisibilidad.CurrentRow.Cells[1].Value)).Show();
                this.Hide();
            }
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Usuario.frmPantallaPrincipal().Show();
            this.Hide();
        }

        private void btnFuncRol_Click(object sender, EventArgs e)
        {
            if (dgvVisibilidad.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                if (dgvVisibilidad.SelectedRows.Count == 1)
                {
                    DataGridViewRow rowPrincipal = dgvVisibilidad.SelectedRows[0];
                    sesion.anterior = this;
                    new ABM_Rol.frmVerFuncRol(Convert.ToInt32(rowPrincipal.Cells[0].Value), Convert.ToString(rowPrincipal.Cells[1].Value)).Show();
                    this.Hide();
                }
                else
                {
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
