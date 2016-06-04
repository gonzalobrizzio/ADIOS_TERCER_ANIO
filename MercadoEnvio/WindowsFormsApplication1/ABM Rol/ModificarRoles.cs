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

        public frmModificarRoles(int idRolModificar)
        {
            InitializeComponent();
            this.conn = Conexion.Instance;

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

            if (!dabuscarFuncionalidadesDisponibles.HasRows)
            {
                while (dabuscarFuncionalidadesDisponibles.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvFuncionalidadesDisponibles.Rows[0].Clone();
                    row.Cells[0].Value = dabuscarFuncionalidadesDisponibles.GetString(0).ToString();
                    row.Cells[1].Value = dabuscarFuncionalidadesDisponibles.GetInt32(1);
                    dgvFuncionalidadesDisponibles.Rows.Add(row);
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
                    DataGridViewRow row = (DataGridViewRow)dgvFuncionalidadesActuales.Rows[0].Clone();
                    row.Cells[0].Value = dabuscarFuncionalidadesActuales.GetString(0).ToString();
                    row.Cells[1].Value = dabuscarFuncionalidadesActuales.GetInt32(1);
                    dgvFuncionalidadesActuales.Rows.Add(row);
                }
            }
            dabuscarFuncionalidadesActuales.Close();

            dgvFuncionalidadesDisponibles.AllowUserToAddRows = false;
            dgvFuncionalidadesDisponibles.AllowUserToDeleteRows = false;
            dgvFuncionalidadesActuales.AllowUserToAddRows = false;
            dgvFuncionalidadesActuales.AllowUserToDeleteRows = false;


        }

        private void salir()
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvFuncionalidadesDisponibles.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta agregar una funcionalidad con una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvFuncionalidadesActuales.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvFuncionalidadesActuales.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvFuncionalidadesDisponibles.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Funcionalidad borrada con exito!");
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           //Igual que en el agregar, hay que modificar la BD y el mismo ABM
                this.Close();
        }

        private void frmModificarRoles_Load(object sender, EventArgs e)
        {

        }

    }
}
