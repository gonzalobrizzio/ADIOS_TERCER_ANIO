using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace MercadoEnvios.ComprarOfertar
{
    public partial class frmDetalle : Form
    {
        SqlDataReader dataReader;
        Conexion conn = Conexion.Instance;
        int idPublicacion;
        int envioP;
        int indexPregunta = 0;
        bool preguntas;
        int idEstado;

        Sesion sesion = Sesion.Instance;

        public frmDetalle(int id)
        {
            InitializeComponent();
            idPublicacion = id;
            this.getData();
            btnAnt.Enabled = false;
        }

        void getData()
        {
            String cmd = "ADIOS_TERCER_ANIO.detallePublicacion";
            SqlCommand detallePublicacion = new SqlCommand(cmd, conn.getConexion);
            detallePublicacion.CommandType = System.Data.CommandType.StoredProcedure;
            lblPausa.Visible = false;
            SqlParameter idP = new SqlParameter("@idPublicacion", SqlDbType.Int);
            idP.SqlValue = idPublicacion;
            idP.Direction = ParameterDirection.Input;
            detallePublicacion.Parameters.Add(idP);

            dataReader = detallePublicacion.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                lblIdPublicacion.Text = idPublicacion.ToString();
                if (!dataReader[0].Equals(DBNull.Value)) { lblDescripcion.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { lblFechaInicio.Text = Convert.ToString(dataReader.GetDateTime(1)); }
                if (!dataReader[2].Equals(DBNull.Value)) { lblFechaFin.Text = Convert.ToString(dataReader.GetDateTime(2)); }
                if (!dataReader[3].Equals(DBNull.Value)) {
                    lblTipo.Text = dataReader.GetString(3);
                    if (lblTipo.Text.Equals("Compra Inmediata")) { btnComprar.Text = "Comprar";}
                    else  { btnComprar.Text = "Ofertar"; }
                }
                if (!dataReader[4].Equals(DBNull.Value)) { lblPrecio.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { lblVis.Text = dataReader.GetString(5); }
                if (!dataReader[6].Equals(DBNull.Value)) { lblUsuario.Text = dataReader.GetString(6); }
                if (!dataReader[7].Equals(DBNull.Value)) { lblRubro.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { lblStock.Text = dataReader.GetInt32(8).ToString() + " unidades disponibles."; }
                if (!dataReader[9].Equals(DBNull.Value))
                {
                    if (dataReader.GetInt32(9) == 0) { lblEnvio.Text = "Con envío"; }
                    else { 
                           lblEnvio.Text = "Sin envío";
                           Envio.Visible = false;
                    }

                    if (dataReader.GetInt32(10) == 0) { preguntas = true; }
                    else { preguntas = false; }
                }
                if (!dataReader[11].Equals(DBNull.Value))
                {
                    if (dataReader.GetInt32(11) != 0)
                    {
                        lblCalificacionPromedio.Text = "Calificación Promedio: " + dataReader.GetInt32(11).ToString();
                    }
                    else
                    {
                        lblCalificacionPromedio.Text = "Usuario sin calificar";
                    }
                }
                else {
                    lblCalificacionPromedio.Text = "Usuario sin calificar";
                }

                if (!dataReader[12].Equals(DBNull.Value))
                {
                    idEstado = dataReader.GetInt32(12);
                }
            }
            dataReader.Close();

            if (preguntas)
            {
                cmd = "ADIOS_TERCER_ANIO.obtenerPregunta";
                SqlCommand pregunta = new SqlCommand(cmd, conn.getConexion);
                pregunta.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idPub = new SqlParameter("@idPublicacion", SqlDbType.Int);
                idPub.SqlValue = idPublicacion;
                idPub.Direction = ParameterDirection.Input;

                SqlParameter nro = new SqlParameter("@nroPreg", SqlDbType.Int);
                nro.SqlValue = indexPregunta;
                nro.Direction = ParameterDirection.Input;

                pregunta.Parameters.Add(idPub);
                pregunta.Parameters.Add(nro);

                dataReader = pregunta.ExecuteReader();
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    if (!dataReader[0].Equals(DBNull.Value)) { lblPregunta.Text = dataReader.GetString(0); }
                    if (!dataReader[1].Equals(DBNull.Value)) { lblRespuesta.Text = dataReader.GetString(1); }
                }
                else
                {
                    lblPregunta.Text = "¡No hay más preguntas hasta el momento!";
                    lblRespuesta.Text = "";
                    btnSgte.Enabled = false;
                }

                dataReader.Close();
            }
            else if(preguntas == false && idEstado !=3) { 
                lblPregunta.Text = "¡Las preguntas no están disponibles!";
                lblRespuesta.Text = "";
                txtPregunta.Enabled = false;
                btnAnt.Enabled = false;
                btnPregunta.Enabled = false;
                btnSgte.Enabled = false;
            }
            else if(idEstado == 3)
            {
                txtPregunta.Visible = false;
                Envio.Enabled = false;
                lblPausa.Visible = true;
                grpPreguntas.Visible = false;
                lblRespuesta.Text = "";
                txtPregunta.Enabled = false;
                btnAnt.Enabled = false;
                btnPregunta.Enabled = false;
                btnSgte.Enabled = false;
                btnComprar.Enabled = false;
            }

        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            Entidades.Utilidades util = new Entidades.Utilidades();  
            StringBuilder validacion = new StringBuilder();

            util.validarNoVacio(txtPregunta, validacion);

            if (validacion.Length > 0)
            {
                MessageBox.Show(validacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = new StringBuilder();

            }
            else
            {

                SqlCommand nuevaPregunta = new SqlCommand("ADIOS_TERCER_ANIO.NuevaPregunta", conn.getConexion);
                nuevaPregunta.CommandType = System.Data.CommandType.StoredProcedure;

                //ADIOS_TERCER_ANIO.NuevaPregunta (@idPublicacion INT, @fecha DATETIME, @pregunta NVARCHAR(255), @idUsuario INT)

                SqlParameter idPubli = new SqlParameter("@idPublicacion", SqlDbType.Int);
                idPubli.SqlValue = idPublicacion;
                idPubli.Direction = ParameterDirection.Input;

                SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
                fecha.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                fecha.Direction = ParameterDirection.Input;

                SqlParameter preguntaP = new SqlParameter("@pregunta", SqlDbType.NVarChar, 255);
                preguntaP.SqlValue = txtPregunta.Text;
                preguntaP.Direction = ParameterDirection.Input;

                SqlParameter idUsu = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsu.SqlValue = sesion.idUsuario;
                idUsu.Direction = ParameterDirection.Input;

                nuevaPregunta.Parameters.Add(idPubli);
                nuevaPregunta.Parameters.Add(fecha);
                nuevaPregunta.Parameters.Add(preguntaP);
                nuevaPregunta.Parameters.Add(idUsu);

                nuevaPregunta.ExecuteNonQuery();

                nuevaPregunta.Parameters.Clear();
                txtPregunta.Text = "";

                MessageBox.Show("Su pregunta ha sido realizada correctamente!", "Bien Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            indexPregunta++;
            getData();
            btnAnt.Enabled = true;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            indexPregunta--;
            getData();
            btnSgte.Enabled = true;
            if (indexPregunta == 0) btnAnt.Enabled = false;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if(Envio.Checked)
            {
                envioP = 0;
            }
            else
            {
                envioP = 1;
            }

            new frmConfirmar(idPublicacion,envioP).Show(); 
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmComprarOfertar().Show();
            this.Close();
        }

        private void frmDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmComprarOfertar().Show();
            this.Close();
        }

    }
}