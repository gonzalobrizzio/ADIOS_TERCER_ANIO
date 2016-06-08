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
    public partial class frmNuevaEmpresa : Form
    {
        Conexion conn;
        string rolU;
        public frmNuevaEmpresa(string rol)
        {
            InitializeComponent();
            txtMail.MaxLength = 30;
            txtUsr.MaxLength = 20;
            txtContrasenia.MaxLength = 20;
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
            rolU = rol;
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            SqlCommand agregarEmpresa = new SqlCommand("ADIOS_TERCER_ANIO.AgregarEmpresa", conn.getConexion);
            agregarEmpresa.CommandType = System.Data.CommandType.StoredProcedure;
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
                direccion.SqlValue = null;
            }
            else
            {
                direccion.SqlValue = Convert.ToInt32(txtDireccion.Text);
            }
            direccion.Direction = ParameterDirection.Input;
          
            SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
            calle.SqlValue = txtCalle.Text;
            calle.Direction = ParameterDirection.Input;


            SqlParameter piso = new SqlParameter("@piso", SqlDbType.Int);

            if (string.IsNullOrEmpty(txtPiso.Text))
            {
                piso.SqlValue = null;
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

            agregarEmpresa.Parameters.Add(idUser);
            agregarEmpresa.Parameters.Add(razonSocial);
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
            agregarEmpresa.ExecuteNonQuery();

            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }
    }
}
