using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MercadoEnvios.Entidades;

namespace MercadoEnvios.ABM_Rol
{
    public partial class frmModificarRoles : Form
    {
        Conexion conn;
        int idRol;
        string nombreRol;
        Sesion sesion = Sesion.Instance;
        Utilidades fun = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();

        public frmModificarRoles(int idRolModificar, string nombreRolModificar)
        {
            InitializeComponent();
            this.conn = Conexion.Instance;
            idRol = idRolModificar;
            nombreRol = nombreRolModificar;
            this.loadGrid();
        }

        private void loadGrid()
        {
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
                                                + "where F.id not in "
                                                + "(Select FR.idFuncionalidad from ADIOS_TERCER_ANIO.FuncionalidadRol FR "
                                                + "where FR.idRol = @idRol and FR.deleted = 0)";
            conn = Conexion.Instance;
            SqlCommand buscarFuncionalidadesDisponibles = new SqlCommand(funcionalidadesDisponibles, conn.getConexion);
            SqlParameter idRolDisponible = new SqlParameter("@idRol", SqlDbType.Int);
            idRolDisponible.Direction = ParameterDirection.Input;
            idRolDisponible.SqlValue = this.idRol;
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
                                              + "where F.id in "
                                              + "(Select FR.idFuncionalidad from ADIOS_TERCER_ANIO.FuncionalidadRol FR "
                                              + "where FR.idRol = @idRol and FR.deleted = 0)";
            SqlCommand buscarFuncionalidadesActuales = new SqlCommand(funcionalidadesActuales, conn.getConexion);
            SqlParameter idRolActual = new SqlParameter("@idRol", SqlDbType.Int);
            idRolActual.Direction = ParameterDirection.Input;
            idRolActual.SqlValue = this.idRol;
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

            lblNombreAnterior.Text = nombreRol;
            lblNombreAnterior.Enabled = false;
        }

        private void salir()
        {
            sesion.anterior = this;
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

        private void btnModficar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != nombreRol)
            {
                this.fun.validarRol(txtNombre, mensajeValidacion);
            }
             this.fun.validarNoVacio(txtNombre, mensajeValidacion);
             if (mensajeValidacion.Length == 0)
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
                     lblNombreAnterior.Text = txtNombre.Text;
                     this.updateFuncionalidades();
                     this.salir();
                 }
                 catch (SqlException error)
                 {
                     MessageBox.Show(error.Message);
                 }
             }
             else
             {
                 MessageBox.Show(mensajeValidacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 mensajeValidacion = new StringBuilder();
             }
        }

        private void updateFuncionalidades()
        {
            foreach (DataGridViewRow rowActuales in dgvFuncionalidadesActuales.Rows)
            {
                object[] values = {
                                          rowActuales.Cells["Funcionalidad"].Value,
                                          rowActuales.Cells["ID"].Value
                                  };
                SqlCommand updateFuncRol = new SqlCommand("ADIOS_TERCER_ANIO.modificarFuncionalidadesRol", conn.getConexion);
                updateFuncRol.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idRolModificar = new SqlParameter("@idRol", this.idRol);
                idRolModificar.Direction = ParameterDirection.Input;
                idRolModificar.SqlDbType = SqlDbType.Int;

                SqlParameter idFuncModificar = new SqlParameter("@idFunc", values[1]);
                idFuncModificar.Direction = ParameterDirection.Input;
                idFuncModificar.SqlDbType = SqlDbType.Int;

                int borrar = 0;
                SqlParameter deleted = new SqlParameter("@borrar", borrar);
                deleted.Direction = ParameterDirection.Input;
                deleted.SqlDbType = SqlDbType.Int;

                updateFuncRol.Parameters.Add(idRolModificar);
                updateFuncRol.Parameters.Add(idFuncModificar);
                updateFuncRol.Parameters.Add(deleted);
                try
                {
                    updateFuncRol.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message + ": No se pueden agregar las funcionalidades seleccionadas");
                    this.loadGrid();
                    break;
                }
                

            }

            foreach (DataGridViewRow rowDisponibles in dgvFuncionalidadesDisponibles.Rows)
            {
                object[] values = {
                                          rowDisponibles.Cells["Funcionalidad"].Value,
                                          rowDisponibles.Cells["ID"].Value
                                  };
                SqlCommand updateFuncRol = new SqlCommand("ADIOS_TERCER_ANIO.modificarFuncionalidadesRol", conn.getConexion);
                updateFuncRol.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idRolModificar = new SqlParameter("@idRol", this.idRol);
                idRolModificar.Direction = ParameterDirection.Input;
                idRolModificar.SqlDbType = SqlDbType.Int;

                SqlParameter idFuncModificar = new SqlParameter("@idFunc", values[1]);
                idFuncModificar.Direction = ParameterDirection.Input;
                idFuncModificar.SqlDbType = SqlDbType.Int;

                int borrar = 1;
                SqlParameter deleted = new SqlParameter("@borrar", borrar);
                deleted.Direction = ParameterDirection.Input;
                deleted.SqlDbType = SqlDbType.Int;

                updateFuncRol.Parameters.Add(idRolModificar);
                updateFuncRol.Parameters.Add(idFuncModificar);
                updateFuncRol.Parameters.Add(deleted);
                try
                {
                    updateFuncRol.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message + ": No se pueden eliminar las funcionalidades seleccionadas");
                    this.loadGrid();
                    break;
                }
            }
        }

        private void dgvFuncionalidadesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFuncionalidadesDisponibles.CurrentRow.Selected = true;
        }

        private void dgvFuncionalidadesActuales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvFuncionalidadesActuales.CurrentRow.Selected = true;
        }

    }
}
