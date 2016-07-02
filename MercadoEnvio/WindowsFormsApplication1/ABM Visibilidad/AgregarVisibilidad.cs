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

namespace MercadoEnvios.ABM_Visibilidad
{
    public partial class frmAgregarVisibilidad : Form
    {
        Conexion conn;

        Utilidades fun = new Utilidades();

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

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txtPorcentaje.Text)  <= 1){ 
            SqlCommand agregarVisibilidad = new SqlCommand("ADIOS_TERCER_ANIO.AgregarVisibilidad", conn.getConexion);
            agregarVisibilidad.CommandType = System.Data.CommandType.StoredProcedure;
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

            SqlParameter duracion = new SqlParameter("@duracion", SqlDbType.Int);
            if (string.IsNullOrEmpty(txtDuracion.Text))
            {
                duracion.SqlValue = DBNull.Value;
            }
            else
            {
                duracion.SqlValue = Convert.ToInt32(txtDuracion.Text);
            }
            duracion.Direction = ParameterDirection.Input;

            SqlParameter precio = new SqlParameter("@precio", SqlDbType.Decimal);
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                precio.SqlValue = DBNull.Value;
            }
            else
            {
                precio.SqlValue = Convert.ToDecimal(txtPrecio.Text);
            }
            precio.Direction = ParameterDirection.Input;

            SqlParameter porcentaje = new SqlParameter("@porcentaje", SqlDbType.Decimal);
            if (string.IsNullOrEmpty(txtPorcentaje.Text))
            {
                porcentaje.SqlValue = DBNull.Value;
            }
            else
            {
                porcentaje.SqlValue = Convert.ToDecimal(txtPorcentaje.Text);
            }
            porcentaje.Direction = ParameterDirection.Input;

            agregarVisibilidad.Parameters.Add(nombre);
            agregarVisibilidad.Parameters.Add(duracion);
            agregarVisibilidad.Parameters.Add(precio);
            agregarVisibilidad.Parameters.Add(porcentaje);

            try
            {
                agregarVisibilidad.ExecuteNonQuery();
                this.salir();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            }
            else
            {
                MessageBox.Show("El porcentaje ingresado supera el 100 % permitido","Advertencia" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.salir();
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumero(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumero(e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumeroDecimal(e);
        }

        private void frmAgregarVisibilidad_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.salir();
        }
    }
}
