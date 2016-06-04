using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MercadoEnvios.ABM_Rol
{
    public partial class frmModificarRoles : Form
    {
        Conexion conn;
        int idRol;
        public frmModificarRoles(int idRolModificar, string nombreRolModificar)
        {
            InitializeComponent();
            this.conn = Conexion.Instance;
            idRol = idRolModificar;
            dgvFuncionalidadesActuales.ColumnCount = 2;
            dgvFuncionalidadesActuales.ColumnHeadersVisible = true;
            dgvFuncionalidadesActuales.Columns[0].Name = "Funcionalidad";
            dgvFuncionalidadesActuales.Columns[1].Name = "ID";
            dgvFuncionalidadesActuales.Columns[1].Visible = false;

            dgvFuncionalidadesDisponibles.ColumnCount = 2;
            dgvFuncionalidadesDisponibles.ColumnHeadersVisible = true;
            dgvFuncionalidadesDisponibles.Columns[0].Name = "Funcionalidad";
            dgvFuncionalidadesDisponibles.Columns[1].Name = "ID";
            dgvFuncionalidadesDisponibles.Columns[1].Visible = false;

            dgvFuncionalidadesDisponibles.Columns[0].Width = 350;
            dgvFuncionalidadesActuales.Columns[0].Width = 350;

            String funcionalidadesDisponibles = "SELECT F.Descripcion, F.id FROM ADIOS_TERCER_ANIO.Funcionalidad F "
                                                + "where F.id not in (Select FR.idFuncionalidad from ADIOS_TERCER_ANIO.FuncionalidadRol FR where FR.idRol = @idRol)";
            conn = Conexion.Instance;
            SqlCommand buscarFuncionalidadesDisponibles = new SqlCommand(funcionalidadesDisponibles, conn.getConexion);
            SqlParameter idRolDisponible = new SqlParameter("@idRol", SqlDbType.Int);
            idRolDisponible.Direction = ParameterDirection.Input;
            idRolDisponible.SqlValue = idRolModificar;
            buscarFuncionalidadesDisponibles.Parameters.Add(idRolDisponible);
            SqlDataReader dabuscarFuncionalidadesDisponibles = buscarFuncionalidadesDisponibles.ExecuteReader();

            if (dabuscarFuncionalidadesDisponibles.HasRows)
            {
                while (dabuscarFuncionalidadesDisponibles.Read())
                {
                    DataGridViewRow rowdgvFuncionalidadesDisponibles = (DataGridViewRow)dgvFuncionalidadesDisponibles.Rows[0].Clone();
                    rowdgvFuncionalidadesDisponibles.Cells[0].Value = dabuscarFuncionalidadesDisponibles.GetString(0).ToString();
                    rowdgvFuncionalidadesDisponibles.Cells[1].Value = dabuscarFuncionalidadesDisponibles.GetInt32(1);
                    dgvFuncionalidadesDisponibles.Rows.Add(rowdgvFuncionalidadesDisponibles);
                }
            }
            dabuscarFuncionalidadesDisponibles.Close();

            String funcionalidadesActuales = "SELECT F.Descripcion, F.id FROM ADIOS_TERCER_ANIO.Funcionalidad F "
                                                + "where F.id in (Select FR.idFuncionalidad from ADIOS_TERCER_ANIO.FuncionalidadRol FR where FR.idRol = @idRol)";
            SqlCommand buscarFuncionalidadesActuales = new SqlCommand(funcionalidadesActuales, conn.getConexion);
            SqlParameter idRolActual = new SqlParameter("@idRol", SqlDbType.Int);
            idRolActual.Direction = ParameterDirection.Input;
            idRolActual.SqlValue = idRolModificar;
            buscarFuncionalidadesActuales.Parameters.Add(idRolActual);
            SqlDataReader dabuscarFuncionalidadesActuales = buscarFuncionalidadesActuales.ExecuteReader();
            if (dabuscarFuncionalidadesActuales.HasRows)
            {
                while (dabuscarFuncionalidadesActuales.Read())
                {
                    DataGridViewRow rowdgvFuncionalidadesActuales = (DataGridViewRow)dgvFuncionalidadesActuales.Rows[0].Clone();
                    rowdgvFuncionalidadesActuales.Cells[0].Value = dabuscarFuncionalidadesActuales.GetString(0).ToString();
                    rowdgvFuncionalidadesActuales.Cells[1].Value = dabuscarFuncionalidadesActuales.GetInt32(1);
                    dgvFuncionalidadesActuales.Rows.Add(rowdgvFuncionalidadesActuales);
                }
            }
            dabuscarFuncionalidadesActuales.Close();

            dgvFuncionalidadesDisponibles.AllowUserToAddRows = false;
            dgvFuncionalidadesDisponibles.AllowUserToDeleteRows = false;
            dgvFuncionalidadesActuales.AllowUserToAddRows = false;
            dgvFuncionalidadesActuales.AllowUserToDeleteRows = false;

            lblNombreAnterior.Text = nombreRolModificar;
            lblNombreAnterior.Enabled = false;

        }

        private void salir()
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidadesDisponibles.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Funcionalidad"].Value,
                                          rowPrincipal.Cells["ID"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)dgvFuncionalidadesDisponibles.Rows[0].Clone();
                row.Cells[0].Value = values[0];
                row.Cells[1].Value = values[1];
                dgvFuncionalidadesActuales.Rows.Add(row);
                dgvFuncionalidadesDisponibles.Rows.Remove(rowPrincipal);

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidadesActuales.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Funcionalidad"].Value,
                                          rowPrincipal.Cells["ID"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)dgvFuncionalidadesActuales.Rows[0].Clone();
                row.Cells[0].Value = values[0];
                row.Cells[1].Value = values[1];
                dgvFuncionalidadesDisponibles.Rows.Add(row);
                dgvFuncionalidadesActuales.Rows.Remove(rowPrincipal);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }

        private void frmModificarRoles_Load(object sender, EventArgs e)
        {

        }

        private void btnModficar_Click(object sender, EventArgs e)
        {
            SqlCommand updateRol = new SqlCommand("ADIOS_TERCER_ANIO.ModificarRol", conn.getConexion);
            updateRol.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter nuevoNombreRol = new SqlParameter("@nombre", txtNombre.Text);
            nuevoNombreRol.Direction = ParameterDirection.Input;
            nuevoNombreRol.SqlDbType = SqlDbType.NVarChar;

            SqlParameter idRolModificar = new SqlParameter("@id", this.idRol);
            idRolModificar.Direction = ParameterDirection.Input;
            idRolModificar.SqlDbType = SqlDbType.Int;

            updateRol.Parameters.Add(nuevoNombreRol);
            updateRol.Parameters.Add(idRolModificar);
            try
            {
                updateRol.ExecuteNonQuery();
                this.salir();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
