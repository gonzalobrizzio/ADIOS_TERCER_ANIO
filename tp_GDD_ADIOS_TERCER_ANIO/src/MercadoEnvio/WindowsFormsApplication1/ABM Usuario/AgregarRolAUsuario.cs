using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class AgregarRolAUsuario : Form
    {

        Conexion conn = Conexion.Instance;
        Sesion sesion = Sesion.Instance;
        int idUsuario;
        public AgregarRolAUsuario(int usu)
        {
            InitializeComponent();
            idUsuario = usu;

            string queryBuscarRoles = "SELECT r.nombre FROM ADIOS_TERCER_ANIO.Rol r LEFT JOIN ADIOS_TERCER_ANIO.RolUsuario rolU ON r.id = rolU.idRol AND rolU.idUsuario = " + idUsuario + " WHERE rolU.idRol is null AND r.deleted = 0";
            SqlCommand buscarRoles = new SqlCommand(queryBuscarRoles, conn.getConexion);
            SqlDataReader dataReader = buscarRoles.ExecuteReader();
            while (dataReader.Read())
            {
                cmbRolAsignado.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();
            cmbRolAsignado.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string rol = cmbRolAsignado.SelectedItem.ToString();

            SqlCommand agregarRolUsuario = new SqlCommand("ADIOS_TERCER_ANIO.AgregarRolXUsuario", conn.getConexion);
            agregarRolUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter rolU = new SqlParameter("@rol", SqlDbType.NVarChar, 255);
            rolU.SqlValue = rol;
            rolU.Direction = ParameterDirection.Input;

            SqlParameter id = new SqlParameter("@idUsuario", SqlDbType.Int);
            id.SqlValue = idUsuario;
            id.Direction = ParameterDirection.Input;
            try
            {
                agregarRolUsuario.Parameters.Add(rolU);
                agregarRolUsuario.Parameters.Add(id);
                agregarRolUsuario.ExecuteNonQuery();
            }catch(SqlException error)
            {
                MessageBox.Show("No se pudo agregar correctamente el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }
    }
}
