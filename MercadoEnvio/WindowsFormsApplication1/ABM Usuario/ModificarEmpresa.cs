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
        public frmModificarEmpresa(int id)
        {
            InitializeComponent();
            idUsuario = id;

            InitializeComponent();
            txtMail.MaxLength = 30;
            txtUsr.MaxLength = 20;
            txtDireccion.MaxLength = 5;
            txtCiudad.MaxLength = 15;
            txtCodigoPostal.MaxLength = 4;
            txtCalle.MaxLength = 20;
            txtCUIT.MaxLength = 13;
            txtDepto.MaxLength = 3;
            txtNombreDeContacto.MaxLength = 30;
            txtTelefono.MaxLength = 11;
            txtPiso.MaxLength = 3;
            txtRazonSocial.MaxLength = 50;

            conn = Conexion.Instance;
            string queryRubros = "SELECT DISTINCT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro";
            SqlCommand buscarRubros = new SqlCommand(queryRubros, conn.getConexion);
            SqlDataReader dataReader = buscarRubros.ExecuteReader();
            while (dataReader.Read())
            {
                cmbRubro.Items.Add(dataReader.GetString(0));
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

            dataReader.Close();

            string sacarDatosDeEmpresa = "SELECT e.codigoPostal,"
	                                             +"e.contacto,"
	                                             +"e.cuit,"
	                                             +"e.direccion,"
	                                             +"e.direccion_numero,"
	                                             +"e.dpto,"
	                                             +"(SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad where id = e.idLocalidad) AS Localidad,"
	                                             +"(SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro WHERE id = e.idRubro) AS Rubro,"
	                                             +"e.piso,"
	                                             +"e.razonSocial,"
	                                             +"e.telefono"
                                                 +"FROM ADIOS_TERCER_ANIO.Usuario u inner join ADIOS_TERCER_ANIO.Empresa e on u.id = e.idUsuario WHERE @id = u.id";
            SqlCommand obtenerEmpresa = new SqlCommand(sacarDatosDeEmpresa, conn.getConexion);
            obtenerEmpresa.Parameters.Add(idU);
            dataReader = obtenerEmpresa.ExecuteReader();
            dataReader.Read();

            txtCodigoPostal.Text = dataReader.GetString(0);
            txtNombreDeContacto.Text = dataReader.GetString(1);
            txtCalle.Text = dataReader.GetString(2);
            txtDireccion.Text = Convert.ToString(dataReader.GetInt32(3));
            txtDepto.Text = dataReader.GetString(4);
            cmbLocalidad.Text = dataReader.GetString(5);
            cmbRubro.Text = dataReader.GetString(6);
            txtPiso.Text = Convert.ToString(dataReader.GetDecimal(7));
            txtRazonSocial.Text = dataReader.GetString(8);
            txtTelefono.Text = dataReader.GetString(9);
            
            dataReader.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlCommand modificarEmpresa = new SqlCommand("ADIOS_TERCER_ANIO.ModificarEmpresa", conn.getConexion);
            modificarEmpresa.CommandType = System.Data.CommandType.StoredProcedure;
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

            SqlParameter razonSocial = new SqlParameter("@razonSocial", SqlDbType.NVarChar, 255);
            razonSocial.SqlValue = txtRazonSocial.Text;
            razonSocial.Direction = ParameterDirection.Input;

            SqlParameter idUser = new SqlParameter("@id", idUsuario);
            idUser.Direction = ParameterDirection.Input;
            idUser.SqlDbType = SqlDbType.Int;

            SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
            telefono.SqlValue = txtTelefono.Text;
            telefono.Direction = ParameterDirection.Input;

            SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Int);
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese un formato correcto en la dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                direccion.SqlValue = Convert.ToInt32(txtDireccion.Text);
            }
            direccion.Direction = ParameterDirection.Input;

            SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
            calle.SqlValue = txtCalle.Text;
            calle.Direction = ParameterDirection.Input;


            SqlParameter piso = new SqlParameter("@piso", SqlDbType.Decimal);

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

            SqlParameter ciudad = new SqlParameter("@ciudad", SqlDbType.NVarChar, 255);
            ciudad.SqlValue = txtCiudad.Text;
            ciudad.Direction = ParameterDirection.Input;

            SqlParameter cuit = new SqlParameter("@cuit", SqlDbType.NVarChar, 255);
            cuit.SqlValue = txtCUIT.Text;
            cuit.Direction = ParameterDirection.Input;

            SqlParameter contacto = new SqlParameter("@contacto", SqlDbType.NVarChar, 255);
            contacto.SqlValue = txtNombreDeContacto.Text;
            contacto.Direction = ParameterDirection.Input;

            SqlParameter rubro = new SqlParameter("@rubro", SqlDbType.NVarChar, 255);
            rubro.SqlValue = cmbRubro.SelectedText;
            rubro.Direction = ParameterDirection.Input;

            modificarEmpresa.Parameters.Add(idUser);
            modificarEmpresa.Parameters.Add(razonSocial);
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
            modificarEmpresa.ExecuteNonQuery();

            new frmABMUsuario().Show();
            this.Close();
        }
    }
}
