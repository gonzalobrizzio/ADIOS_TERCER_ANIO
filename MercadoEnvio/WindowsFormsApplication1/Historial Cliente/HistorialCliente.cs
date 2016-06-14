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
        public frmHistorialCliente()
        {
            //CORREGIR ESTO, IRÍA UN INNER JOIN CON COMPRA, OFERTA!
            InitializeComponent();
            String query = "SELECT * FROM ADIOS_TERCER_ANIO.Compra WHERE idComprador=26";
            conn = Conexion.Instance;
            SqlCommand buscarCompras = new SqlCommand(query, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tablaDeCompras = new DataTable("Compras/Subastas");
            da.Fill(tablaDeCompras);
            grillaDeCompras.DataSource = tablaDeCompras.DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();

        }
    }
}
