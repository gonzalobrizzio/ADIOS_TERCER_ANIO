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

namespace MercadoEnvios.ComprarOfertar
{
    public partial class frmComprarOfertar : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;
        SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
        
        int nroPagina = 0;

        public frmComprarOfertar()
        {
            InitializeComponent();

            idUsuario.SqlValue = sesion.idUsuario;
            idUsuario.Direction = ParameterDirection.Input;

            this.getData();
        }

        private void getData()
        {

            // ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN(@idUsuario INT, @pagina INT)
            String cmd = "ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN";

            SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
            pagina.SqlValue = nroPagina;
            pagina.Direction = ParameterDirection.Input;

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idUsuario);
            da.SelectCommand.Parameters.Add(pagina);

            try
            {
                da.SelectCommand.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

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
            dgvPublicaciones.Columns[6].Visible = false;
            dgvPublicaciones.AllowUserToAddRows = false;
            dgvPublicaciones.AllowUserToDeleteRows = false;
            dgvPublicaciones.ReadOnly = true;

            da.SelectCommand.Parameters.Clear();

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
            new frmPantallaPrincipal().Show();
            btnSgte.Enabled = true;
            this.Close();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            int idPublicacion = Convert.ToInt32(dgvPublicaciones[4, dgvPublicaciones.CurrentCell.RowIndex].Value);
            new frmDetalle(idPublicacion).Show();
            this.Hide(); 
        }
    }
}
