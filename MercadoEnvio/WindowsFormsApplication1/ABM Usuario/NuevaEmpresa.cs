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
    public partial class frmNuevaEmpresa : Form
    {
        Conexion conn;
        string rolU;
        StringBuilder mensajeDeAviso = new StringBuilder();
        private Utilidades funcionesValidacion = new Utilidades();

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
            bool usuarioB = this.funcionesValidacion.validarNoVacio(txtUsr, mensajeDeAviso);
            this.funcionesValidacion.validarNoVacio(txtContrasenia, mensajeDeAviso);
            bool mailB = this.funcionesValidacion.validarNoVacio(txtMail, mensajeDeAviso);
            bool razonSocialB = this.funcionesValidacion.validarNoVacio(txtRazonSocial, mensajeDeAviso);
            bool cuitB = this.funcionesValidacion.validarNoVacio(txtCUIT, mensajeDeAviso);
           
            bool validaciones;

            if (cuitB)
            {
                this.funcionesValidacion.validarCUIT(txtCUIT, mensajeDeAviso);
            }

            if (razonSocialB)
            {
                this.funcionesValidacion.validarRazonSocial(txtRazonSocial, mensajeDeAviso);
            }

            if (usuarioB)
            {
                this.funcionesValidacion.validarUsuario(txtUsr, mensajeDeAviso);
            }

            if (mailB)
            {
                this.funcionesValidacion.validarEmail(txtMail, mensajeDeAviso);
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
                razonSocial.SqlValue = txtRazonSocial.Text;
                razonSocial.Direction = ParameterDirection.Input;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
                telefono.SqlValue = txtTelefono.Text;
                telefono.Direction = ParameterDirection.Input;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Int);

                if (!(txtDireccion.Text == ""))
                {
                    direccion.SqlValue = Convert.ToInt32(txtDireccion.Text);
                }
                else { direccion.SqlValue = DBNull.Value; }
                direccion.Direction = ParameterDirection.Input;

                SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
                calle.SqlValue = txtCalle.Text;
                calle.Direction = ParameterDirection.Input;


                SqlParameter piso = new SqlParameter("@piso", SqlDbType.Decimal);
                if (!(txtPiso.Text == ""))
                {
                    piso.SqlValue = Convert.ToDecimal(txtPiso.Text);
                }
                else { piso.SqlValue = DBNull.Value; }
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

                SqlParameter otroId = new SqlParameter("@id", SqlDbType.Int);
                otroId.Direction = ParameterDirection.Input;
                otroId.SqlValue = Convert.ToInt32(agregarUsuario.Parameters["@ultimoID"].Value);

                
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
                
                try{
                agregarEmpresa.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                new frmABMUsuario().Show();
                this.Close();
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
    }
}
