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
    public partial class frmABMUsuario : Form
    {
        Conexion conn;
        public frmABMUsuario()
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

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            new frmPantallaPrincipal("Administrativo").Show();
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmNuevoUsuario().Show();
            this.Close();
        }
    }
}
