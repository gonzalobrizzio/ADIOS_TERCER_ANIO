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
    public partial class frmNuevoUsuario : Form
    {
        Conexion conn = Conexion.Instance;

        public frmNuevoUsuario()
        {
            InitializeComponent();

            string queryBuscarRoles = "SELECT nombre FROM ADIOS_TERCER_ANIO.Rol WHERE id != 1";
            SqlCommand buscarRoles = new SqlCommand(queryBuscarRoles, conn.getConexion);
            SqlDataReader dataReader = buscarRoles.ExecuteReader();
            while (dataReader.Read())
            {
                cmbRolAsignado.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();
        }

        private void NuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            SqlCommand agregarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.generarUsuarioConIDRol", conn.getConexion);
            agregarUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
            usuario.SqlValue = txtUsr.Text;
            usuario.Direction = ParameterDirection.Input;
            SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
            password.SqlValue = txtContrasenia.Text;
            password.Direction = ParameterDirection.Input;
            SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mail.SqlValue = txtMail.Text;
            mail.Direction = ParameterDirection.Input;
            SqlParameter idUsuario = new SqlParameter("@ultimoID", null);
            idUsuario.Direction = ParameterDirection.Output;
            idUsuario.SqlDbType = SqlDbType.Int;
            SqlParameter rol = new SqlParameter("@rol", SqlDbType.NVarChar, 255);
            rol.SqlValue = cmbRolAsignado.SelectedItem.ToString();
            rol.Direction = ParameterDirection.Input;

            agregarUsuario.Parameters.Add(usuario);
            agregarUsuario.Parameters.Add(password);
            agregarUsuario.Parameters.Add(mail);
            agregarUsuario.Parameters.Add(idUsuario);
            agregarUsuario.Parameters.Add(rol);
            agregarUsuario.ExecuteNonQuery();

            if ((cmbRolAsignado.SelectedItem).Equals("Cliente")) {
                new frmNuevoCliente().Show();
                this.Close();
            }
            

            //if (txtUsr.Text.Length == 0)
            //if (txtUsr.Text.Length < 4)
            //if (txtContrasenia.Text.Length < 6)
            //if (txtCorreo.Text.Length == 0)
            //if (!(txtCUIT.Text.Length > 0 || txtNroDoc.Text.Length > 0)) 
            //if ((txtCalle.Text.Length == 0 || txtAltura.Text.Length == 0))

            //txtContrasenia.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            new frmABMUsuario().Show();
            this.Close();

        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
