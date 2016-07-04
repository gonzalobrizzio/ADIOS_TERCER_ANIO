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
    public partial class frmElegirRol : Form
    {
        Sesion sesion = Sesion.Instance;
        Conexion conn = Conexion.Instance;

        public frmElegirRol(string roles)
        {
            InitializeComponent();
            string[] rolesSeparados = roles.Split(',');
            cboRol.Items.AddRange(rolesSeparados);
            cboRol.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (cboRol.SelectedItem == null)
                {
                    MessageBox.Show("No ha seleccionado un rol valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string queryBuscarId = "SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = '" +  Convert.ToString(cboRol.SelectedItem) + "'";
                    SqlCommand buscarRoles = new SqlCommand(queryBuscarId, conn.getConexion);
                    SqlDataReader dataReader = buscarRoles.ExecuteReader();
                    dataReader.Read();
                    sesion.idRol = dataReader.GetInt32(0);
                    dataReader.Close();
                    new ABM_Usuario.frmPantallaPrincipal().Show();
                    this.Close();
                }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Login_y_Seguridad.frmIngresar().Show();
            this.Close();
        }

        }
    }
