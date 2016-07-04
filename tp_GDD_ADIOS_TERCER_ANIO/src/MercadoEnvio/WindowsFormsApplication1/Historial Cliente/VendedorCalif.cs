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
    public partial class VendedorCalif : Form
    {
        Conexion conn = Conexion.Instance;
        Sesion sesion = Sesion.Instance;

        public VendedorCalif()
        {
            InitializeComponent();
          
            this.getData();
        }

        public void getData()
        {
            String queryCantPendientes = "SELECT COUNT(calificacion.id) FROM ADIOS_TERCER_ANIO.Calificacion calificacion" +
                        " inner join ADIOS_TERCER_ANIO.Compra compra on compra.id = calificacion.idCompra" +
                        " where compra.idComprador = " + sesion.idUsuario + " and pendiente = 1";

            try
            {
                SqlCommand comando = new SqlCommand(queryCantPendientes, conn.getConexion);
                int retorno = (Int32)comando.ExecuteScalar();
                lblPendientes.Text = "Usted tiene " + retorno.ToString() + " calificaciones pendientes.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener calificaciones pendientes.\n" + ex.Message);
            }

            SqlParameter idCalificador = new SqlParameter("@idCalificador", SqlDbType.Int);
            idCalificador.SqlValue = sesion.idUsuario;
            idCalificador.Direction = ParameterDirection.Input;

            SqlCommand obtenerCantidad = new SqlCommand("ADIOS_TERCER_ANIO.obtenerTipoDeCompraConNPuntaje", conn.getConexion);
            obtenerCantidad.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter puntaje = new SqlParameter("@puntaje", SqlDbType.Int);
            puntaje.Direction = ParameterDirection.Input;

            SqlParameter tipo = new SqlParameter("@tipo", SqlDbType.NVarChar, 255);
            tipo.Direction = ParameterDirection.Input;

            SqlParameter cantidad = new SqlParameter("@cant", null);
            cantidad.Direction = ParameterDirection.Output;
            cantidad.SqlDbType = SqlDbType.Int;

            tipo.SqlValue = "Compra Inmediata";
            puntaje.SqlValue = 1;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras1.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 2;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras2.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 3;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras3.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 4;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras4.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 5;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblCompras5.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 1;
            tipo.SqlValue = "Subasta";

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas1.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 2;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas2.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 3;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas3.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 4;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas4.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();

            puntaje.SqlValue = 5;

            obtenerCantidad.Parameters.Add(idCalificador);
            obtenerCantidad.Parameters.Add(puntaje);
            obtenerCantidad.Parameters.Add(tipo);
            obtenerCantidad.Parameters.Add(cantidad);

            try { obtenerCantidad.ExecuteNonQuery(); }
            catch (SqlException error) { MessageBox.Show(error.Message); }
            lblSubastas5.Text = Convert.ToInt32(obtenerCantidad.Parameters["@cant"].Value).ToString();

            obtenerCantidad.Parameters.Clear();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            new Calificar.frmCalificacion().Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Historial_Cliente.frmHistorialCliente().Show();
            this.Close();
        }
    }
}
