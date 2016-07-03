using MercadoEnvios.Entidades;
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

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmModificarPublicacion : Form
    {
        Conexion conn;
        Sesion sesion;
        Utilidades funcion = new Utilidades();
        public frmModificarPublicacion()
        {
            InitializeComponent();

            conn = Conexion.Instance;
            sesion = Sesion.Instance;
            this.getData();
            if(publicaciones.Rows.Count == 0)
            {
                btnActivar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnPausar.Enabled = false;
                btnModificar.Enabled = false;

            }
        }

        public void getData()
        {
            string sacarDatosPublicacion = "SELECT id, descripcion, precio, stock, (SELECT nombre FROM ADIOS_TERCER_ANIO.Visibilidad WHERE idVisibilidad = id) AS Visibilidad, "
            + "(select nombre from ADIOS_TERCER_ANIO.TipoPublicacion where id = idTipoPublicacion) AS Tipo_De_Publicacion, "
            + "(SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro WHERE idRubro = id) AS Rubro, iif(tienePreguntas = 0, 'SI', 'NO') AS Acepta_Preguntas, "
            + "iif(tieneEnvio = 1, 'NO', 'SI') AS Permite_Envios, "
            + "(SELECT nombre FROM ADIOS_TERCER_ANIO.Estado WHERE idEstado = id) AS Estado, fechaFin AS Fecha_Finalización "
            +"FROM ADIOS_TERCER_ANIO.Publicacion WHERE @idPublic = idPublicador ORDER BY idEstado ASC";
            SqlParameter idPu = new SqlParameter("@idPublic", SqlDbType.Int);
            idPu.SqlValue = sesion.idUsuario;
            idPu.Direction = ParameterDirection.Input;

            SqlDataAdapter da = new SqlDataAdapter(sacarDatosPublicacion, conn.getConexion);
            da.SelectCommand.Parameters.Add(idPu);
            da.SelectCommand.ExecuteNonQuery();
            DataTable tablaDeClientes = new DataTable("Publicaciones");
            da.Fill(tablaDeClientes);
            publicaciones.DataSource = tablaDeClientes.DefaultView;

            publicaciones.AllowUserToAddRows = false;
            publicaciones.AllowUserToDeleteRows = false;
            publicaciones.ReadOnly = true;
            publicaciones.Columns[0].Visible = false;
            publicaciones.Columns[5].Width = 130;
            publicaciones.Columns[10].Width = 162;

            
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Borrador")
            {
                SqlCommand actualizarPublicacion = new SqlCommand("ADIOS_TERCER_ANIO.ActivarPublicacion", conn.getConexion);
                actualizarPublicacion.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@idPublicacion", SqlDbType.Int);
                id.SqlValue = Convert.ToInt32(this.publicaciones.CurrentRow.Cells[0].Value);
                id.Direction = ParameterDirection.Input;
                
                SqlParameter fechaInicio = new SqlParameter("@fechaInicio", SqlDbType.DateTime);
                fechaInicio.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                fechaInicio.Direction = ParameterDirection.Input;

                int dias = funcion.obtenerDuracionDeVisibilidad(Convert.ToString(this.publicaciones.CurrentRow.Cells[4].Value));

                SqlParameter fechaFin = new SqlParameter("@fechaFin", SqlDbType.DateTime);
                fechaFin.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]).AddDays(dias);
                fechaFin.Direction = ParameterDirection.Input;

                actualizarPublicacion.Parameters.Add(id);
                actualizarPublicacion.Parameters.Add(fechaInicio);
                actualizarPublicacion.Parameters.Add(fechaFin);
                actualizarPublicacion.ExecuteNonQuery();
                this.getData();
            }
            else if (this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Pausada")
            {
                string despausar = "UPDATE ADIOS_TERCER_ANIO.Publicacion SET idEstado = 2 WHERE @idPublicacion = id";
                SqlCommand actualizarPublicacion = new SqlCommand(despausar, conn.getConexion);
                SqlParameter id = new SqlParameter("@idPublicacion", SqlDbType.Int);
                id.SqlValue = Convert.ToInt32(this.publicaciones.CurrentRow.Cells[0].Value);
                id.Direction = ParameterDirection.Input;

                actualizarPublicacion.Parameters.Add(id);
                actualizarPublicacion.ExecuteNonQuery();
                this.getData();
            }
            else
            {
                MessageBox.Show("Solo se pueden modificar publicaciones con un estado Borrador o Pausada", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Activa")
            {
                SqlCommand actualizarPublicacion = new SqlCommand("ADIOS_TERCER_ANIO.PausarPublicacion", conn.getConexion);
                actualizarPublicacion.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@idPublicacion", SqlDbType.Int);
                id.SqlValue = Convert.ToInt32(this.publicaciones.CurrentRow.Cells[0].Value);
                id.Direction = ParameterDirection.Input;
                actualizarPublicacion.Parameters.Add(id);
                actualizarPublicacion.ExecuteNonQuery();
                this.getData();
            }
            else
            {
                MessageBox.Show("Solo se pueden modificar publicaciones con un estado Pausada", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if ((this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Activa" || this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Pausada") && this.publicaciones.CurrentRow.Cells[5].Value.ToString() != "Subasta")
            {
                SqlCommand actualizarPublicacion = new SqlCommand("ADIOS_TERCER_ANIO.FinalizarPublicacion", conn.getConexion);
                actualizarPublicacion.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter id = new SqlParameter("@idPublicacion", SqlDbType.Int);
                id.SqlValue = Convert.ToInt32(this.publicaciones.CurrentRow.Cells[0].Value);
                id.Direction = ParameterDirection.Input;

                SqlParameter fechaFin = new SqlParameter("@fechaFin", SqlDbType.DateTime);
                fechaFin.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                fechaFin.Direction = ParameterDirection.Input;

                actualizarPublicacion.Parameters.Add(id);
                actualizarPublicacion.Parameters.Add(fechaFin);
                actualizarPublicacion.ExecuteNonQuery();
                this.getData();
            }
            else
            {
                MessageBox.Show("Solo se pueden modificar publicaciones con un estado distinto a Finalizada o Borrador ni tampoco Publicaciones de tipo Subasta, recuerdelo!","Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.publicaciones.CurrentRow.Cells[9].Value.ToString() == "Borrador")
            {
                new EditarPublicacion(Convert.ToInt32(this.publicaciones.CurrentRow.Cells[0].Value)).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Solo se pueden modificar publicaciones con estado borrador", "Error al modificar",  MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmElegirAccion().Show();
            this.Close();
        }

    }
}
