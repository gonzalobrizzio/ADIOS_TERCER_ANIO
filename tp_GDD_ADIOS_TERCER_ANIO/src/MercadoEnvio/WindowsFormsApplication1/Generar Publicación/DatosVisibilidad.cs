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
                if(!da[1].Equals(DBNull.Value)) { txtNombre.Text = Convert.ToString(da.GetString(1));};
                if(!da[2].Equals(DBNull.Value)) { txtDuracion.Text = Convert.ToString(da.GetInt32(2));};
                if(!da[3].Equals(DBNull.Value)) { txtPrecio.Text = Convert.ToString(da.GetDecimal(3));};
                if (!da[4].Equals(DBNull.Value)) { txtPorcentaje.Text = Convert.ToString(da.GetDecimal(4)); };
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
