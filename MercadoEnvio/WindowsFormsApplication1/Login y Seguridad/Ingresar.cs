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
        Conexion conn;

        public frmIngresar()
        {
            InitializeComponent();

            this.conn = new Conexion("localhost",
                                      "SQLSERVER2012",
                                      "GD1C2016",
                                      "gd",
                                      "gd2016");
            conn.conectar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string textoCmd = "SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='" + txtUsr.Text + "' and p.pass='" + txtContra.Text + "'";

            SqlCommand cmd = new SqlCommand(textoCmd, conn.getConexion());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int idUsuario = Convert.ToInt16(dr[0]);
                dr.Close();
                textoCmd = "SELECT idRol FROM ADIOS_TERCER_ANIO.RolUsuario WHERE idUsuario = " + idUsuario;
                cmd = new SqlCommand(textoCmd, conn.getConexion());
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
                    cmd = new SqlCommand(textoCmd, conn.getConexion());
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
