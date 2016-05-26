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

            string datosConexion = "Data Source=DARWIN" + "\\" + "SQLSERVER2012;Initial Catalog=GD1C2016;User ID=gd;Password=gd2016;Trusted_Connection=False;";
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
            string textoCmd = "SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='"+ txtUsr.Text +"' and p.pass='" + txtContra.Text + "'";

            SqlCommand cmd = new SqlCommand (textoCmd,con);
            
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() != null)
            {
                //EN BD: if(cantFallidos>0) cantFallidos = 0;
                //EN BD: if(cantRoles > 1) {
                MessageBox.Show(Convert.ToString(dr[0]));
                    new ABM_Rol.frmElegirRol(this).Show();
                    this.Hide();
                // } else {
                //using (var usrUsuario = new ABM_Usuario.ABMUsuario())
                //{
                //    usrUsuario.ShowDialog();
                //    this.Close();
                //} 
            }
            else
            {
                MessageBox.Show(Convert.ToString(dr["id"]));
                txtContra.Text = "";
                //EN BD: cantFallidos++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                new ABM_Usuario.NuevoUsuario(this).Show();
                this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmABMRol().Show();
            this.Hide();
        }

        private void Ingresar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
