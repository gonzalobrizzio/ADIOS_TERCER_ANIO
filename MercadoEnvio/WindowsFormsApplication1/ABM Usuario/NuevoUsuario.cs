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

            string queryBuscarRoles = "SELECT DISTINCT nombre FROM ADIOS_TERCER_ANIO.Rol WHERE nombre != 'Administrativo'";
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

            if (cmbRolAsignado.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debe indicar un ROL", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((cmbRolAsignado.SelectedItem).Equals("Cliente"))
            {
                new frmNuevoCliente("Cliente").Show();
                this.Close();
            }
            else if ((cmbRolAsignado.SelectedItem).Equals("Empresa"))
            {
                new frmNuevaEmpresa("Empresa").Show();
                this.Close();
            }
            
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
