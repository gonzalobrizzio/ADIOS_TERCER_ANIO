using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmIngresar : Form
    {
        SqlConnection con = new SqlConnection();

        public frmIngresar()
        {
            InitializeComponent();

            string datosConexion = "Data Source=localhost" + "\\" + "SQLSERVER2012;Initial Catalog=GD1C2016;User ID=gd;Password=gd2016;Trusted_Connection=False;";
            con.ConnectionString = datosConexion;
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo establecer la conexión con la Base de datos." + datosConexion); 
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoCmd = "SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='" + txtUsr.Text + "' and p.pass='" + txtContra.Text + "'";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int idUsuario = Convert.ToInt16(dr[0]);
                //MessageBox.Show(idUsuario.ToString());
                dr.Close();
                textoCmd = "SELECT idRol FROM ADIOS_TERCER_ANIO.RolUsuario WHERE idUsuario = " + idUsuario;
                cmd = new SqlCommand(textoCmd, con);
                dr = cmd.ExecuteReader();

                dr.Read();
                int rolActual = dr.GetInt32(0);
                if (!(dr.Read())){
                    if(rolActual == 1){
                        new frmPantallaAdministrador().Show();
                        this.Hide();
                    } else if (rolActual == 2) {
                        new ABM_Usuario.frmPantallaUsuario().Show();
                        this.Hide();
                    } else if (rolActual == 3) {
//                      new ABM_Usuario.frmPantallaEmpresa().Show();
                        this.Hide();
                    }

                } else {
                    dr.Close();
                    textoCmd = "SELECT r.nombre FROM ADIOS_TERCER_ANIO.RolUsuario ru inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol WHERE idUsuario = " +idUsuario;
                    cmd = new SqlCommand(textoCmd, con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    string roles = dr.GetString(0);
                    while (dr.Read())
                    {
                        roles = roles + "," + dr.GetString(0);
                    }
                    Form formRol = new ABM_Rol.frmElegirRol(roles);
                    formRol.Show();
                    this.Hide();
                }
            }
            else
            {
                dr.Close();
                MessageBox.Show(Convert.ToString("Los datos son invalidos"));
                txtContra.Text = "";
                //EN BD: cantFallidos++;
            }
        }

        private void Ingresar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
