using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Facturas
{
    public partial class HistorialDeFacturas : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;

        int nroPagina = 0;
        Sesion sesion;
        public HistorialDeFacturas()
        {
            InitializeComponent();
            sesion = Sesion.Instance;
            this.getData();

        }

        private void getData()
        {

            // ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT)
            String cmd = "ADIOS_TERCER_ANIO.obtenerFacturasPaginaN";

            SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
            idUsuario.SqlValue = sesion.idUsuario;
            idUsuario.Direction = ParameterDirection.Input;

            SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
            pagina.SqlValue = nroPagina;
            pagina.Direction = ParameterDirection.Input;

            SqlParameter idRol = new SqlParameter("idRol", SqlDbType.Int);
            idRol.SqlValue = sesion.idRol;
            idRol.Direction = ParameterDirection.Input;

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idUsuario);
            da.SelectCommand.Parameters.Add(pagina);
            da.SelectCommand.Parameters.Add(idRol);

            try
            {
                da.SelectCommand.ExecuteNonQuery();
                DataTable tablaDeFacturas = new DataTable("Facturas");
                da.Fill(tablaDeFacturas);
                dgvFacturas.DataSource = tablaDeFacturas;
                dgvFacturas.Columns[0].Width = 50;
                dgvFacturas.Columns[1].Width = 100;
                dgvFacturas.Columns[2].Width = 100;
                dgvFacturas.Columns[3].Width = 150;
                dgvFacturas.AllowUserToDeleteRows = false;
                dgvFacturas.AllowUserToAddRows = false;
                dgvFacturas.ReadOnly = true;
            }
            catch (SqlException error)
            {
                btnSgte.Enabled = false;
                MessageBox.Show(error.Message);
            }


        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            btnSgte.Enabled = true;
            this.getData();
        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            nroPagina++;
            btnAnt.Enabled = true;
            this.getData();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new MercadoEnvios.ABM_Usuario.frmPantallaPrincipal().Show();
            this.Close();
        }

        private void HistorialDeFacturas_Load(object sender, EventArgs e)
        {

        }
    }
}