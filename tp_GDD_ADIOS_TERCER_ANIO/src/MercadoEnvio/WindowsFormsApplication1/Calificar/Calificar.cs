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

namespace MercadoEnvios.Calificar
{
    public partial class frmCalificacion : Form
    {
        Conexion conn = Conexion.Instance;
        Entidades.Utilidades funciones = new Entidades.Utilidades();
        SqlDataAdapter da;
        Form anterior;
        Sesion sesion = Sesion.Instance;

        public frmCalificacion()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getData();
        }

        private void getData()
        {
            SqlParameter idCalificador = new SqlParameter("@idCalificador", SqlDbType.Int);
            idCalificador.SqlValue = sesion.idUsuario;
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
            dgvCompras.ReadOnly = true;

            tkbCalificacion.ResetText();

            lblEstrellas.Text = "";
            lblCompra.Text = "";
            txtDetalle.Text = "";
            lblUsuario.Text = "";
            lblEstrellas.Text = tkbCalificacion.Value + " estrellas.";
        }


        private void tkbCalificacion_Scroll(object sender, EventArgs e)
        {
            lblEstrellas.Text = tkbCalificacion.Value + " estrellas.";
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();

            if (tkbCalificacion.Value < 0) {
                mensaje.AppendLine("Debe insertar una calificacion!");
            }


            if (lblCompra.Text == "") {
                mensaje.AppendLine("Debe seleccionar una compra para calificar!");
            }

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cargarCalificacion = new SqlCommand("ADIOS_TERCER_ANIO.cargarCalificacion", conn.getConexion);
                cargarCalificacion.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter detalle = new SqlParameter("@detalle", SqlDbType.NVarChar, 255);
                detalle.Direction = ParameterDirection.Input;
                detalle.SqlValue = txtDetalle.Text;

                SqlParameter puntaje = new SqlParameter("@puntaje", SqlDbType.Int);
                puntaje.Direction = ParameterDirection.Input;
                puntaje.SqlValue = Convert.ToInt32(tkbCalificacion.Value);

                SqlParameter idCompra = new SqlParameter("@idCompra", SqlDbType.Int);
                idCompra.Direction = ParameterDirection.Input;
                idCompra.SqlValue = Convert.ToInt32(lblIdCompra.Text);
                
                SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
                fecha.SqlValue = DateTime.Now;
                fecha.Direction = ParameterDirection.Input;

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
        }

        private void btnReputacion_Click(object sender, EventArgs e)
        {
            new frmHistorial().Show();
            this.Close();
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.Rows.Count > 0)
            {
                lblUsuario.Text = dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value.ToString();
                lblCompra.Text = dgvCompras[1, dgvCompras.CurrentCell.RowIndex].Value.ToString();
                lblIdCompra.Text = dgvCompras[2, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();
        }


    }
}
