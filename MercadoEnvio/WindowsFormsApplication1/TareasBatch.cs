using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
                                   + "inner join ADIOS_TERCER_ANIO.TipoPublicacion tp on tp.id = p.idTipoPublicacion and tp.nombre like 'Subasta' "
                                   + "where p.fechaFin < GETDATE()";//ToDo
            SqlCommand subastas = new SqlCommand(subastasVencidas, conn.getConexion);
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
            SqlCommand publicaciones = new SqlCommand("ADIOS_TERCER_ANIO.FinalizarSubasta", conn.getConexion);
            publicaciones.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter idPublicacion = new SqlParameter("@idPublicacion", SqlDbType.Int);
            idPublicacion.Direction = ParameterDirection.Input;
            publicaciones.Parameters.Add(idPublicacion);
            foreach (Int32 idPubli in listaPublis)
            {
                idPublicacion.SqlValue = idPubli;
                publicaciones.ExecuteNonQuery();
            }
            SqlCommand comprasInmediatas = new SqlCommand("ADIOS_TERCER_ANIO.FinalizarComprasInmediatas", conn.getConexion);
            comprasInmediatas.CommandType = System.Data.CommandType.StoredProcedure;
            comprasInmediatas.ExecuteNonQuery();
            /*******************************************************************************************************************************************/
        }

        private void TareasBatch_Load(object sender, EventArgs e)
        {

        }
    }
}
