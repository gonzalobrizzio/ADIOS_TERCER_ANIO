using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ABM_Visibilidad
{
    public partial class frmAgregarVisibilidad : Form
    {
        Conexion conn;
        public frmAgregarVisibilidad()
        {
            conn = Conexion.Instance;
            InitializeComponent();
        }

        public void salir()
        {
            new ABM_Visibilidad.frmABMVisibilidad().Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.salir();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlCommand agregarVisibilidad = new SqlCommand("ADIOS_TERCER_ANIO.AgregarVisibilidad", conn.getConexion);
            agregarVisibilidad.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
            nombre.SqlValue = txtNombre.Text;
            nombre.Direction = ParameterDirection.Input;

            SqlParameter duracion = new SqlParameter("@duracion", SqlDbType.Int);
            duracion.SqlValue = Convert.ToInt32(txtDuracion.Text);
            duracion.Direction = ParameterDirection.Input;
           
            SqlParameter precio = new SqlParameter("@precio", SqlDbType.Decimal);
            precio.SqlValue = Convert.ToDecimal(txtPrecio.Text);
            precio.Direction = ParameterDirection.Input;

            SqlParameter porcentaje = new SqlParameter("@porcentaje", SqlDbType.Decimal);
            porcentaje.SqlValue = Convert.ToDecimal(txtPorcentaje.Text);
            porcentaje.Direction = ParameterDirection.Input;

            agregarVisibilidad.Parameters.Add(nombre);
            agregarVisibilidad.Parameters.Add(duracion);
            agregarVisibilidad.Parameters.Add(precio);
            agregarVisibilidad.Parameters.Add(porcentaje);

            try
            {
                agregarVisibilidad.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
