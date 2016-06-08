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
    public partial class frmCalificacion : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;

        public frmCalificacion()
        {
            InitializeComponent();
            this.getData();
        }

        private void getData()
        {
            SqlParameter idCalificador = new SqlParameter("@idCalificador", SqlDbType.NVarChar, 255);
            idCalificador.SqlValue = 17;
            idCalificador.Direction = ParameterDirection.Input;            

            String cmd = "ADIOS_TERCER_ANIO.obtenerCompras";

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idCalificador);
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaDeCompras = new DataTable("Compras");
            da.Fill(tablaDeCompras);
            dgvCompras.DataSource = tablaDeCompras;
            dgvCompras.Columns[1].Width = 300;
            dgvCompras.Columns[2].Visible= false;
            dgvCompras.Columns[0].Width = 100;
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.ReadOnly = true;
        }


        private void tkbCalificacion_Scroll(object sender, EventArgs e)
        {
            lblEstrellas.Text = tkbCalificacion.Value + " estrellas.";
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            //txtDetalle.Text, tkbCalificacion.Value, lblUsuario.Text, 
            // [cargarCalificacion] (@idCompra int, @puntaje int, @fecha datetime, @detalle nvarchar(255))

            SqlCommand cargarCalificacion = new SqlCommand("ADIOS_TERCER_ANIO.cargarCalificacion", conn.getConexion);
            cargarCalificacion.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter detalle = new SqlParameter("@detalle", SqlDbType.NVarChar, 255);
            detalle.Direction = ParameterDirection.Input;
            detalle.SqlValue = txtDetalle.Text;

            SqlParameter puntaje = new SqlParameter("@puntaje", SqlDbType.Int);
            puntaje.Direction = ParameterDirection.Input;
            puntaje.SqlValue =  Convert.ToInt32(tkbCalificacion.Value);

            SqlParameter idCompra = new SqlParameter("@idCompra", SqlDbType.Int);
            idCompra.Direction = ParameterDirection.Input;
            if (string.IsNullOrEmpty(lblIdCompra.Text))
            {
                idCompra.SqlValue = null;
            }
            else
            {
                idCompra.SqlValue = Convert.ToInt32(lblIdCompra.Text);
            }

            
            SqlParameter fecha = new SqlParameter("@fecha", DateTime.Now);
            fecha.Direction = ParameterDirection.Input;
            fecha.SqlDbType = SqlDbType.DateTime;
            
            cargarCalificacion.Parameters.Add(idCompra);
            cargarCalificacion.Parameters.Add(puntaje);
            cargarCalificacion.Parameters.Add(fecha);
            cargarCalificacion.Parameters.Add(detalle);
            try
            {
                cargarCalificacion.ExecuteNonQuery();
                this.getData();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblUsuario.Text = dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            lblCompra.Text = dgvCompras[1, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            lblIdCompra.Text = dgvCompras[2, dgvCompras.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
