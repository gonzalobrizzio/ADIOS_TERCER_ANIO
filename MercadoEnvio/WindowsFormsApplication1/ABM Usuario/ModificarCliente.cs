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
    public partial class frmModificarCliente : Form
    {
        SqlDataReader dataReader;
        Conexion conn;
        StringBuilder mensajeDeAviso = new StringBuilder();
        private Utilidades funcionesValidacion = new Utilidades();

        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmModificarCliente(int id)
        {
            InitializeComponent();
            anterior = sesion.anterior;

            sesion.idUsuario = id;


            sesion.idUsuario = id;
            conn = Conexion.Instance;

            campoMail.MaxLength = 30;
            campoUsuario.MaxLength = 20;
            Contraseña.MaxLength = 20;
            campoDni.MaxLength = 8;
            campoDireccion.MaxLength = 50;
            campoCódigoPostal.MaxLength = 4;
            campoNroDeDireccion.MaxLength = 5;
            campoDepto.MaxLength = 3;
            campoTeléfono.MaxLength = 11;
            campoPiso.MaxLength = 3;

            string queryTiposDeDoc = "SELECT DISTINCT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento";
            SqlCommand buscarTiposDeDoc = new SqlCommand(queryTiposDeDoc, conn.getConexion);
            dataReader = buscarTiposDeDoc.ExecuteReader();
            while (dataReader.Read())
            {
                comboTipoDeDocumento.Items.Add(dataReader.GetString(0));
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
            idU.SqlValue = sesion.idUsuario;
            idU.Direction = ParameterDirection.Input;
            obtenerUsuario.Parameters.Add(idU);
            dataReader = obtenerUsuario.ExecuteReader();
            dataReader.Read();

            Contraseña.Text = dataReader.GetString(2);
            campoUsuario.Text = dataReader.GetString(1);
            campoMail.Text = dataReader.GetString(3);

            dataReader.Close();

            string sacarDatosClientes = "SELECT e.apellido, e.nombre, e.codigoPostal, e.direccion, e.direccion_numero, e.documento, e.dpto, (SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad WHERE id = e.idLocalidad), (SELECT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE id = e.idTipoDocumento),e.piso, e.telefono, e.fechaNacimiento  FROM ADIOS_TERCER_ANIO.Usuario p inner join ADIOS_TERCER_ANIO.Persona e on e.idUsuario = p.id WHERE @id = e.id";
            SqlCommand ObtenerCliente = new SqlCommand(sacarDatosClientes, conn.getConexion);
            SqlParameter idUs = new SqlParameter("@id", SqlDbType.Int);
            idUs.SqlValue = sesion.idUsuario;
            idUs.Direction = ParameterDirection.Input;
            ObtenerCliente.Parameters.Add(idUs);
            dataReader = ObtenerCliente.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[0].Equals(DBNull.Value)) { campoApellido.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { campoNombre.Text = dataReader.GetString(1); }
                if (!dataReader[2].Equals(DBNull.Value)) { campoCódigoPostal.Text = dataReader.GetString(2); }
                if (!dataReader[3].Equals(DBNull.Value)) { campoDireccion.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { campoNroDeDireccion.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { campoDni.Text = Convert.ToString(dataReader.GetDecimal(5)); }
                if (!dataReader[6].Equals(DBNull.Value)) { campoDepto.Text = Convert.ToString(dataReader.GetString(6)); }
                if (!dataReader[7].Equals(DBNull.Value)) { comboLocalidad.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { comboTipoDeDocumento.Text = dataReader.GetString(8); }
                if (!dataReader[9].Equals(DBNull.Value)) { campoPiso.Text = Convert.ToString(dataReader.GetDecimal(9)); }
                if (!dataReader[10].Equals(DBNull.Value)) { campoTeléfono.Text = dataReader.GetString(10); }
                if (!dataReader[11].Equals(DBNull.Value)) { campoFechaDeNacimiento.Text = Convert.ToString(dataReader.GetDateTime(11)); }
            }
            dataReader.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sesion.anterior.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.funcionesValidacion.validarNoVacio(campoUsuario, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Contraseña, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoMail, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoNombre, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoApellido, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoDni, mensajeDeAviso);
            this.funcionesValidacion.validarNumerico(campoDni, mensajeDeAviso);
            this.funcionesValidacion.validarComboVacio(comboTipoDeDocumento, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoDireccion, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoCódigoPostal, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(campoFechaDeNacimiento, mensajeDeAviso);
           
            if (!(string.IsNullOrEmpty(campoNroDeDireccion.Text)))
            {
                this.funcionesValidacion.validarNumerico(campoNroDeDireccion, mensajeDeAviso);
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
                SqlCommand modificarCliente = new SqlCommand("ADIOS_TERCER_ANIO.ModificarPersona", conn.getConexion);
                modificarCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand modificarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.ModificarUsuario", conn.getConexion);
                modificarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
                usuario.SqlValue = campoUsuario.Text;
                usuario.Direction = ParameterDirection.Input;

                SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
                password.SqlValue = Utilidades.encriptarCadenaSHA256(Contraseña.Text);
                password.Direction = ParameterDirection.Input;

                SqlParameter idUf = new SqlParameter("@id", SqlDbType.Int);
                idUf.SqlValue = sesion.idUsuario;
                idUf.Direction = ParameterDirection.Input;

                SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
                mail.SqlValue = campoMail.Text;
                mail.Direction = ParameterDirection.Input;

                modificarUsuario.Parameters.Add(usuario);
                modificarUsuario.Parameters.Add(password);
                modificarUsuario.Parameters.Add(idUf);
                modificarUsuario.Parameters.Add(mail);
                try
                {
                    modificarUsuario.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                nombre.SqlValue = campoNombre.Text;
                nombre.Direction = ParameterDirection.Input;

                SqlParameter apellido = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
                apellido.SqlValue = campoApellido.Text;
                apellido.Direction = ParameterDirection.Input;

                SqlParameter dni = new SqlParameter("@documento", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(campoDni.Text))
                {
                    dni.SqlValue = DBNull.Value;
                }
                else
                {
                    dni.SqlValue = Convert.ToDecimal(campoDni.Text);
                }
                dni.Direction = ParameterDirection.Input;

                SqlParameter tipoDoc = new SqlParameter("@tipoDeDocumento", SqlDbType.NVarChar, 255);
                tipoDoc.SqlValue = (comboTipoDeDocumento.Text);
                tipoDoc.Direction = ParameterDirection.Input;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
                telefono.SqlValue = campoTeléfono.Text;
                telefono.Direction = ParameterDirection.Input;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(campoNroDeDireccion.Text))
                {
                    direccion.SqlValue = DBNull.Value;
                }

                else
                {
                    direccion.SqlValue = Convert.ToDecimal(campoNroDeDireccion.Text);
                }
                direccion.Direction = ParameterDirection.Input;

                SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
                calle.SqlValue = campoDireccion.Text;
                calle.Direction = ParameterDirection.Input;

                SqlParameter piso = new SqlParameter("@piso", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(campoPiso.Text))
                {
                    piso.SqlValue = DBNull.Value;
                }
                else
                {
                    piso.SqlValue = Convert.ToDecimal(campoPiso.Text);
                }
                piso.Direction = ParameterDirection.Input;

                SqlParameter depto = new SqlParameter("@depto", SqlDbType.NVarChar, 255);
                depto.SqlValue = campoDepto.Text;
                depto.Direction = ParameterDirection.Input;

                SqlParameter localidad = new SqlParameter("@localidad", SqlDbType.NVarChar, 255);
                localidad.SqlValue = comboLocalidad.SelectedText;
                localidad.Direction = ParameterDirection.Input;

                SqlParameter codigoPostal = new SqlParameter("@codigoPostal", SqlDbType.NVarChar, 255);
                codigoPostal.SqlValue = campoCódigoPostal.Text;
                codigoPostal.Direction = ParameterDirection.Input;

                SqlParameter fechaNac = new SqlParameter("@fechaNac", SqlDbType.DateTime);
                if (string.IsNullOrEmpty(campoFechaDeNacimiento.Text))
                {
                    fechaNac.SqlValue = DBNull.Value;
                }
                else
                {
                    fechaNac.SqlValue = DateTime.Parse(campoFechaDeNacimiento.Text);
                }
                SqlParameter otroid = new SqlParameter("@id", SqlDbType.Int);
                otroid.SqlValue = sesion.idUsuario;
                otroid.Direction = ParameterDirection.Input;

                modificarCliente.Parameters.Add(otroid);
                modificarCliente.Parameters.Add(dni);
                modificarCliente.Parameters.Add(tipoDoc);
                modificarCliente.Parameters.Add(nombre);
                modificarCliente.Parameters.Add(apellido);
                modificarCliente.Parameters.Add(telefono);
                modificarCliente.Parameters.Add(direccion);
                modificarCliente.Parameters.Add(calle);
                modificarCliente.Parameters.Add(piso);
                modificarCliente.Parameters.Add(depto);
                modificarCliente.Parameters.Add(localidad);
                modificarCliente.Parameters.Add(codigoPostal);
                modificarCliente.Parameters.Add(fechaNac);

                try
                {
                    modificarCliente.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                sesion.anterior.Show();
                this.Close();
            }
        }

        private void calendarioNac_DateSelected(object sender, DateRangeEventArgs e)
        {
            campoFechaDeNacimiento.Clear();
            campoFechaDeNacimiento.AppendText(calendarioNac.SelectionStart.ToShortDateString());
        }
    }
}
