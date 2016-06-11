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

            dataReader.Close();

            string sacarDatosDeEmpresa = "SELECT e.apellido, e.nombre, e.codigoPostal, e.direccion, e.direccion_numero, e.documento, e.dpto, (SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad WHERE id = e.idLocalidad), (SELECT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE id = e.idTipoDocumento),e.piso, e.telefono  FROM ADIOS_TERCER_ANIO.Usuario p inner join ADIOS_TERCER_ANIO.Persona e on e.idUsuario = p.id WHERE @id = e.id";
            SqlCommand obtenerEmpresa = new SqlCommand(sacarDatosDeEmpresa, conn.getConexion);
            SqlParameter idUs = new SqlParameter("@id", SqlDbType.Int);
            idUs.SqlValue = idUsuario;
            idUs.Direction = ParameterDirection.Input;
            obtenerEmpresa.Parameters.Add(idUs);
            dataReader = obtenerEmpresa.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[0].Equals(DBNull.Value)) { txtApellido.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { txtNombre.Text = dataReader.GetString(1); }
                if (!dataReader[2].Equals(DBNull.Value)) { txtCodigoPostal.Text = dataReader.GetString(2); }
                if (!dataReader[3].Equals(DBNull.Value)) { txtDireccion.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { txtNroDeDireccion.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { txtDni.Text = Convert.ToString(dataReader.GetDecimal(5)); }
                if (!dataReader[6].Equals(DBNull.Value)) { txtDepto.Text = Convert.ToString(dataReader.GetString(6)); }
                if (!dataReader[7].Equals(DBNull.Value)) { cmbLocalidad.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { cmbTipoDoc.Text = dataReader.GetString(8); }
                if (!dataReader[9].Equals(DBNull.Value)) { txtPiso.Text = Convert.ToString(dataReader.GetDecimal(9)); }
                if (!dataReader[10].Equals(DBNull.Value)) { txtTelefono.Text = dataReader.GetString(10); }
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
                SqlCommand modificarCliente = new SqlCommand("ADIOS_TERCER_ANIO.ModificarPersona", conn.getConexion);
                modificarCliente.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand modificarUsuario = new SqlCommand("ADIOS_TERCER_ANIO.ModificarUsuario", conn.getConexion);
                modificarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 255);
                usuario.SqlValue = txtUsr.Text;
                usuario.Direction = ParameterDirection.Input;

                SqlParameter id = new SqlParameter("@id", idUsuario);
                id.Direction = ParameterDirection.Input;
                id.SqlDbType = SqlDbType.Int;

                SqlParameter password = new SqlParameter("@password", SqlDbType.NVarChar, 255);
                password.SqlValue = Utilidades.encriptarCadenaSHA256(txtContrasenia.Text);
                password.Direction = ParameterDirection.Input;

                SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtMail.Text))
                {
                    mail.SqlValue = DBNull.Value;
                }

                else
                {
                    mail.SqlValue = txtMail.Text;
                }  
                
                mail.Direction = ParameterDirection.Input;

                modificarUsuario.Parameters.Add(usuario);
                modificarUsuario.Parameters.Add(password);
                modificarUsuario.Parameters.Add(mail);
                modificarUsuario.Parameters.Add(id);
               
                try{
                modificarUsuario.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    nombre.SqlValue = DBNull.Value;
                }

                else
                {
                    nombre.SqlValue = txtNombre.Text;
                } 
                nombre.Direction = ParameterDirection.Input;

                SqlParameter apellido = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    apellido.SqlValue = DBNull.Value;
                }

                else
                {
                    apellido.SqlValue = txtApellido.Text;
                }
                apellido.Direction = ParameterDirection.Input;

                SqlParameter dni = new SqlParameter("@documento", SqlDbType.Int);
                if (string.IsNullOrEmpty(txtDni.Text))
                {
                    dni.SqlValue = DBNull.Value;
                }

                else
                {
                    dni.SqlValue = Convert.ToInt32(txtDni.Text);
                }    
                dni.Direction = ParameterDirection.Input;

                SqlParameter tipoDoc = new SqlParameter("@tipoDeDocumento", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(cmbTipoDoc.Text))
                {
                    tipoDoc.SqlValue = DBNull.Value;
                }

                else
                {
                    tipoDoc.SqlValue = cmbTipoDoc.Text;
                }    
                tipoDoc.Direction = ParameterDirection.Input;

                SqlParameter idUser = new SqlParameter("@id", SqlDbType.Int);
                idUser.Direction = ParameterDirection.Input;
                if (idUsuario == null)
                {
                    idUser.SqlValue = DBNull.Value;
                }

                else
                {
                    idUser.SqlValue = idUsuario;
                }    

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    telefono.SqlValue = DBNull.Value;
                }

                else
                {
                    telefono.SqlValue = txtTelefono.Text;
                }       
                telefono.Direction = ParameterDirection.Input;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.Int);
                if (string.IsNullOrEmpty(txtNroDeDireccion.Text))
                {
                    direccion.SqlValue = DBNull.Value;
                }
                else
                {
                    direccion.SqlValue = Convert.ToInt32(txtNroDeDireccion.Text);
                }
                direccion.Direction = ParameterDirection.Input;

                SqlParameter calle = new SqlParameter("@calle", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    calle.SqlValue = DBNull.Value;
                }
                else
                {
                    calle.SqlValue = txtDireccion.Text;
                }    
                calle.Direction = ParameterDirection.Input;

                SqlParameter piso = new SqlParameter("@piso", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtPiso.Text))
                {
                    piso.SqlValue = DBNull.Value;
                }
                else
                {
                    piso.SqlValue = Convert.ToInt32(txtPiso.Text);
                }   
            
            
                piso.Direction = ParameterDirection.Input;

                SqlParameter depto = new SqlParameter("@depto", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtDepto.Text))
                {
                    depto.SqlValue = DBNull.Value;
                }
                else
                {
                    depto.SqlValue = txtDepto.Text;
                }   
            
                depto.Direction = ParameterDirection.Input;

                SqlParameter localidad = new SqlParameter("@localidad", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(cmbLocalidad.Text))
                {
                    localidad.SqlValue = DBNull.Value;
                }
                else
                {
                    localidad.SqlValue = cmbLocalidad.Text;
                }    
            
                localidad.Direction = ParameterDirection.Input;

                SqlParameter codigoPostal = new SqlParameter("@codigoPostal", SqlDbType.NVarChar, 255);
                if (string.IsNullOrEmpty(txtCodigoPostal.Text))
                {
                    codigoPostal.SqlValue = DBNull.Value;
                }
                else
                {
                    codigoPostal.SqlValue = txtCodigoPostal.Text;
                }    
            
                codigoPostal.Direction = ParameterDirection.Input;

                SqlParameter fechaNac = new SqlParameter("@fechaNac", SqlDbType.DateTime);
                if (string.IsNullOrEmpty(txtFechaNac.Text))
                {
                    fechaNac.SqlValue = DBNull.Value;
                }
                else
                {
                    fechaNac.SqlValue = DateTime.Parse(txtFechaNac.Text);
                }   
            

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
                modificarCliente.Parameters.Add(fechaNac);
                
                try{
                modificarCliente.ExecuteNonQuery();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

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

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
