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

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmNuevoCliente : Form
    {
        SqlDataReader dataReader;
        Conexion conn;
        string rolU;
        StringBuilder mensajeDeAviso = new StringBuilder();
        private Utilidades funcionesValidacion = new Utilidades();

        public frmNuevoCliente(string rol)
        {
            InitializeComponent();
            conn = Conexion.Instance;
            rolU = rol;

            Mail.MaxLength = 30;
            Usuario.MaxLength = 20;
            Contrasenia.MaxLength = 20;
            Nro_de_Documento.MaxLength = 8;
            Direccion.MaxLength = 30;
            Codigo_Postal.MaxLength = 4;
            Nro_de_Direccion.MaxLength = 5;
            Depto.MaxLength = 3;
            Telefono.MaxLength = 11;
            Piso.MaxLength = 3;

            string queryTiposDeDoc = "SELECT DISTINCT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento";
            SqlCommand buscarTiposDeDoc = new SqlCommand(queryTiposDeDoc, conn.getConexion);
            dataReader = buscarTiposDeDoc.ExecuteReader();
            while (dataReader.Read())
            {
                Tipo_de_Documento.Items.Add(dataReader.GetString(0));
            }
            Tipo_de_Documento.SelectedIndex = 0;
            dataReader.Close();

            string queryLocalidades = "SELECT DISTINCT nombre FROM ADIOS_TERCER_ANIO.Localidad";
            SqlCommand buscarLocalidades = new SqlCommand(queryLocalidades, conn.getConexion);
            dataReader = buscarLocalidades.ExecuteReader();
            while (dataReader.Read())
            {
                Localidad.Items.Add(dataReader.GetString(0));
            }
            Localidad.SelectedIndex = 0;
            Fecha_de_Nacimiento.Enabled = false;
            dataReader.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            bool usuarioB = this.funcionesValidacion.validarNoVacio(Usuario, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Contrasenia, mensajeDeAviso);
            bool mailB = this.funcionesValidacion.validarNoVacio(Mail, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Nombre, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Apellido, mensajeDeAviso);
            bool dniB = this.funcionesValidacion.validarNoVacio(Nro_de_Documento, mensajeDeAviso);
            this.funcionesValidacion.validarNumerico(Nro_de_Documento, mensajeDeAviso);
            bool tipoB = this.funcionesValidacion.validarComboVacio(Tipo_de_Documento, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Direccion, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Codigo_Postal, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Fecha_de_Nacimiento, mensajeDeAviso);
            
            bool validaciones;

            if (usuarioB)
            {
                this.funcionesValidacion.validarUsuario(Usuario, mensajeDeAviso);
            }

            if(dniB && tipoB) 
            {
                this.funcionesValidacion.validarDNI(Tipo_de_Documento.Text,Nro_de_Documento,mensajeDeAviso);
            }

            if (mailB)
            {
                this.funcionesValidacion.validarEmail(Mail, mensajeDeAviso);
            }

            if (!(string.IsNullOrEmpty(Nro_de_Direccion.Text)))
            {
                this.funcionesValidacion.validarNumerico(Nro_de_Direccion, mensajeDeAviso);
            }

            if (!(string.IsNullOrEmpty(Piso.Text)))
            {
                this.funcionesValidacion.validarNumerico(Piso, mensajeDeAviso);
            }

            if (mensajeDeAviso.Length > 0)
            {
                validaciones = false;
                MessageBox.Show(mensajeDeAviso.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeDeAviso = new StringBuilder();

            }
            else
            {validaciones = true;}

            if (validaciones)
            {
                SqlCommand agregarCliente = new SqlCommand("ADIOS_TERCER_ANIO.AgregarPersona", conn.getConexion);
                agregarCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand agregarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.AgregarUsuario", conn.getConexion);
                agregarUsuario.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand agregarRolUsuario = new SqlCommand("ADIOS_TERCER_ANIO.AgregarRolUsuario", conn.getConexion);
                agregarRolUsuario.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
                usuario.SqlValue = Usuario.Text;
                usuario.Direction = ParameterDirection.Input;

                SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
                password.SqlValue = Utilidades.encriptarCadenaSHA256(Contrasenia.Text);
                password.Direction = ParameterDirection.Input;

                SqlParameter idUsuario = new SqlParameter("@ultimoID", null);
                idUsuario.Direction = ParameterDirection.Output;
                idUsuario.SqlDbType = SqlDbType.Int;

                SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
                mail.SqlValue = Mail.Text;
                mail.Direction = ParameterDirection.Input;

                agregarUsuario.Parameters.Add(usuario);
                agregarUsuario.Parameters.Add(password);
                agregarUsuario.Parameters.Add(idUsuario);
                agregarUsuario.Parameters.Add(mail);

                try{
                agregarUsuario.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                int ultimoIdRol = Convert.ToInt32(agregarUsuario.Parameters["@ultimoID"].Value);

                SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                id.SqlValue = ultimoIdRol;
                id.Direction = ParameterDirection.Input;

                SqlParameter rol = new SqlParameter("@rol", SqlDbType.NVarChar, 255);
                rol.SqlValue = rolU;
                rol.Direction = ParameterDirection.Input;

                agregarRolUsuario.Parameters.Add(rol);
                agregarRolUsuario.Parameters.Add(id);

                try{
                agregarRolUsuario.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                nombre.SqlValue = Nombre.Text;
                nombre.Direction = ParameterDirection.Input;

                SqlParameter apellido = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
                apellido.SqlValue = Apellido.Text;
                apellido.Direction = ParameterDirection.Input;

                SqlParameter dni = new SqlParameter("@documento", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(Nro_de_Documento.Text))
                {
                    dni.SqlValue = DBNull.Value;
                }
                else
                {
                    dni.SqlValue = Convert.ToDecimal(Nro_de_Documento.Text);
                }
                dni.Direction = ParameterDirection.Input;

                SqlParameter tipoDoc = new SqlParameter("@tipoDeDocumento", SqlDbType.NVarChar, 255);
                tipoDoc.SqlValue = (Tipo_de_Documento.Text);
                tipoDoc.Direction = ParameterDirection.Input;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
                telefono.SqlValue = Telefono.Text;
                telefono.Direction = ParameterDirection.Input;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(Nro_de_Direccion.Text))
                {
                    direccion.SqlValue = DBNull.Value;
                }

                else
                {
                    direccion.SqlValue = Convert.ToDecimal(Nro_de_Direccion.Text);
                }
                direccion.Direction = ParameterDirection.Input;

                SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
                calle.SqlValue = Direccion.Text;
                calle.Direction = ParameterDirection.Input;

                SqlParameter piso = new SqlParameter("@piso", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(Piso.Text))
                {
                    piso.SqlValue = DBNull.Value;
                }
                else
                {
                    piso.SqlValue = Convert.ToDecimal(Piso.Text);
                }
                piso.Direction = ParameterDirection.Input;

                SqlParameter depto = new SqlParameter("@depto", SqlDbType.NVarChar, 255);
                depto.SqlValue = Depto.Text;
                depto.Direction = ParameterDirection.Input;

                SqlParameter localidad = new SqlParameter("@localidad", SqlDbType.NVarChar, 255);
                localidad.SqlValue = Localidad.SelectedText;
                localidad.Direction = ParameterDirection.Input;

                SqlParameter codigoPostal = new SqlParameter("@codigoPostal", SqlDbType.NVarChar, 255);
                codigoPostal.SqlValue = Codigo_Postal.Text;
                codigoPostal.Direction = ParameterDirection.Input;

                SqlParameter fechaNac = new SqlParameter("@fechaNac", SqlDbType.DateTime);
                fechaNac.SqlValue = DateTime.Parse(Fecha_de_Nacimiento.Text);
                fechaNac.Direction = ParameterDirection.Input;

                SqlParameter otroid = new SqlParameter("@id", SqlDbType.Int);
                otroid.SqlValue = ultimoIdRol;
                otroid.Direction = ParameterDirection.Input;

                SqlParameter fechaCreacion = new SqlParameter("@fechaCreacion", SqlDbType.DateTime);
                fechaCreacion.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                fechaCreacion.Direction = ParameterDirection.Input;

                agregarCliente.Parameters.Add(otroid);
                agregarCliente.Parameters.Add(dni);
                agregarCliente.Parameters.Add(tipoDoc);
                agregarCliente.Parameters.Add(nombre);
                agregarCliente.Parameters.Add(apellido);
                agregarCliente.Parameters.Add(telefono);
                agregarCliente.Parameters.Add(direccion);
                agregarCliente.Parameters.Add(calle);
                agregarCliente.Parameters.Add(piso);
                agregarCliente.Parameters.Add(depto);
                agregarCliente.Parameters.Add(localidad);
                agregarCliente.Parameters.Add(codigoPostal);
                agregarCliente.Parameters.Add(fechaNac);
                agregarCliente.Parameters.Add(fechaCreacion);

                try{
                agregarCliente.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                new frmABMUsuario().Show();
                this.Close();
            }
        }


        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            Fecha_de_Nacimiento.Clear();
            Fecha_de_Nacimiento.AppendText(calendarioNac.SelectionStart.ToShortDateString());

        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarMail(e);
        }

        private void Nro_de_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Nro_de_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Codigo_Postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void frmNuevoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

            new frmABMUsuario().Show();
            this.Close();
        }

    }
}
