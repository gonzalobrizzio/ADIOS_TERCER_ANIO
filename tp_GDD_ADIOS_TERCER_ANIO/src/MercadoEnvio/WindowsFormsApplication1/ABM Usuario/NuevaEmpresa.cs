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
    public partial class frmNuevaEmpresa : Form
    {
        Conexion conn;
        string rolU;
        StringBuilder mensajeDeAviso = new StringBuilder();
        private Utilidades funcionesValidacion = new Utilidades();
        bool errorSql = false;

        public frmNuevaEmpresa(string rol)
        {
            InitializeComponent();
            Mail.MaxLength = 30;
            Usuario.MaxLength = 20;
            Contrasenia.MaxLength = 20;
            Direccion.MaxLength = 5;
            Ciudad.MaxLength = 15;
            Codigo_Postal.MaxLength = 4;
            Calle.MaxLength = 20;
            CUIT.MaxLength = 13;
            Depto.MaxLength = 3;
            Nombre_de_Contacto.MaxLength = 30;
            Telefono.MaxLength = 11;
            Piso.MaxLength = 3;
            Razon_Social.MaxLength = 50;

            conn = Conexion.Instance;
            rolU = rol;
            string queryRubros = "SELECT DISTINCT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro";
            SqlCommand buscarRubros = new SqlCommand(queryRubros, conn.getConexion);
            SqlDataReader dataReader = buscarRubros.ExecuteReader();
            while (dataReader.Read())
            {
                Rubro.Items.Add(dataReader.GetString(0));
            }
            Rubro.SelectedIndex = 0;
            dataReader.Close();

            string queryLocalidades = "SELECT DISTINCT nombre FROM ADIOS_TERCER_ANIO.Localidad";
            SqlCommand buscarLocalidades = new SqlCommand(queryLocalidades, conn.getConexion);
            dataReader = buscarLocalidades.ExecuteReader();
            while (dataReader.Read())
            {
                Localidad.Items.Add(dataReader.GetString(0));
            }
            Localidad.SelectedIndex = 0;
            dataReader.Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool usuarioB = this.funcionesValidacion.validarNoVacio(Usuario, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Contrasenia, mensajeDeAviso);
            bool mailB = this.funcionesValidacion.validarNoVacio(Mail, mensajeDeAviso);
            bool razonSocialB = this.funcionesValidacion.validarNoVacio(Razon_Social, mensajeDeAviso);
            bool cuitB = this.funcionesValidacion.validarNoVacio(CUIT, mensajeDeAviso);
            this.funcionesValidacion.verSiElCuitEsValido(CUIT, mensajeDeAviso);

            if (!(string.IsNullOrEmpty(Direccion.Text)))
            {
                this.funcionesValidacion.validarNumerico(Direccion, mensajeDeAviso);
            }

            if (!(string.IsNullOrEmpty(Piso.Text)))
            {
                this.funcionesValidacion.validarNumerico(Piso, mensajeDeAviso);
            }

            bool validaciones;

            if (cuitB)
            {
                this.funcionesValidacion.validarCUIT(CUIT, mensajeDeAviso);
            }

            if (razonSocialB)
            {
                this.funcionesValidacion.validarRazonSocial(Razon_Social, mensajeDeAviso);
            }

            if (usuarioB)
            {
                this.funcionesValidacion.validarUsuario(Usuario, mensajeDeAviso);
            }

            if (mailB)
            {
                this.funcionesValidacion.validarEmail(Mail, mensajeDeAviso);
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
                SqlCommand agregarEmpresa = new SqlCommand("ADIOS_TERCER_ANIO.AgregarEmpresa", conn.getConexion);
                agregarEmpresa.CommandType = System.Data.CommandType.StoredProcedure;
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
                
                SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                id.Direction = ParameterDirection.Input;

                SqlParameter rol = new SqlParameter("@rol", SqlDbType.NVarChar, 255);
                rol.SqlValue = rolU;
                rol.Direction = ParameterDirection.Input;

                agregarRolUsuario.Parameters.Add(rol);
                agregarRolUsuario.Parameters.Add(id);
                
                try{
                    agregarUsuario.ExecuteNonQuery();
                    id.SqlValue = Convert.ToInt32(agregarUsuario.Parameters["@ultimoID"].Value);
                    agregarRolUsuario.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                    this.Show();
                }

                SqlParameter razonSocial = new SqlParameter("@razonSocial", SqlDbType.NVarChar, 255);
                razonSocial.SqlValue = Razon_Social.Text;
                razonSocial.Direction = ParameterDirection.Input;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
                telefono.SqlValue = Telefono.Text;
                telefono.Direction = ParameterDirection.Input;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Decimal);

                if (!(Direccion.Text == ""))
                {
                    direccion.SqlValue = Convert.ToDecimal(Direccion.Text);
                }
                else { direccion.SqlValue = DBNull.Value; }
                direccion.Direction = ParameterDirection.Input;

                SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
                calle.SqlValue = Calle.Text;
                calle.Direction = ParameterDirection.Input;

                SqlParameter piso = new SqlParameter("@piso", SqlDbType.Decimal);
                if (!(Piso.Text == ""))
                {
                    piso.SqlValue = Convert.ToDecimal(Piso.Text);
                }
                else { piso.SqlValue = DBNull.Value; }
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

                SqlParameter ciudad = new SqlParameter("@ciudad", SqlDbType.NVarChar, 255);
                ciudad.SqlValue = Ciudad.Text;
                ciudad.Direction = ParameterDirection.Input;

                SqlParameter cuit = new SqlParameter("@cuit", SqlDbType.NVarChar, 255);
                cuit.SqlValue = CUIT.Text;
                cuit.Direction = ParameterDirection.Input;

                SqlParameter contacto = new SqlParameter("@contacto", SqlDbType.NVarChar, 255);
                contacto.SqlValue = Nombre_de_Contacto.Text;
                contacto.Direction = ParameterDirection.Input;

                SqlParameter rubro = new SqlParameter("@rubro", SqlDbType.NVarChar, 255);
                rubro.SqlValue = Rubro.SelectedText;
                rubro.Direction = ParameterDirection.Input;

                SqlParameter otroId = new SqlParameter("@id", SqlDbType.Int);
                otroId.Direction = ParameterDirection.Input;
                otroId.SqlValue = Convert.ToInt32(agregarUsuario.Parameters["@ultimoID"].Value);


                SqlParameter fechaCreacion = new SqlParameter("@fechaCreacion", SqlDbType.DateTime);
                fechaCreacion.SqlValue = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
                fechaCreacion.Direction = ParameterDirection.Input;

                agregarEmpresa.Parameters.Add(razonSocial);
                agregarEmpresa.Parameters.Add(otroId);
                agregarEmpresa.Parameters.Add(telefono);
                agregarEmpresa.Parameters.Add(direccion);
                agregarEmpresa.Parameters.Add(calle);
                agregarEmpresa.Parameters.Add(piso);
                agregarEmpresa.Parameters.Add(depto);
                agregarEmpresa.Parameters.Add(localidad);
                agregarEmpresa.Parameters.Add(codigoPostal);
                agregarEmpresa.Parameters.Add(ciudad);
                agregarEmpresa.Parameters.Add(cuit);
                agregarEmpresa.Parameters.Add(contacto);
                agregarEmpresa.Parameters.Add(rubro);
                agregarEmpresa.Parameters.Add(fechaCreacion);

                try{
                agregarEmpresa.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                    errorSql = true;
                }

                if (!errorSql)
                {

                    new frmABMUsuario().Show();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            new frmABMUsuario().Show();
            this.Close();
        }

        private void salir(){
            return;
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Codigo_Postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumeroConRaya(e);
        }

        private void Piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarMail(e);
        }

        private void Telefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Depto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Nombre_de_Contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }
    }
}
