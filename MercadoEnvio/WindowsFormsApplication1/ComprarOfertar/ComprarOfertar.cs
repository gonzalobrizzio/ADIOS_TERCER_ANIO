using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ComprarOfertar
{
    public partial class ComprarOfertar : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;

        int nroPagina = 0;

        public ComprarOfertar()
        {
            InitializeComponent();
            this.getData();
        }

        private void getData()
        {

            // ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN(@idUsuario INT, @pagina INT)
            String cmd = "ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN";

            SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
            idUsuario.SqlValue = 17; //MOCK
            idUsuario.Direction = ParameterDirection.Input;

            SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
            pagina.SqlValue = nroPagina;
            pagina.Direction = ParameterDirection.Input;

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idUsuario);
            da.SelectCommand.Parameters.Add(pagina); 
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaDeCompras = new DataTable("Publicaciones para comprar / ofertar");
            da.Fill(tablaDeCompras);
            dgvPublicaciones.DataSource = tablaDeCompras;
            // publicacion.descripcion, publicacion.fechaFin, publicacion.tipo, publicacion.precio, publicacion.id 
            dgvPublicaciones.Columns[0].Width = 200;
            dgvPublicaciones.Columns[1].Width = 100;
            dgvPublicaciones.Columns[2].Width = 100;
            dgvPublicaciones.Columns[3].Width = 50;
            dgvPublicaciones.Columns[4].Visible = false;
            dgvPublicaciones.Columns[5].Visible = false;
            dgvPublicaciones.AllowUserToAddRows = false;
            dgvPublicaciones.AllowUserToDeleteRows = false;
            dgvPublicaciones.ReadOnly = true;

        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            nroPagina++;
            btnAnt.Enabled = true;
            this.getData();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            this.getData();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            sesion.anterior.Show();
            this.Close();
        }
    }
}
