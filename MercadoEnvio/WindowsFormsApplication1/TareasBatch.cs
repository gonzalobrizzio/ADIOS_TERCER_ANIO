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

namespace MercadoEnvios
{
    public partial class TareasBatch : Form
    {
        Conexion conn;
        public TareasBatch()
        {
            conn = Conexion.Instance;
            InitializeComponent();
        }

        public void correr()
        {
            /*******************************************************************************************************************************************/
            /**********************************Actualizacion Diaria De Subastas Finalizadas Y La Correspondiente Facturacion****************************/
            /*******************************************************************************************************************************************/
            string subastasVencidas = "select p.id from ADIOS_TERCER_ANIO.Publicacion p "
                                   + "where p.fechaFin < @fechaDeHoy AND p.idEstado != 4 ";
            SqlCommand subastas = new SqlCommand(subastasVencidas, conn.getConexion);

            SqlParameter fechaActual = new SqlParameter("@fechaDeHoy", SqlDbType.DateTime);
            fechaActual.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            fechaActual.Direction = ParameterDirection.Input;

            subastas.Parameters.Add(fechaActual);
            SqlDataReader da = subastas.ExecuteReader();
            List<Int32> listaPublis = new List<Int32>();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    listaPublis.Add(da.GetInt32(0));
                }
            }
            da.Close();
            SqlCommand publicaciones = new SqlCommand("ADIOS_TERCER_ANIO.FinalizarPublicacion", conn.getConexion);
            publicaciones.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idPublicacion = new SqlParameter("@idPublicacion", SqlDbType.Int);
            idPublicacion.Direction = ParameterDirection.Input;
            SqlParameter fechaSubastas = new SqlParameter("@fechaFin", SqlDbType.DateTime);
            fechaSubastas.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
            fechaSubastas.Direction = ParameterDirection.Input;

            foreach (Int32 idPubli in listaPublis)
            {

                idPublicacion.SqlValue = idPubli;
                publicaciones.Parameters.Add(idPublicacion);
                publicaciones.Parameters.Add(fechaSubastas);
                publicaciones.ExecuteNonQuery();

                publicaciones.Parameters.Clear();
            }
        }

        private void TareasBatch_Load(object sender, EventArgs e)
        {

        }
    }
}
