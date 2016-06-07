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
        SqlCommand agregar;
        SqlParameter idUsuario;
        Conexion conn;
        public frmNuevaEmpresa(SqlCommand agregarUsuario, SqlParameter id)
        {
            InitializeComponent();

            txtMail.MaxLength = 30;
            txtDireccion.MaxLength = 5;
            txtCiudad.MaxLength = 15;
            txtCodigoPostal.MaxLength = 4;
            txtCalle.MaxLength = 20;
            txtCUIT.MaxLength = 13;
            txtDepto.MaxLength = 3;
            txtNombreDeContacto.MaxLength = 30;
            txtTelefono.MaxLength = 11;
            txtPiso.MaxLength = 3;

            agregar = agregarUsuario;
            idUsuario = id;
            conn = Conexion.Instance;
            string queryRubros = "SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro";
            SqlCommand buscarRubros = new SqlCommand(queryRubros, conn.getConexion);
            SqlDataReader dataReader = buscarRubros.ExecuteReader();
            while (dataReader.Read())
            {
                cmbRubro.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();

            string queryRazonesSociales = "SELECT DISTINCT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento";
            SqlCommand buscarRazonesSociales = new SqlCommand(queryRazonesSociales, conn.getConexion);
            dataReader = buscarRazonesSociales.ExecuteReader();
            while (dataReader.Read())
            {
                cmbRazonSocial.Items.Add(dataReader.GetString(0));
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
            new frmABMUsuario().Show();
            SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mail.SqlValue = txtMail.Text;
            mail.Direction = ParameterDirection.Input;


            agregar.Parameters.Add(mail);
            agregar.ExecuteNonQuery();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }
    }
}
