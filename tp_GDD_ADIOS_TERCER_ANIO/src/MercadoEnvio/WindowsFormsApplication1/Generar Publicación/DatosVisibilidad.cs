using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Generar_Publicacion
{
    public partial class frmDatosVisibilidad : Form
    {
        Conexion conn;
        string idVisibilidadEntrada;
        public frmDatosVisibilidad(string idVisibilidadAModificar)
        {
            conn = Conexion.Instance;
            InitializeComponent();
            idVisibilidadEntrada = idVisibilidadAModificar;
            this.getData();
        }

        private void getData()
        {
            String queryHabilitados = "SELECT id, nombre, duracionDias, precio, porcentaje FROM ADIOS_TERCER_ANIO.Visibilidad where nombre = @idVisibilidad";
            SqlCommand buscarVisibilidad = new SqlCommand(queryHabilitados, conn.getConexion);
            SqlParameter idVisibilidad = new SqlParameter("@idVisibilidad", SqlDbType.NVarChar, 255);
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

            txtDuracion.Enabled = false;
            txtNombre.Enabled = false;
            txtPorcentaje.Enabled = false;
            txtPrecio.Enabled = false;

        }

        public void salir()
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.salir();
        }

    }
}
