using MercadoEnvios.ABM_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Historial_Cliente
{
    public partial class frmHistorialCliente : Form
    {
        Conexion conn;
        Sesion sesion;
        public frmHistorialCliente()
        {
            InitializeComponent();
            conn = Conexion.Instance;
            sesion = Sesion.Instance;
            string query = "exec ADIOS_TERCER_ANIO.verHistoricoComprasUsuario " + Convert.ToString(sesion.idUsuario);
            DataTable tablaDeCompras = new DataTable("Compras/Subastas");
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            da.Fill(tablaDeCompras);
            grillaDeCompras.DataSource = tablaDeCompras.DefaultView;

            grillaDeCompras.AllowUserToDeleteRows = false;
            grillaDeCompras.AllowUserToAddRows = false;
            grillaDeCompras.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
