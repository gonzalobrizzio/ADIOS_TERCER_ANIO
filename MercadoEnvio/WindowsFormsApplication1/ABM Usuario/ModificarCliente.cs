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
        int idUsuario;
        public frmModificarCliente(int id)
        {
            InitializeComponent();
            idUsuario = id;

            calendarioNac.Visible = false;
            conn = Conexion.Instance;

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

            string sacarDatosDeUsuario = "SELECT * FROM ADIOS_TERCER_ANIO.Usuario WHERE id = @id";
            SqlCommand obtenerUsuario = new SqlCommand(sacarDatosDeUsuario, conn.getConexion);
            SqlParameter idU = new SqlParameter("@id", SqlDbType.Int);
            idU.SqlValue = idUsuario;
            idU.Direction = ParameterDirection.Input;
            obtenerUsuario.Parameters.Add(idU);
            dataReader = obtenerUsuario.ExecuteReader();
            dataReader.Read();

            txtUsr.Text = dataReader.GetString(1);
            txtMail.Text = dataReader.GetString(3);

            MessageBox.Show(dataReader.GetString(1));

            dataReader.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlCommand modificarCliente = new SqlCommand("ADIOS_TERCER_ANIO.ModificarCliente", conn.getConexion);
            modificarCliente.CommandType = System.Data.CommandType.StoredProcedure;
            SqlCommand modificarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.ModificarUsuario", conn.getConexion);
            modificarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
            usuario.SqlValue = txtUsr.Text;
            usuario.Direction = ParameterDirection.Input;

            SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
            password.SqlValue = Utilidades.encriptarCadenaSHA256(txtContrasenia.Text);
            password.Direction = ParameterDirection.Input;

            SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mail.SqlValue = txtMail.Text;
            mail.Direction = ParameterDirection.Input;

            modificarUsuario.Parameters.Add(usuario);
            modificarUsuario.Parameters.Add(mail);
            modificarUsuario.ExecuteNonQuery();

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

            SqlParameter idUser = new SqlParameter("@id", idUsuario);
            idUser.Direction = ParameterDirection.Input;
            idUser.SqlDbType = SqlDbType.Int;

            SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
            telefono.SqlValue = txtTelefono.Text;
            telefono.Direction = ParameterDirection.Input;

            SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Int);
            if (string.IsNullOrEmpty(txtDni.Text))
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

            SqlParameter piso = new SqlParameter("@piso", SqlDbType.NVarChar, 255);
            piso.SqlValue = Convert.ToInt32(txtPiso.Text);
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

            modificarCliente.Parameters.Add(idUser);
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
            modificarCliente.ExecuteNonQuery();

            new frmABMUsuario().Show();
            this.Close();

        }

        private void calendarioNac_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechaNac.Clear();
            txtFechaNac.AppendText(calendarioNac.SelectionStart.ToShortDateString());
            calendarioNac.Visible = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            calendarioNac.Visible = true;
        }
    }
}
