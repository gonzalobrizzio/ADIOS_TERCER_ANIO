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

        public frmABMVisibilidad()
        {
            InitializeComponent();
            this.getData();
        }

        private void getData()
        {
            String queryHabilitados = "SELECT id,nombre, iif(deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado FROM ADIOS_TERCER_ANIO.Visibilidad";
            conn = Conexion.Instance;
            da = new SqlDataAdapter(queryHabilitados, conn.getConexion);
            DataTable tablaDeVisibilidades = new DataTable("Visibilidades");
            da.Fill(tablaDeVisibilidades);
            dgvVisibilidad.DataSource = tablaDeVisibilidades;
            dgvVisibilidad.Columns[0].Visible = false;
            dgvVisibilidad.Columns[1].Width = 300;
            dgvVisibilidad.Columns[2].Width = 300;
            dgvVisibilidad.AllowUserToAddRows = false;
            dgvVisibilidad.AllowUserToDeleteRows = false;
            dgvVisibilidad.ReadOnly = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new ABM_Visibilidad.frmAgregarVisibilidad().Show();
            this.Hide();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

            if (dgvVisibilidad.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una visibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Visibilidad SET deleted = 1 WHERE @idVisibilidad = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idVisibilidad = new SqlParameter("@idVisibilidad", SqlDbType.Int);
                idVisibilidad.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idVisibilidad);
                foreach (DataGridViewRow rows in dgvVisibilidad.SelectedRows)
                {
                    idVisibilidad.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }
                this.getData();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvVisibilidad.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una visibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Visibilidad SET deleted = 0 WHERE @idVisibilidad = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idVisibilidad = new SqlParameter("@idVisibilidad", SqlDbType.Int);
                idVisibilidad.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idVisibilidad);
                foreach (DataGridViewRow row in dgvVisibilidad.SelectedRows)
                {
                    idVisibilidad.SqlValue = Convert.ToInt32(row.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }
                this.getData();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvVisibilidad.SelectedRows == null || dgvVisibilidad.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe elegir una Visibilidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //new ABM_Visibilidad.frmModificarVisibilidad(Convert.ToInt32(dgvVisibilidad.CurrentRow.Cells[0].Value), Convert.ToString(dgvVisibilidad.CurrentRow.Cells[1].Value)).Show();
                this.Hide();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ABM_Usuario.frmPantallaPrincipal().Show();
            this.Hide();
        }
    }
}
