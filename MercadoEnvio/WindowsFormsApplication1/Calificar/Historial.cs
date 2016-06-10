using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Calificar
{
    public partial class frmHistorial : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;

        public frmHistorial()
        {
            InitializeComponent();
            this.getData();
        }

        private void getData()
        {
/*            SqlParameter idCalificador = new SqlParameter("@idCalificador", SqlDbType.NVarChar, 255)
            idCalificador.Direction = ParameterDirection.Input;

            String cmd = "ADIOS_TERCER_ANIO.obtenerCompras";

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idCalificador);
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaDeCompras = new DataTable("Compras");
            da.Fill(tablaDeCompras);
            dgvCompras.DataSource = tablaDeCompras;
            dgvCompras.Columns[0].Width = 100;
            dgvCompras.Columns[1].Width = 200;
            dgvCompras.Columns[2].Visible = false;
            dgvCompras.Columns[3].Width = 200;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.ReadOnly = true; */
        }
    }
}
