using MercadoEnvios.Entidades;
using MercadoEnvios.Generar_Publicacion;
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
    public partial class EditarPublicacion : Form
    {
        Conexion conn;
        Sesion sesion;
        int idPublicacion;
        StringBuilder mensajeValidacion = new StringBuilder();
        Utilidades funcion = new Utilidades();
        public EditarPublicacion(int id)
        {
            InitializeComponent();
            sesion = Sesion.Instance;
            conn = Conexion.Instance;
            idPublicacion = id;
            int preguntas = 1;
            int envio = 1;

            string rubrosDisponibles = "SELECT r.descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro r";
            conn = Conexion.Instance;
            SqlCommand buscarRubrosDisponibles = new SqlCommand(rubrosDisponibles, conn.getConexion);
            SqlDataReader dabuscarRubrosDisponibles = buscarRubrosDisponibles.ExecuteReader();

            while (dabuscarRubrosDisponibles.Read())
            {
                Rubro.Items.Add(dabuscarRubrosDisponibles.GetString(0));
            }
            dabuscarRubrosDisponibles.Close();

            string queryVisibilidad = "SELECT nombre FROM ADIOS_TERCER_ANIO.Visibilidad where deleted = 0";
            SqlCommand buscarVisibilidades = new SqlCommand(queryVisibilidad, conn.getConexion);
            SqlDataReader dataReader = buscarVisibilidades.ExecuteReader();
            while (dataReader.Read())
            {
                Visibilidad.Items.Add(dataReader.GetString(0));
            }
            dataReader.Close();

            string queryTipoDePublicacion = "SELECT nombre FROM ADIOS_TERCER_ANIO.TipoPublicacion";
            SqlCommand buscarTiposDePublicaciones = new SqlCommand(queryTipoDePublicacion, conn.getConexion);
            dataReader = buscarTiposDePublicaciones.ExecuteReader();
            while (dataReader.Read())
            {
                Tipo_de_Publicacion.Items.Add(dataReader.GetString(0));
            }
            dataReader.Close();

            string sacarDatosPublicacion = "SELECT descripcion, precio, stock, (SELECT nombre FROM ADIOS_TERCER_ANIO.Visibilidad WHERE idVisibilidad = id), "
                + "(select nombre from ADIOS_TERCER_ANIO.TipoPublicacion where id = idTipoPublicacion) as tipo, "
                + "(SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro WHERE idRubro = id), tienePreguntas, "
                + "tieneEnvio FROM ADIOS_TERCER_ANIO.Publicacion WHERE @id = id";
            SqlCommand obtenerPublicacion = new SqlCommand(sacarDatosPublicacion, conn.getConexion);
            SqlParameter idPu = new SqlParameter("@id", SqlDbType.Int);
            idPu.SqlValue = id;
            idPu.Direction = ParameterDirection.Input;
            obtenerPublicacion.Parameters.Add(idPu);
            dataReader = obtenerPublicacion.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[0].Equals(DBNull.Value)) { Descripcion.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { Precio.Text = Convert.ToString(dataReader.GetDecimal(1)); }
                if (!dataReader[2].Equals(DBNull.Value)) { Stock.Text = Convert.ToString(dataReader.GetInt32(2)); }
                if (!dataReader[3].Equals(DBNull.Value)) { Visibilidad.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { Tipo_de_Publicacion.Text = dataReader.GetString(4); }
                if (!dataReader[5].Equals(DBNull.Value)) { Rubro.Text = dataReader.GetString(5); }
                if (!dataReader[6].Equals(DBNull.Value)) { preguntas = dataReader.GetInt32(6); }
                if (!dataReader[7].Equals(DBNull.Value)) { envio = dataReader.GetInt32(7); }
            }

            if (preguntas.Equals(0))
            {
                habilitarPreguntas.Checked = true;
            }

            if(envio.Equals(0))
            {
                habilitarEnvios.Checked = true;
            }

            if (Rubro.SelectedIndex.Equals(-1))
            {
                Rubro.SelectedIndex = 0;
            }

            if (Tipo_de_Publicacion.SelectedIndex.Equals(-1))
            {
                Tipo_de_Publicacion.SelectedIndex = 0;
            }

            if (Visibilidad.SelectedIndex.Equals(-1))
            {
                Visibilidad.SelectedIndex = 0;
            }

            dataReader.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            funcion.validarComboVacio(Visibilidad, mensajeValidacion);
            funcion.validarComboVacio(Tipo_de_Publicacion, mensajeValidacion);
            funcion.validarComboVacio(Rubro, mensajeValidacion);
            funcion.validarNoVacio(Descripcion, mensajeValidacion);
            funcion.validarNoVacio(Precio, mensajeValidacion);
            funcion.validarDecimal(Precio, mensajeValidacion);
            funcion.validarNumerico(Stock, mensajeValidacion);
            funcion.validarNoVacio(Stock, mensajeValidacion);


            bool validaciones;

            if (mensajeValidacion.Length > 0)
            {
                validaciones = false;
                MessageBox.Show(mensajeValidacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeValidacion = new StringBuilder();

            }
            else
            {validaciones = true;}

            if (validaciones)
            {
                SqlCommand actualizarPublicacion = new SqlCommand("ADIOS_TERCER_ANIO.EditarPublicacion", conn.getConexion);
                actualizarPublicacion.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter descripcionP = new SqlParameter("@descripcion", SqlDbType.NVarChar, 255);
                descripcionP.SqlValue = Descripcion.Text;
                descripcionP.Direction = ParameterDirection.Input;

                SqlParameter precioP = new SqlParameter("@precio", SqlDbType.Decimal);
                precioP.SqlValue = Convert.ToDecimal(Precio.Text);
                precioP.Direction = ParameterDirection.Input;

                SqlParameter stockP = new SqlParameter("@stock", SqlDbType.Int);
                stockP.SqlValue = Convert.ToInt32(Stock.Value);
                stockP.Direction = ParameterDirection.Input;

                SqlParameter visibilidadP = new SqlParameter("@visibilidad", SqlDbType.NVarChar, 255);
                visibilidadP.SqlValue = Visibilidad.Text;
                visibilidadP.Direction = ParameterDirection.Input;

                SqlParameter tipoDePublicacionP = new SqlParameter("@tipo", SqlDbType.NVarChar, 255);
                tipoDePublicacionP.SqlValue = Tipo_de_Publicacion.Text;
                tipoDePublicacionP.Direction = ParameterDirection.Input;

                SqlParameter rubro = new SqlParameter("@rubro", SqlDbType.NVarChar, 255);
                rubro.SqlValue = Rubro.Text;
                rubro.Direction = ParameterDirection.Input;

                SqlParameter habilitaPreguntas = new SqlParameter("@tienePreguntas", SqlDbType.Int);
                if (habilitarEnvios.Checked)
                {
                    habilitaPreguntas.SqlValue = 0;
                }
                else
                {
                    habilitaPreguntas.SqlValue = 1;
                }
                habilitaPreguntas.Direction = ParameterDirection.Input;

                SqlParameter fechaInicio = new SqlParameter("@fechaInicio", SqlDbType.DateTime);
                fechaInicio.SqlValue = DBNull.Value;
                fechaInicio.Direction = ParameterDirection.Input;

                SqlParameter fechaFin = new SqlParameter("@fechaFin", SqlDbType.DateTime);
                fechaFin.SqlValue = DBNull.Value;
                fechaFin.Direction = ParameterDirection.Input;

                SqlParameter estadoP = new SqlParameter("@estado", SqlDbType.NVarChar, 255);
                estadoP.SqlValue = "Borrador";
                estadoP.Direction = ParameterDirection.Input;

                SqlParameter idP = new SqlParameter("@idPublicacion", SqlDbType.Int);
                idP.SqlValue = idPublicacion;
                idP.Direction = ParameterDirection.Input;

                SqlParameter envio = new SqlParameter("@envio", SqlDbType.Int);

                if (habilitarEnvios.Checked)
                {
                    envio.SqlValue = 0;
                }
                else
                {
                    envio.SqlValue = 1;
                }
                envio.Direction = ParameterDirection.Input;


                actualizarPublicacion.Parameters.Add(descripcionP);

                actualizarPublicacion.Parameters.Add(precioP);
                actualizarPublicacion.Parameters.Add(stockP);
                actualizarPublicacion.Parameters.Add(visibilidadP);
                actualizarPublicacion.Parameters.Add(tipoDePublicacionP);
                actualizarPublicacion.Parameters.Add(rubro);
                actualizarPublicacion.Parameters.Add(habilitaPreguntas);
                actualizarPublicacion.Parameters.Add(fechaInicio);
                actualizarPublicacion.Parameters.Add(fechaFin);
                actualizarPublicacion.Parameters.Add(estadoP);
                actualizarPublicacion.Parameters.Add(idP);
                actualizarPublicacion.Parameters.Add(envio);
                actualizarPublicacion.ExecuteNonQuery();

                new frmModificarPublicacion().Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmModificarPublicacion().Show();
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            new frmDatosVisibilidad(Visibilidad.SelectedIndex + 1).Show();
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcion.ingresarNumeroDecimal(e);
        }
    }
}
