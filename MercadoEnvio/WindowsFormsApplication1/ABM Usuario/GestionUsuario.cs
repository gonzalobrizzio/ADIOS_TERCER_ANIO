using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class frmGestionUsuario : Form
    {
        Conexion conn;
        public frmGestionUsuario()
        {
            InitializeComponent();
            String query = "SELECT usuario FROM ADIOS_TERCER_ANIO.Usuario";
            conn = Conexion.Instance;
            SqlCommand buscarUsuarios = new SqlCommand(query, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tablaDeUsuarios = new DataTable("Usuarios");
            da.Fill(tablaDeUsuarios);
            dataUsuarios.DataSource = tablaDeUsuarios.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABM_Usuario.NuevoUsuario(this).Show();
            this.Hide();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Parent.Show();
            this.Close();

        }
    }
}
