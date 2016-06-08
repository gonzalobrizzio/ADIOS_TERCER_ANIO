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
    public partial class frmNuevoCliente : Form
    {
        SqlDataReader dataReader;
        Conexion conn;
        string rolU;
        public frmNuevoCliente(string rol)
        {
            InitializeComponent();

            conn = Conexion.Instance;
            rolU = rol;

            txtMail.MaxLength = 30;
            txtUsr.MaxLength = 20;
            txtContrasenia.MaxLength = 20;
            txtDni.MaxLength = 8;
            txtDireccion.MaxLength = 5;
            txtCodigoPostal.MaxLength = 4;
            txtNroDeDireccion.MaxLength = 20;
            txtDepto.MaxLength = 3;
            txtTelefono.MaxLength = 11;
            txtPiso.MaxLength = 3;

            string queryTiposDeDoc = "SELECT DISTINCT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento";
            SqlCommand buscarTiposDeDoc = new SqlCommand(queryTiposDeDoc, conn.getConexion);
            dataReader = buscarTiposDeDoc.ExecuteReader();
            while (dataReader.Read())
            {
                cmbTipoDoc.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();

            string queryLocalidades = "SELECT DISTINCT nombre FROM ADIOS_TERCER_ANIO.Localidad";
            SqlCommand buscarLocalidades = new SqlCommand(queryLocalidades, conn.getConexion);
            dataReader = buscarLocalidades.ExecuteReader();
            while (dataReader.Read())
            {
                cmbLocalidad.Items.Add(dataReader.GetString(0));
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
            SqlCommand agregarCliente = new SqlCommand("ADIOS_TERCER_ANIO.AgregarCliente", conn.getConexion);
            agregarCliente.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand agregarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.generarUsuarioConIDRol", conn.getConexion);
            agregarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
            usuario.SqlValue = txtUsr.Text;
            usuario.Direction = ParameterDirection.Input;

            SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
            password.SqlValue = txtContrasenia.Text;
            password.Direction = ParameterDirection.Input;

            SqlParameter idUsuario = new SqlParameter("@ultimoID", null);
            idUsuario.Direction = ParameterDirection.Output;
            idUsuario.SqlDbType = SqlDbType.Int;

            SqlParameter rol = new SqlParameter("@rol", SqlDbType.NVarChar, 255);
            rol.SqlValue = rolU;
            rol.Direction = ParameterDirection.Input;

            SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mail.SqlValue = txtMail.Text;
            mail.Direction = ParameterDirection.Input;

            agregarUsuario.Parameters.Add(usuario);
            agregarUsuario.Parameters.Add(password);
            agregarUsuario.Parameters.Add(idUsuario);
            agregarUsuario.Parameters.Add(rol);
            agregarUsuario.Parameters.Add(mail);
            agregarUsuario.ExecuteNonQuery();

            SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.Int);
            nombre.SqlValue = txtNombre.Text;
            nombre.Direction = ParameterDirection.Input;

            SqlParameter apellido = new SqlParameter("@apellido", SqlDbType.Int);
            apellido.SqlValue = txtApellido.Text;
            apellido.Direction = ParameterDirection.Input;

            SqlParameter dni = new SqlParameter("@dni", SqlDbType.Int);
            dni.SqlValue = Convert.ToInt32(txtDni.Text);
            dni.Direction = ParameterDirection.Input;

            SqlParameter tipoDoc = new SqlParameter("@tipoDoc", SqlDbType.NVarChar, 255);
            tipoDoc.SqlValue = cmbTipoDoc.SelectedText;
            tipoDoc.Direction = ParameterDirection.Input;

            SqlParameter idUser = new SqlParameter("@id", idUsuario);
            idUser.Direction = ParameterDirection.Input;
            idUser.SqlDbType = SqlDbType.Int;

            SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.Int);
            telefono.SqlValue = txtTelefono.Text;
            telefono.Direction = ParameterDirection.Input;

            SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.NVarChar, 255);
            direccion.SqlValue = Convert.ToInt32(txtNroDeDireccion.Text);
            direccion.Direction = ParameterDirection.Input;

            SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
            calle.SqlValue = txtDireccion.Text;
            calle.Direction = ParameterDirection.Input;

            SqlParameter piso = new SqlParameter("@piso", SqlDbType.NVarChar, 255);
            piso.SqlValue = Convert.ToInt32(txtPiso.Text);
            piso.Direction = ParameterDirection.Input;

            SqlParameter depto = new SqlParameter("@depto", SqlDbType.NVarChar, 255);
            depto.SqlValue = Convert.ToInt32(txtDepto);
            depto.Direction = ParameterDirection.Input;

            SqlParameter localidad = new SqlParameter("@localidad", SqlDbType.NVarChar, 255);
            localidad.SqlValue = cmbLocalidad.SelectedText;
            localidad.Direction = ParameterDirection.Input;

            SqlParameter codigoPostal = new SqlParameter("@codigoPostal", SqlDbType.NVarChar, 255);
            codigoPostal.SqlValue = Convert.ToInt32(txtCodigoPostal);
            codigoPostal.Direction = ParameterDirection.Input;


            agregarCliente.Parameters.Add(idUser);
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
            agregarCliente.ExecuteNonQuery();

            new frmABMUsuario().Show();
            this.Close();

        }
    }
}
