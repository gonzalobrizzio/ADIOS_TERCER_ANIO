using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Listado_Estadistico
{
    public partial class frmListadoDeMayorCantidadDeFactura : Form
    {
        Conexion conn;
        SqlDataAdapter da;
        public frmListadoDeMayorCantidadDeFactura(int trimestre, int anio)
        {
            InitializeComponent();
            conn = Conexion.Instance;
            this.getData(trimestre, anio);
        }


        public void getData(int trimestref, int aniof)
        {

            SqlParameter anio = new SqlParameter("@anio", SqlDbType.Int);
            anio.SqlValue = aniof;
            anio.Direction = ParameterDirection.Input;

            SqlParameter trimestre = new SqlParameter("@trimestre", SqlDbType.Int);
            trimestre.SqlValue = trimestref;
            trimestre.Direction = ParameterDirection.Input;

            String cmd = "ADIOS_TERCER_ANIO.vendedoresConMasFacturasPorTrimestreAnio";

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(trimestre);
            da.SelectCommand.Parameters.Add(anio);
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaListado = new DataTable("Mayor_cantidad_de_facturas");
            da.Fill(tablaListado);
            listado.DataSource = tablaListado;
            listado.AllowUserToAddRows = false;
            listado.AllowUserToDeleteRows = false;
            listado.ReadOnly = true;

            listado.Columns[1].Width = 150;
            listado.Columns[2].Width = 150;
            listado.Columns[3].Width = 150;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmListadoEstadistico().Show();
            this.Close();
        }
    }
}
