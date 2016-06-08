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
    public partial class frmNuevoCliente : Form
    {
        SqlDataReader dataReader;
        Conexion conn;
        string rolU;
        public frmNuevoCliente(string rol)
        {
            InitializeComponent();
            calendarioNac.Visible = false;
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
            SqlCommand agregarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.AgregarUsuario", conn.getConexion);
            agregarUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand agregarRolUsuario = new SqlCommand("ADIOS_TERCER_ANIO.AgregarRolUsuario", conn.getConexion);
            agregarRolUsuario.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
            usuario.SqlValue = txtUsr.Text;
            usuario.Direction = ParameterDirection.Input;

            SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
            password.SqlValue = Utilidades.encriptarCadenaSHA256(txtContrasenia.Text);
            password.Direction = ParameterDirection.Input;

            SqlParameter idUsuario = new SqlParameter("@ultimoID", null);
            idUsuario.Direction = ParameterDirection.Output;
            idUsuario.SqlDbType = SqlDbType.Int;

            SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mail.SqlValue = txtMail.Text;
            mail.Direction = ParameterDirection.Input;

            agregarUsuario.Parameters.Add(usuario);
            agregarUsuario.Parameters.Add(password);
            agregarUsuario.Parameters.Add(idUsuario);
            agregarUsuario.Parameters.Add(mail);
            agregarUsuario.ExecuteNonQuery();

            int ultimoIdRol = Convert.ToInt32(agregarUsuario.Parameters["@ultimoID"].Value);

            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            id.SqlValue = ultimoIdRol;
            id.Direction = ParameterDirection.Input;

            SqlParameter rol = new SqlParameter("@rol", SqlDbType.NVarChar, 255);
            rol.SqlValue = rolU;
            rol.Direction = ParameterDirection.Input;

            agregarRolUsuario.Parameters.Add(rol);
            agregarRolUsuario.Parameters.Add(id);
            agregarRolUsuario.ExecuteNonQuery();

            SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
            nombre.SqlValue = txtNombre.Text;
            nombre.Direction = ParameterDirection.Input;

            SqlParameter apellido = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
            apellido.SqlValue = txtApellido.Text;
            apellido.Direction = ParameterDirection.Input;

            SqlParameter dni = new SqlParameter("@dni", SqlDbType.Int);
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                dni.SqlValue = Convert.ToInt32(txtDni.Text);
            }
            dni.Direction = ParameterDirection.Input;

            SqlParameter tipoDoc = new SqlParameter("@tipoDoc", SqlDbType.NVarChar, 255);
            tipoDoc.SqlValue = cmbTipoDoc.SelectedText;
            tipoDoc.Direction = ParameterDirection.Input;

            SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
            telefono.SqlValue = txtTelefono.Text;
            telefono.Direction = ParameterDirection.Input;

            SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Int);
            if (string.IsNullOrEmpty(txtNroDeDireccion.Text))
            {
                MessageBox.Show("Ingrese un formato correcto en la dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                direccion.SqlValue = Convert.ToInt32(txtNroDeDireccion.Text);
            }
            direccion.Direction = ParameterDirection.Input;

            SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
            calle.SqlValue = txtDireccion.Text;
            calle.Direction = ParameterDirection.Input;

            SqlParameter piso = new SqlParameter("@piso", SqlDbType.Int);
             if (string.IsNullOrEmpty(txtPiso.Text))
             {
                 piso.SqlValue = 0;
             }
             else
             {
                 piso.SqlValue = Convert.ToInt32(txtPiso.Text);
             }
            piso.Direction = ParameterDirection.Input;

            SqlParameter depto = new SqlParameter("@depto", SqlDbType.NVarChar, 255);
            depto.SqlValue = txtDepto.Text;
            depto.Direction = ParameterDirection.Input;

            SqlParameter localidad = new SqlParameter("@localidad", SqlDbType.NVarChar, 255);
            localidad.SqlValue = cmbLocalidad.SelectedText;
            localidad.Direction = ParameterDirection.Input;

            SqlParameter codigoPostal = new SqlParameter("@codigoPostal", SqlDbType.NVarChar, 255);
            codigoPostal.SqlValue = txtCodigoPostal.Text;
            codigoPostal.Direction = ParameterDirection.Input;

            SqlParameter fechaNac = new SqlParameter("@fechaNac", SqlDbType.DateTime);
            fechaNac.SqlValue = DateTime.Parse(txtFechaNac.Text);

            agregarCliente.Parameters.Add(id);
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            calendarioNac.Visible = true;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechaNac.Clear();
            txtFechaNac.AppendText(calendarioNac.SelectionStart.ToShortDateString());
            calendarioNac.Visible = false;

        }

    }
}
