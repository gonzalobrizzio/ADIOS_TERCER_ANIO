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

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmModificarEmpresa : Form
    {
        Conexion conn;
        int idUsuario;
        Sesion sesion = Sesion.Instance;
        Form anterior;
        StringBuilder mensajeDeAviso = new StringBuilder();
        private Utilidades funcionesValidacion = new Utilidades();

        public frmModificarEmpresa(int id)
        {
            InitializeComponent();

            anterior = sesion.anterior;

            idUsuario = id;
            campoMail.MaxLength = 30;
            campoUsuario.MaxLength = 20;
            campoDireccion.MaxLength = 5;
            campoCiudad.MaxLength = 15;
            campoCodigoPostal.MaxLength = 4;
            campoCalle.MaxLength = 20;
            campoCUIT.MaxLength = 13;
            campoDepto.MaxLength = 3;
            campoNombreDeContacto.MaxLength = 30;
            campoTelefono.MaxLength = 11;
            campoPiso.MaxLength = 3;
            campoRazonSocial.MaxLength = 50;

            conn = Conexion.Instance;
            string queryRubros = "SELECT DISTINCT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro";
            SqlCommand buscarRubros = new SqlCommand(queryRubros, conn.getConexion);
            SqlDataReader dataReader = buscarRubros.ExecuteReader();
            while (dataReader.Read())
            {
                comboRubro.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();

            string queryLocalidades = "SELECT DISTINCT nombre FROM ADIOS_TERCER_ANIO.Localidad";
            SqlCommand buscarLocalidades = new SqlCommand(queryLocalidades, conn.getConexion);
            dataReader = buscarLocalidades.ExecuteReader();
            while (dataReader.Read())
            {
                comboLocalidad.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();

            string sacarDatosDeUsuario = "SELECT * FROM ADIOS_TERCER_ANIO.Usuario WHERE id = @id";
            SqlCommand obtenerUsuario = new SqlCommand(sacarDatosDeUsuario, conn.getConexion);
            SqlParameter idU = new SqlParameter("@id", SqlDbType.Int);
            idU.SqlValue = idUsuario;
            idU.Direction = ParameterDirection.Input;
            obtenerUsuario.Parameters.Add(idU);
            dataReader = obtenerUsuario.ExecuteReader();
            dataReader.Read();

            campoContrasenia.Text = dataReader.GetString(2);
            campoUsuario.Text = dataReader.GetString(1);
            campoMail.Text = dataReader.GetString(3);

            dataReader.Close();

            string sacarDatosDeEmpresa = "SELECT e.codigoPostal, e.contacto, e.cuit, e.direccion, e.direccion_numero, e.dpto, (SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad where id = e.idLocalidad) AS Localidad, (SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro WHERE id = e.idRubro) AS Rubro, e.piso, e.razonSocial, e.telefono FROM ADIOS_TERCER_ANIO.Usuario u inner join ADIOS_TERCER_ANIO.Empresa e on u.id = e.idUsuario WHERE @id = u.id";
            SqlCommand obtenerEmpresa = new SqlCommand(sacarDatosDeEmpresa, conn.getConexion);
            SqlParameter idUsuariof = new SqlParameter("@id", SqlDbType.Int);
            idUsuariof.SqlValue = idUsuario;
            idUsuariof.Direction = ParameterDirection.Input;
            obtenerEmpresa.Parameters.Add(idUsuariof);
            dataReader = obtenerEmpresa.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[0].Equals(DBNull.Value)) { campoCodigoPostal.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { campoNombreDeContacto.Text = dataReader.GetString(1); }
                if (!dataReader[2].Equals(DBNull.Value)) { campoCUIT.Text = dataReader.GetString(2); }
                if (!dataReader[3].Equals(DBNull.Value)) { campoCalle.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { campoDireccion.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { campoDepto.Text = dataReader.GetString(5); }
                if (!dataReader[6].Equals(DBNull.Value)) { comboLocalidad.Text = dataReader.GetString(6); }
                if (!dataReader[7].Equals(DBNull.Value)) { comboRubro.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { campoPiso.Text = Convert.ToString(dataReader.GetDecimal(8)); }
                if (!dataReader[9].Equals(DBNull.Value)) { campoRazonSocial.Text = dataReader.GetString(9); }
                if (!dataReader[10].Equals(DBNull.Value)) { campoTelefono.Text = dataReader.GetString(10); }
            }
            dataReader.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.funcionesValidacion.validarNoVacio(campoUsuario, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoContrasenia, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoMail, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoRazonSocial, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoCUIT, mensajeDeAviso);
          
            if (!(string.IsNullOrEmpty(campoDireccion.Text)))
            {
                this.funcionesValidacion.validarNumerico(campoDireccion, mensajeDeAviso);
            }

            if (!(string.IsNullOrEmpty(campoPiso.Text)))
            {
                this.funcionesValidacion.validarNumerico(campoPiso, mensajeDeAviso);
            }

            bool validaciones;

            if (mensajeDeAviso.Length > 0)
            {
                validaciones = false;
                MessageBox.Show(mensajeDeAviso.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeDeAviso = new StringBuilder();

            }
            else
            { validaciones = true; }

            if (validaciones)
            {
                SqlCommand modificarEmpresa = new SqlCommand("ADIOS_TERCER_ANIO.ModificarEmpresa", conn.getConexion);
                modificarEmpresa.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand modificarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.ModificarUsuario", conn.getConexion);
                modificarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
                usuario.SqlValue = campoUsuario.Text;
                usuario.Direction = ParameterDirection.Input;

                SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
                password.SqlValue = Utilidades.encriptarCadenaSHA256(campoContrasenia.Text);
                password.Direction = ParameterDirection.Input;

                SqlParameter idUf = new SqlParameter("@id", SqlDbType.Int);
                idUf.SqlValue = idUsuario;
                idUf.Direction = ParameterDirection.Input;

                SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
                mail.SqlValue = campoMail.Text;
                mail.Direction = ParameterDirection.Input;

                modificarUsuario.Parameters.Add(usuario);
                modificarUsuario.Parameters.Add(password);
                modificarUsuario.Parameters.Add(idUf);
                modificarUsuario.Parameters.Add(mail);
                try{
                modificarUsuario.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                SqlParameter razonSocial = new SqlParameter("@razonSocial", SqlDbType.NVarChar,50);
                razonSocial.SqlValue = campoRazonSocial.Text;
                razonSocial.Direction = ParameterDirection.Input;

                SqlParameter idEmpresa = new SqlParameter("@id", SqlDbType.Int);
                idEmpresa.SqlValue = idUsuario;
                idEmpresa.Direction = ParameterDirection.Input;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 20);
                telefono.SqlValue = campoTelefono.Text;
                telefono.Direction = ParameterDirection.Input;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Decimal);

                if (string.IsNullOrEmpty(campoDireccion.Text))
                {
                    direccion.SqlValue = DBNull.Value;
                }
                else
                {
                    direccion.SqlValue = Convert.ToDecimal(campoDireccion.Text);
                }

                SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 50);
                calle.SqlValue = campoCalle.Text;
                calle.Direction = ParameterDirection.Input;

                SqlParameter piso = new SqlParameter("@piso" , SqlDbType.Decimal);
                if (string.IsNullOrEmpty(campoPiso.Text))
                {
                    piso.SqlValue = DBNull.Value;
                }
                else
                {
                    piso.SqlValue = Convert.ToDecimal(campoPiso.Text);
                }

                SqlParameter depto = new SqlParameter("@depto", SqlDbType.NVarChar, 50);
                depto.SqlValue = campoDepto.Text;
                depto.Direction = ParameterDirection.Input;

                SqlParameter localidad = new SqlParameter("@localidad", SqlDbType.NVarChar,255);
                localidad.SqlValue = comboLocalidad.Text;
                localidad.Direction = ParameterDirection.Input;

                SqlParameter codigoPostal = new SqlParameter("@codigoPostal", SqlDbType.NVarChar,50);
                codigoPostal.SqlValue = campoCodigoPostal.Text;
                codigoPostal.Direction = ParameterDirection.Input;

                SqlParameter ciudad = new SqlParameter("@ciudad", SqlDbType.NVarChar, 255);
                ciudad.SqlValue = campoCiudad.Text;
                ciudad.Direction = ParameterDirection.Input;

                SqlParameter cuit = new SqlParameter("@cuit", SqlDbType.NVarChar, 50);
                cuit.SqlValue = campoCUIT.Text;
                cuit.Direction = ParameterDirection.Input;

                SqlParameter contacto = new SqlParameter("@contacto", SqlDbType.NVarChar, 45);
                contacto.SqlValue = campoNombreDeContacto.Text;
                contacto.Direction = ParameterDirection.Input;

                SqlParameter rubro = new SqlParameter("@rubro", SqlDbType.NVarChar, 255);
                rubro.SqlValue = comboRubro.Text;
                rubro.Direction = ParameterDirection.Input;

                modificarEmpresa.Parameters.Add(razonSocial);
                modificarEmpresa.Parameters.Add(idEmpresa);
                modificarEmpresa.Parameters.Add(telefono);
                modificarEmpresa.Parameters.Add(direccion);
                modificarEmpresa.Parameters.Add(calle);
                modificarEmpresa.Parameters.Add(piso);
                modificarEmpresa.Parameters.Add(depto);
                modificarEmpresa.Parameters.Add(localidad);
                modificarEmpresa.Parameters.Add(codigoPostal);
                modificarEmpresa.Parameters.Add(ciudad);
                modificarEmpresa.Parameters.Add(cuit);
                modificarEmpresa.Parameters.Add(contacto);
                modificarEmpresa.Parameters.Add(rubro);
                try
                {
                    modificarEmpresa.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                new frmABMUsuario().Show();
                this.Close();
            }
        }
    }
}
