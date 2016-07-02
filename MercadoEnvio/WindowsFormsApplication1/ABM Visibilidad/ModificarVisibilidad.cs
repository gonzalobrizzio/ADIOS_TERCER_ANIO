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
    public partial class frmModificarVisibilidad : Form
    {
        Conexion conn;
        int idVisibilidadEntrada;

        Utilidades funcionesValidacion = new Utilidades();

        public frmModificarVisibilidad(int idVisibilidadAModificar)
        {
            conn = Conexion.Instance;
            InitializeComponent();
            idVisibilidadEntrada = idVisibilidadAModificar;
            this.getData();
        }

        private void getData()
        {
            String queryHabilitados = "SELECT id, nombre, duracionDias, precio, porcentaje FROM ADIOS_TERCER_ANIO.Visibilidad where id = @idVisibilidad";
            SqlCommand buscarVisibilidad = new SqlCommand(queryHabilitados, conn.getConexion);
            SqlParameter idVisibilidad = new SqlParameter("@idVisibilidad", SqlDbType.Int);
            idVisibilidad.SqlValue = idVisibilidadEntrada;
            idVisibilidad.Direction = ParameterDirection.Input;
            buscarVisibilidad.Parameters.Add(idVisibilidad);
            SqlDataReader da = buscarVisibilidad.ExecuteReader();
            if (da.HasRows)
            {
                da.Read();
                txtNombre.Text = Convert.ToString(da.GetString(1));
                txtDuracion.Text = Convert.ToString(da.GetInt32(2));
                txtPrecio.Text = Convert.ToString(da.GetDecimal(3));
                txtPorcentaje.Text = Convert.ToString(da.GetDecimal(4));
                da.Close();
            }
            else
            {
                MessageBox.Show("No se pudo cargar la visibilidad");
                da.Close();
                this.salir();
            }
            
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
            if (Convert.ToDecimal(txtPorcentaje.Text) <= 1)
            { 
            SqlCommand modificarVisibilidad = new SqlCommand("ADIOS_TERCER_ANIO.ModificarVisibilidad", conn.getConexion);
            modificarVisibilidad.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@id", SqlDbType.NVarChar, 255);
            id.SqlValue = idVisibilidadEntrada;
            id.Direction = ParameterDirection.Input;

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

            modificarVisibilidad.Parameters.Add(id);
            modificarVisibilidad.Parameters.Add(nombre);
            modificarVisibilidad.Parameters.Add(duracion);
            modificarVisibilidad.Parameters.Add(precio);
            modificarVisibilidad.Parameters.Add(porcentaje);

            try
            {
                modificarVisibilidad.ExecuteNonQuery();
                this.salir();
            }
            catch (SqlException error)
            {
                modificarVisibilidad.Cancel();
                MessageBox.Show(error.Message);
            }
            }
            else
            {
                MessageBox.Show("El porcentaje ingresado supera el 100 % permitido, debe ingresar algo menor a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcionesValidacion.ingresarNumero(e);
        }

    }
}
