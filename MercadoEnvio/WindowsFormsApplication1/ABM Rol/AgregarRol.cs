using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MercadoEnvios.ABM_Rol
{
    public partial class frmAgregarRol : Form
    {
        Conexion conn;

        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmAgregarRol()
        {
            InitializeComponent();
            anterior = sesion.anterior;

            dgvFuncionalidadesAgregadas.ColumnCount = 2;
            dgvFuncionalidadesAgregadas.ColumnHeadersVisible = true;
            dgvFuncionalidadesAgregadas.Columns[0].Name = "Funcionalidad";
            dgvFuncionalidadesAgregadas.Columns[1].Name = "ID";
            dgvFuncionalidadesAgregadas.Columns[1].Visible = false;

            dgvFuncionalidades.ColumnCount = 2;
            dgvFuncionalidades.ColumnHeadersVisible = true;
            dgvFuncionalidades.Columns[0].Name = "Funcionalidad";
            dgvFuncionalidades.Columns[1].Name = "ID";
            dgvFuncionalidades.Columns[1].Visible = false;

            dgvFuncionalidades.Columns[0].Width = 350;
            dgvFuncionalidadesAgregadas.Columns[0].Width = 350;          
            
            String query = "SELECT Descripcion, id FROM ADIOS_TERCER_ANIO.Funcionalidad";
            conn = Conexion.Instance;
            SqlCommand buscarFuncionalidades = new SqlCommand(query, conn.getConexion);
            SqlDataReader da = buscarFuncionalidades.ExecuteReader();
            
            if(!da.HasRows){
                MessageBox.Show("Error al cargar funcionalidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.salir();
            }
            while(da.Read()){
                DataGridViewRow row = (DataGridViewRow)dgvFuncionalidades.Rows[0].Clone();
                row.Cells[0].Value = da.GetString(0).ToString();
                row.Cells[1].Value = da.GetInt32(1);
                dgvFuncionalidades.Rows.Add(row);
            }
            da.Close();

            dgvFuncionalidades.AllowUserToAddRows = false;
            dgvFuncionalidades.AllowUserToDeleteRows = false;
            dgvFuncionalidadesAgregadas.AllowUserToAddRows = false;
            dgvFuncionalidadesAgregadas.AllowUserToDeleteRows = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Está intentando agregar un rol sin nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dgvFuncionalidadesAgregadas.Rows.Count==0)
                    {
                        MessageBox.Show("No ha agregado funcionalidades a el rol que desea crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 else
                    {
                        SqlCommand agregarRol = new SqlCommand("ADIOS_TERCER_ANIO.AgregarRol", conn.getConexion);
                        agregarRol.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                        nombre.SqlValue = txtNombre.Text;
                        nombre.Direction = ParameterDirection.Input;
                        SqlParameter idRol = new SqlParameter("@id", null);
                        idRol.Direction = ParameterDirection.Output;
                        idRol.SqlDbType = SqlDbType.Int;
                        agregarRol.Parameters.Add(nombre);
                        agregarRol.Parameters.Add(idRol);
                        agregarRol.ExecuteNonQuery();
                        
                        int ultimoIdRol = Convert.ToInt32(agregarRol.Parameters["@id"].Value);

                        String queryRol = "INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad)"
                                        + "VALUES (@idRol, @idFuncionalidad)";
                        SqlCommand agregarRolFuncionalidad = new SqlCommand(queryRol, conn.getConexion);
                        SqlParameter idRolDeFuncionalidad = new SqlParameter("@idRol", SqlDbType.Int);
                        idRolDeFuncionalidad.SqlValue = ultimoIdRol;
                        idRolDeFuncionalidad.Direction = ParameterDirection.Input;
                        agregarRolFuncionalidad.Parameters.Add(idRolDeFuncionalidad);
                        SqlParameter idFuncionalidad = new SqlParameter("@idFuncionalidad", SqlDbType.Int);
                        idFuncionalidad.Direction = ParameterDirection.Input;
                        agregarRolFuncionalidad.Parameters.Add(idFuncionalidad);

                        foreach (DataGridViewRow row in dgvFuncionalidadesAgregadas.Rows)
                        {
                            if (row.Cells[1].Value != null)
                            {
                                idFuncionalidad.SqlValue = row.Cells[1].Value;
                                agregarRolFuncionalidad.ExecuteNonQuery();
                            }
                        }
                        this.salir();
                    }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.salir();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidades.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Funcionalidad"].Value,
                                          rowPrincipal.Cells["ID"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)dgvFuncionalidades.Rows[0].Clone();
                row.Cells[0].Value =  values[0];
                row.Cells[1].Value = values[1];
                dgvFuncionalidadesAgregadas.Rows.Add(row);
                dgvFuncionalidades.Rows.Remove(rowPrincipal);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidadesAgregadas.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Funcionalidad"].Value,
                                          rowPrincipal.Cells["ID"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)dgvFuncionalidadesAgregadas.Rows[0].Clone();
                row.Cells[0].Value = values[0];
                row.Cells[1].Value = values[1];
                dgvFuncionalidades.Rows.Add(row);
                dgvFuncionalidadesAgregadas.Rows.Remove(rowPrincipal);

            }
        }

        public void salir()
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }
    }
}
