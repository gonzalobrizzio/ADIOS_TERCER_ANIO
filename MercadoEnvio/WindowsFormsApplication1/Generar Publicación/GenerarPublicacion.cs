using MercadoEnvios.ABM_Usuario;
using MercadoEnvios.Generar_Publicacion;
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

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmGenerarPublicacion : Form
    {
        Conexion conn;
        Sesion sesion;
        Utilidades funcion = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();
        public frmGenerarPublicacion()
        {
            InitializeComponent();
            habilitarEnvios.Visible = false;
            sesion = Sesion.Instance;
            this.conn = Conexion.Instance;
            this.loadGrid();
            Tipo_de_Publicacion.SelectedIndex = 0;
        }

        private void loadGrid()
        {
            string rubrosDisponibles = "SELECT r.descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro r";
            conn = Conexion.Instance;
            SqlCommand buscarRubrosDisponibles = new SqlCommand(rubrosDisponibles, conn.getConexion);
            SqlDataReader dabuscarRubrosDisponibles = buscarRubrosDisponibles.ExecuteReader();

            while (dabuscarRubrosDisponibles.Read())
            {
                Rubro.Items.Add(dabuscarRubrosDisponibles.GetString(0));
            }
            Rubro.SelectedIndex = 0;
            dabuscarRubrosDisponibles.Close();

            string queryVisibilidad = "SELECT nombre FROM ADIOS_TERCER_ANIO.Visibilidad where deleted = 0";
            SqlCommand buscarVisibilidades = new SqlCommand(queryVisibilidad, conn.getConexion);
            SqlDataReader dataReader = buscarVisibilidades.ExecuteReader();
            while (dataReader.Read())
            {
                Visibilidad.Items.Add(dataReader.GetString(0));
            }
            Visibilidad.SelectedIndex = 0;
            dataReader.Close();


            string queryTipoDePublicacion = "SELECT nombre FROM ADIOS_TERCER_ANIO.TipoPublicacion";
            SqlCommand buscarTiposDePublicaciones = new SqlCommand(queryTipoDePublicacion, conn.getConexion);
            SqlDataReader daBuscarTiposDePublicacion = buscarTiposDePublicaciones.ExecuteReader();
            while (daBuscarTiposDePublicacion.Read())
            {
                Tipo_de_Publicacion.Items.Add(daBuscarTiposDePublicacion.GetString(0));
            }
            daBuscarTiposDePublicacion.Close();

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
                SqlCommand generarPublicacion = new SqlCommand("ADIOS_TERCER_ANIO.AgregarPublicacion", conn.getConexion);
                generarPublicacion.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter descripcionP = new SqlParameter("@descripcion", SqlDbType.NVarChar, 255);
                descripcionP.SqlValue = Descripcion.Text;
                descripcionP.Direction = ParameterDirection.Input;

                SqlParameter precioP = new SqlParameter("@precio", SqlDbType.Decimal);
                if(string.IsNullOrEmpty(Precio.Text)){
                    precioP.SqlValue = DBNull.Value;
                }
                else{
                    precioP.SqlValue = Convert.ToDecimal(Precio.Text);
                }
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
                if (habilitarPreguntas.Checked)
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

                SqlParameter idP = new SqlParameter("@idPublicador", SqlDbType.Int);
                idP.SqlValue = sesion.idUsuario;
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

                String queryHabilitados = "SELECT * FROM ADIOS_TERCER_ANIO.Publicacion where idPublicador = @idUser";
                SqlCommand buscarPublicaciones = new SqlCommand(queryHabilitados, conn.getConexion);
                SqlParameter idUser = new SqlParameter("@idUser", SqlDbType.Int);
                idUser.SqlValue = sesion.idUsuario;
                idUser.Direction = ParameterDirection.Input;
                buscarPublicaciones.Parameters.Add(idUser);
                SqlParameter primerPublicacion = new SqlParameter("@primerPublicacion", SqlDbType.Int);
                SqlDataReader da = buscarPublicaciones.ExecuteReader();
                if (da.HasRows)
                {
                    primerPublicacion.SqlValue = 1;
                }
                else
                {
                    primerPublicacion.SqlValue = 0;
                }
                
                primerPublicacion.Direction = ParameterDirection.Input;
                da.Close();

                generarPublicacion.Parameters.Add(descripcionP);
                generarPublicacion.Parameters.Add(primerPublicacion);
                generarPublicacion.Parameters.Add(precioP);
                generarPublicacion.Parameters.Add(stockP);
                generarPublicacion.Parameters.Add(visibilidadP);
                generarPublicacion.Parameters.Add(tipoDePublicacionP);
                generarPublicacion.Parameters.Add(rubro);
                generarPublicacion.Parameters.Add(habilitaPreguntas);
                generarPublicacion.Parameters.Add(fechaInicio);
                generarPublicacion.Parameters.Add(fechaFin);
                generarPublicacion.Parameters.Add(estadoP);
                generarPublicacion.Parameters.Add(idP);
                generarPublicacion.Parameters.Add(envio);
                generarPublicacion.ExecuteNonQuery();
                MessageBox.Show("Recuerde entrar a Modificar Publicacion para Activar su publicación!", "Bien Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmElegirAccion().Show();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmElegirAccion().Show();
            this.Close();
        }

        private void tipoDePublicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoPubli = "SELECT @tieneEnvio = envioDisponible FROM ADIOS_TERCER_ANIO.TipoPublicacion tp where nombre like @nombreTipo";
            SqlCommand verSitieneEnvio = new SqlCommand(tipoPubli, conn.getConexion);
            SqlParameter nombreTipo = new SqlParameter("@nombreTipo", SqlDbType.NVarChar, 255);
            nombreTipo.Direction = ParameterDirection.Input;
            nombreTipo.SqlValue = Tipo_de_Publicacion.Text;
            SqlParameter tieneEnvio = new SqlParameter("@tieneEnvio", SqlDbType.Int);
            tieneEnvio.Direction = ParameterDirection.Output;

            verSitieneEnvio.Parameters.Add(nombreTipo);
            verSitieneEnvio.Parameters.Add(tieneEnvio);
            verSitieneEnvio.ExecuteNonQuery();
            if((Convert.ToInt32(verSitieneEnvio.Parameters["@tieneEnvio"].Value) == 0) && !habilitarEnvios.Visible){
                habilitarEnvios.Visible = true;
            }
            if ((Convert.ToInt32(verSitieneEnvio.Parameters["@tieneEnvio"].Value) == 1) && habilitarEnvios.Visible)
            {
                habilitarEnvios.Visible = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            new frmDatosVisibilidad(Visibilidad.SelectedIndex + 1).Show();
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcion.ingresarNumeroDecimal(e);
        }

        private void frmGenerarPublicacion_FormClosed(object sender, FormClosedEventArgs e)
        {

            new frmElegirAccion().Show();
            this.Close();
        }
    }


}
