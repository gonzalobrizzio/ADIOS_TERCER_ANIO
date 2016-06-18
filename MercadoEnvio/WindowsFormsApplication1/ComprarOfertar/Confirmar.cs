using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace MercadoEnvios.ComprarOfertar
{
    public partial class frmConfirmar : Form
    {
        SqlDataReader dataReader;
        Conexion conn = Conexion.Instance;
        int idPublicacion;
        int envio;
        String tipoCompra;

        Sesion sesion = Sesion.Instance;

        public frmConfirmar(int id, int tieneEnvio)
        {
            InitializeComponent();
            idPublicacion = id;
            envio = tieneEnvio;
            this.getData();
        }

        void getData()
        {
            String cmd = "ADIOS_TERCER_ANIO.detallePublicacion";
            SqlCommand detallePublicacion = new SqlCommand(cmd, conn.getConexion);
            detallePublicacion.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idP = new SqlParameter("@idPublicacion", SqlDbType.Int);
            idP.SqlValue = idPublicacion;
            idP.Direction = ParameterDirection.Input;
            detallePublicacion.Parameters.Add(idP);

            dataReader = detallePublicacion.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[3].Equals(DBNull.Value))
                {
                    tipoCompra = dataReader.GetString(3);
                    if (tipoCompra.Equals("Compra Inmediata"))
                    {
                        btnConfirmar.Text = "Comprar";
                        lblNumeric.Text = "Cantidad";
                        if (!dataReader[8].Equals(DBNull.Value)) { lblCantPrecio.Text = "Cantidad máxima: " + dataReader.GetInt32(8).ToString(); }
                    }
                    else
                    {
                        btnConfirmar.Text = "Ofertar";
                        lblNumeric.Text = "Monto: ";
                        if (!dataReader[4].Equals(DBNull.Value)) { lblCantPrecio.Text = "Monto minimo: " + Convert.ToString(dataReader.GetDecimal(4)); }
                    }
                }

                if (!dataReader[0].Equals(DBNull.Value)) { this.Text = btnConfirmar.Text + " " + dataReader.GetString(0); }
            }

            detallePublicacion.Parameters.Clear();

            dataReader.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmDetalle(idPublicacion).Show();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Entidades.Utilidades util = new Entidades.Utilidades();
            StringBuilder validacion = new StringBuilder();

            util.validarNoVacio(txtNumeric, validacion);
            util.validarDecimal(txtNumeric, validacion);

            if (validacion.Length > 0)
            {
                MessageBox.Show(validacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = new StringBuilder();

            }
            else
            {

                if (btnConfirmar.Text.Equals("Comprar"))
                {
                    SqlCommand comprar = new SqlCommand("ADIOS_TERCER_ANIO.Comprar", conn.getConexion);
                    comprar.CommandType = System.Data.CommandType.StoredProcedure;

                    //Comprar(@idPublicacion INT, @fecha DATETIME, @cant INT, @idComprador INT)

                    SqlParameter idPubli = new SqlParameter("@idPublicacion", SqlDbType.Int);
                    idPubli.SqlValue = idPublicacion;
                    idPubli.Direction = ParameterDirection.Input;

                    SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
                    fecha.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                    fecha.Direction = ParameterDirection.Input;

                    SqlParameter cant = new SqlParameter("@cant", SqlDbType.Int);
                    cant.SqlValue = Convert.ToInt32(txtNumeric.Text);
                    cant.Direction = ParameterDirection.Input;

                    SqlParameter idUsu = new SqlParameter("@idComprador", SqlDbType.Int);
                    idUsu.SqlValue = sesion.idUsuario;
                    idUsu.Direction = ParameterDirection.Input;

                    SqlParameter envioP = new SqlParameter("@envio", SqlDbType.Int);
                    envioP.SqlValue = envio;
                    envioP.Direction = ParameterDirection.Input;

                    comprar.Parameters.Add(idPubli);
                    comprar.Parameters.Add(fecha);
                    comprar.Parameters.Add(cant);
                    comprar.Parameters.Add(idUsu);
                    comprar.Parameters.Add(envioP);

                    try
                    {
                        comprar.ExecuteNonQuery();
                        MessageBox.Show("Compra exitosa! Contáctese con su vendedor");
                        new frmComprarOfertar().Show();
                        this.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else
                {
                    SqlCommand ofertar = new SqlCommand("ADIOS_TERCER_ANIO.Ofertar", conn.getConexion);
                    ofertar.CommandType = System.Data.CommandType.StoredProcedure;

                    //Ofertar(@idPublicacion INT, @fecha DATETIME, @monto INT, @idUsuario INT)
                    //Ofertar(@idPublicacion INT, @fecha DATETIME, @monto DECIMAL(18,2), @idUsuario INT)

                    SqlParameter idPubli = new SqlParameter("@idPublicacion", SqlDbType.Int);
                    idPubli.SqlValue = idPublicacion;
                    idPubli.Direction = ParameterDirection.Input;

                    SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
                    fecha.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                    fecha.Direction = ParameterDirection.Input;

                    SqlParameter envioP = new SqlParameter("@envio", SqlDbType.Int);
                    envioP.SqlValue = envio;
                    envioP.Direction = ParameterDirection.Input;

                    SqlParameter monto = new SqlParameter("@monto", SqlDbType.Int);
//                    monto.SqlValue = Convert.ToInt32(txtNumeric.Text);
                    monto.SqlValue = Convert.ToDecimal(txtNumeric.Text);
                    monto.Direction = ParameterDirection.Input;

                    SqlParameter idUsu = new SqlParameter("@idUsuario", SqlDbType.Int);
                    idUsu.SqlValue = sesion.idUsuario;
                    idUsu.Direction = ParameterDirection.Input;

                    ofertar.Parameters.Add(idPubli);
                    ofertar.Parameters.Add(fecha);
                    ofertar.Parameters.Add(monto);
                    ofertar.Parameters.Add(idUsu);
                    ofertar.Parameters.Add(envioP);

                    try
                    {
                        ofertar.ExecuteNonQuery();
                        MessageBox.Show("Oferta exitosa! Aguarde a que finalice la publicación para saber si ganó la subasta.");
                        new frmComprarOfertar().Show();
                        this.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            }
    }
}
