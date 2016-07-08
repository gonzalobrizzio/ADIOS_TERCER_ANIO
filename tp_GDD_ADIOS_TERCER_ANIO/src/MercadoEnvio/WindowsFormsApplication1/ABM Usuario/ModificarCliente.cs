using MercadoEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        int idUsuarioActual;
        DateTime fechaSistema = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
        DateTime fechaMinimaNacimiento;
        DateTime fechaMaximaNacimiento;
        string tipov;
        string nrov;
        string usuariov;
        string mailv;

        public frmModificarCliente(int id)
        {
            InitializeComponent();
            conn = Conexion.Instance;
            idUsuarioActual = id;
            Mail.MaxLength = 30;
            Usuario.MaxLength = 20;
            Contraseña.MaxLength = 20;
            Nro_de_Documento.MaxLength = 8;
            Direccion.MaxLength = 50;
            CodigoPostal.MaxLength = 4;
            Nro_de_Direccion.MaxLength = 5;
            Depto.MaxLength = 3;
            Telefono.MaxLength = 11;
            Piso.MaxLength = 3;

            string queryTiposDeDoc = "SELECT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento";
            SqlCommand buscarTiposDeDoc = new SqlCommand(queryTiposDeDoc, conn.getConexion);
            dataReader = buscarTiposDeDoc.ExecuteReader();
            while (dataReader.Read())
            {
                Tipo_de_Documento.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();

            string queryLocalidades = "SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad";
            SqlCommand buscarLocalidades = new SqlCommand(queryLocalidades, conn.getConexion);
            dataReader = buscarLocalidades.ExecuteReader();
            while (dataReader.Read())
            {
                Localidad.Items.Add(dataReader.GetString(0));
            }
            dataReader.Close();

            string sacarDatosDeUsuario = "SELECT * FROM ADIOS_TERCER_ANIO.Usuario WHERE id = @id";
            SqlCommand obtenerUsuario = new SqlCommand(sacarDatosDeUsuario, conn.getConexion);
            SqlParameter idU = new SqlParameter("@id", SqlDbType.Int);
            idU.SqlValue = idUsuarioActual;
            idU.Direction = ParameterDirection.Input;
            obtenerUsuario.Parameters.Add(idU);
            dataReader = obtenerUsuario.ExecuteReader();
            dataReader.Read();

            Contraseña.Text = dataReader.GetString(2);
            Usuario.Text = dataReader.GetString(1);
            Mail.Text = dataReader.GetString(3);

            dataReader.Close();

            string sacarDatosClientes = "SELECT e.apellido, e.nombre, e.codigoPostal, e.direccion, e.direccion_numero, e.documento, e.dpto, (SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad WHERE id = e.idLocalidad), (SELECT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE id = e.idTipoDocumento),e.piso, e.telefono, e.fechaNacimiento FROM ADIOS_TERCER_ANIO.Usuario u inner join ADIOS_TERCER_ANIO.Persona e on u.id = e.idUsuario WHERE @id = u.id";
            SqlCommand ObtenerCliente = new SqlCommand(sacarDatosClientes, conn.getConexion);
            SqlParameter idUs = new SqlParameter("@id", SqlDbType.Int);
            idUs.SqlValue = idUsuarioActual;
            idUs.Direction = ParameterDirection.Input;
            ObtenerCliente.Parameters.Add(idUs);
            dataReader = ObtenerCliente.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[0].Equals(DBNull.Value)) { Apellido.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { Nombre.Text = dataReader.GetString(1); }
                if (!dataReader[2].Equals(DBNull.Value)) { CodigoPostal.Text = dataReader.GetString(2); }
                if (!dataReader[3].Equals(DBNull.Value)) { Direccion.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { Nro_de_Direccion.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { Nro_de_Documento.Text = Convert.ToString(dataReader.GetDecimal(5)); }
                if (!dataReader[6].Equals(DBNull.Value)) { Depto.Text = Convert.ToString(dataReader.GetString(6)); }
                if (!dataReader[7].Equals(DBNull.Value)) { Localidad.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { Tipo_de_Documento.Text = dataReader.GetString(8); }
                if (!dataReader[9].Equals(DBNull.Value)) { Piso.Text = Convert.ToString(dataReader.GetDecimal(9)); }
                if (!dataReader[10].Equals(DBNull.Value)) { Telefono.Text = dataReader.GetString(10); }
                if (!dataReader[11].Equals(DBNull.Value)) { Fecha_De_Nacimiento.Text = Convert.ToString(dataReader.GetDateTime(11)); }
            }

            nrov = Nro_de_Documento.Text;
            tipov = Tipo_de_Documento.Text;
            usuariov = Usuario.Text;
            mailv = Mail.Text;

            if (Localidad.SelectedIndex.Equals(-1))
            {
                Localidad.SelectedIndex = 0;
            }
            dataReader.Close();

            Fecha_De_Nacimiento.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            fechaMinimaNacimiento = fechaSistema.AddYears(-120);
            fechaMaximaNacimiento = fechaSistema.AddYears(-18);

            bool usuarioB = this.funcionesValidacion.validarNoVacio(Usuario, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Contraseña, mensajeDeAviso);
            bool mailB = this.funcionesValidacion.validarNoVacio(Mail, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Nombre, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Apellido, mensajeDeAviso);
            bool dniB = this.funcionesValidacion.validarNoVacio(Nro_de_Documento, mensajeDeAviso);
            this.funcionesValidacion.validarNumerico(Nro_de_Documento, mensajeDeAviso);
            this.funcionesValidacion.validarCantidad(Nro_de_Documento.Text, mensajeDeAviso);
            bool tipoB = this.funcionesValidacion.validarComboVacio(Tipo_de_Documento, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Direccion, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(CodigoPostal, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Fecha_De_Nacimiento, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(Nro_de_Direccion, mensajeDeAviso);
            this.funcionesValidacion.validarFormaMail(Mail, mensajeDeAviso);
            

            if (Fecha_De_Nacimiento.Text != "")
            {
                this.funcionesValidacion.validarFechaDeNacimiento(fechaMaximaNacimiento, fechaMinimaNacimiento, DateTime.Parse(Fecha_De_Nacimiento.Text), mensajeDeAviso);
            }

            bool validaciones;

            if (usuarioB && usuariov != Usuario.Text)
            {
                this.funcionesValidacion.validarUsuario(Usuario, mensajeDeAviso);
            }

            if (dniB && tipoB && (Nro_de_Documento.Text != nrov || Tipo_de_Documento.Text != tipov))
            {
                this.funcionesValidacion.validarDNI(Tipo_de_Documento.Text, Nro_de_Documento, mensajeDeAviso);
            }

            if (mailB && mailv != Mail.Text)
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
            { validaciones = true; }

            if (validaciones)
            {
                SqlCommand modificarCliente = new SqlCommand("ADIOS_TERCER_ANIO.ModificarPersona", conn.getConexion);
                modificarCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand modificarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.ModificarUsuario", conn.getConexion);
                modificarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
                usuario.SqlValue = Usuario.Text;
                usuario.Direction = ParameterDirection.Input;

                SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
                password.SqlValue = Utilidades.encriptarCadenaSHA256(Contraseña.Text);
                password.Direction = ParameterDirection.Input;

                SqlParameter idUf = new SqlParameter("@id", SqlDbType.Int);
                idUf.SqlValue = idUsuarioActual;
                idUf.Direction = ParameterDirection.Input;

                SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
                mail.SqlValue = Mail.Text;
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
                codigoPostal.SqlValue = CodigoPostal.Text;
                codigoPostal.Direction = ParameterDirection.Input;

                SqlParameter fechaNac = new SqlParameter("@fechaNac", SqlDbType.DateTime);
                if (string.IsNullOrEmpty(Fecha_De_Nacimiento.Text))
                {
                    fechaNac.SqlValue = DBNull.Value;
                }
                else
                {
                    fechaNac.SqlValue = DateTime.Parse(Fecha_De_Nacimiento.Text);
                }
                SqlParameter otroid = new SqlParameter("@id", SqlDbType.Int);
                otroid.SqlValue = idUsuarioActual;
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

                new frmABMUsuario().Show();
                this.Close();
            }
        }

        private void calendarioNac_DateSelected(object sender, DateRangeEventArgs e)
        {
            Fecha_De_Nacimiento.Clear();
            Fecha_De_Nacimiento.AppendText(calendarioNac.SelectionStart.ToShortDateString());
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Nro_de_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void CodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarMail(e);
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Nro_de_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void Depto_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNombre(e);
        }

        private void Piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

    }
}
