using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmModificarPublicacion : Form
    {
        Conexion conn;
        Sesion sesion;
        public frmModificarPublicacion()
        {
            InitializeComponent();

            conn = Conexion.Instance;
            sesion = Sesion.Instance;

            string sacarDatosPublicacion = "SELECT id, descripcion, precio, stock, (SELECT descripcion FROM ADIOS_TERCER_ANIO.Visibilidad WHERE idVisibilidad = id) AS Visibilidad, tipo, (SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro WHERE idRubro = id) AS Rubro, iif(tienePreguntas = 0, 'SI', 'NO') AS Acepta_Preguntas, iif(idEnvio IS NULL, 'NO', 'SI') AS Permite_Envios, (SELECT nombre FROM ADIOS_TERCER_ANIO.Estado WHERE idEstado = id) AS Estado FROM ADIOS_TERCER_ANIO.Publicacion WHERE @id = idPublicador";
            SqlCommand obtenerPublicacion = new SqlCommand(sacarDatosPublicacion, conn.getConexion);
            SqlParameter idPu = new SqlParameter("@id", SqlDbType.Int);
            idPu.SqlValue = sesion.idUsuario;
            idPu.Direction = ParameterDirection.Input;
            obtenerPublicacion.Parameters.Add(idPu);

            SqlDataAdapter da = new SqlDataAdapter(sacarDatosPublicacion, conn.getConexion);
            DataTable tablaDeClientes = new DataTable("Publicaciones");
            da.Fill(tablaDeClientes);
            publicaciones.DataSource = tablaDeClientes.DefaultView;

            publicaciones.AllowUserToAddRows = false;
            publicaciones.AllowUserToDeleteRows = false;
            publicaciones.ReadOnly = true;
            publicaciones.Columns[0].Visible = false;
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Borrador")
            {

                new EditarPublicacion(Convert.ToInt32(this.publicaciones.CurrentRow.Cells[0].Value)).Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
