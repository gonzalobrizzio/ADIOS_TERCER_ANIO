using MercadoEnvios.ABM_Usuario;
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
using System.Configuration;

namespace MercadoEnvios.Listado_Estadistico
{
    public partial class frmListadoEstadistico : Form
    {
        Conexion conn;
        SqlDataReader dataReader;
        Utilidades funciones = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();

        public frmListadoEstadistico()
        {
            InitializeComponent();
            conn = Conexion.Instance;
            tipo_de_listado.Items.Add("Vendedores con mayor cantidad de productos no vendidos");
            tipo_de_listado.Items.Add("Clientes con mayor cantidad de productos comprados");
            tipo_de_listado.Items.Add("Vendedores con mayor cantidad de facturas");
            tipo_de_listado.Items.Add("Vendedores con mayor monto facturado");
            tipo_de_listado.SelectedIndex = 0;

            trimestre.Items.Add("Enero - Marzo");
            trimestre.Items.Add("Abril - Junio");
            trimestre.Items.Add("Julio - Septiembre");
            trimestre.Items.Add("Octubre - Diciembre");
            trimestre.SelectedIndex = 0;

            lblRubro.Visible = false;
            rubro.Visible = false;
            lblVisibilidad.Visible = false;
            visibilidad.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validaciones;
            funciones.validarComboVacio(tipo_de_listado, mensajeValidacion);
            funciones.validarComboVacio(anio, mensajeValidacion);
            funciones.validarComboVacio(trimestre, mensajeValidacion);

            if (lblRubro.Visible == true)
            {
                funciones.validarComboVacio(rubro, mensajeValidacion);
            }

            if (lblVisibilidad.Visible == true)
            {
                funciones.validarComboVacio(visibilidad, mensajeValidacion);
            }

            if (mensajeValidacion.Length > 0)
            {
                validaciones = false;
                MessageBox.Show(mensajeValidacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeValidacion = new StringBuilder();
            }
            else
            {validaciones = true;}

              if (validaciones)
              {

                  if (tipo_de_listado.SelectedIndex == 0)
                  {
                      int anioF = Convert.ToInt32(anio.Text);
                      new frmListadoDeNoVendidos(trimestre.SelectedIndex + 1, anioF, visibilidad.SelectedIndex + 1).Show();
                      this.Close();
                  }
                  if (tipo_de_listado.SelectedIndex == 1)
                  {
                      int anioF = Convert.ToInt32(anio.Text);
                      new frmListadoDeCantidadComprada(trimestre.SelectedIndex + 1, anioF, rubro.SelectedIndex + 1).Show();
                      this.Close();
                  }
                  if (tipo_de_listado.SelectedIndex == 2)
                  {
                      int anioF = Convert.ToInt32(anio.Text);
                      new frmListadoDeMayorCantidadDeFactura(trimestre.SelectedIndex + 1, anioF).Show();
                      this.Close();
                  }
                  if (tipo_de_listado.SelectedIndex == 3)
                  {
                      int anioF = Convert.ToInt32(anio.Text);
                      new frmListadoDeMayorFacturado(trimestre.SelectedIndex + 1, anioF).Show();
                      this.Close();
                  }
              }
        }

        private void tipo_de_listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int anioComienzo = 1900;
            int anioFinal = (Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"])).Year;
            //int añoFinal = Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]).Year;
            int i = anioFinal;
            anio.Items.Clear();

            if (lblRubro.Visible == true) { 
                    lblRubro.Visible = false;
                    rubro.Visible = false;
            }

            if(lblVisibilidad.Visible == true){
                 lblVisibilidad.Visible = false;
                 visibilidad.Visible = false;
            }


            if (tipo_de_listado.SelectedIndex == 0)
            {
                //Año de publicaciones
                string queryAño = "SELECT DISTINCT fechaFin FROM ADIOS_TERCER_ANIO.Publicacion WHERE fechaFin=(SELECT MIN(fechaFin) FROM ADIOS_TERCER_ANIO.Publicacion)";
                SqlCommand buscarLocalidades = new SqlCommand(queryAño, conn.getConexion);
                dataReader = buscarLocalidades.ExecuteReader();
                dataReader.Read();
                anioComienzo = dataReader.GetDateTime(0).Year;
                dataReader.Close();

                string queryVisibilidad = "SELECT nombre FROM ADIOS_TERCER_ANIO.Visibilidad WHERE deleted = 0";
                SqlCommand buscarVisibilidades = new SqlCommand(queryVisibilidad, conn.getConexion);
                dataReader = buscarVisibilidades.ExecuteReader();
                while (dataReader.Read())
                {
                    visibilidad.Items.Add(dataReader.GetString(0));
                }

                dataReader.Close();

                lblVisibilidad.Visible = true;
                visibilidad.Visible = true;
            }
            if (tipo_de_listado.SelectedIndex == 1)
            {
                //Año de compras
                string queryAño = "SELECT DISTINCT fechaFin FROM ADIOS_TERCER_ANIO.Publicacion WHERE fechaFin=(SELECT MIN(fechaFin) FROM ADIOS_TERCER_ANIO.Publicacion)";
                SqlCommand buscarLocalidades = new SqlCommand(queryAño, conn.getConexion);
                dataReader = buscarLocalidades.ExecuteReader();
                dataReader.Read();
                anioComienzo = dataReader.GetDateTime(0).Year;
                dataReader.Close();

                string queryRubros = "SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro";
                SqlCommand buscarRubros = new SqlCommand(queryRubros, conn.getConexion);
                dataReader = buscarRubros.ExecuteReader();
                while (dataReader.Read())
                {
                    rubro.Items.Add(dataReader.GetString(0));
                }

                dataReader.Close();

                lblRubro.Visible = true;
                rubro.Visible = true;
            }

            if (tipo_de_listado.SelectedIndex == 2)
            {
                //Año de facturas
                string queryAño = "SELECT DISTINCT fecha FROM ADIOS_TERCER_ANIO.Factura WHERE fecha =(SELECT MIN(fecha) FROM ADIOS_TERCER_ANIO.Factura)";
                SqlCommand buscarLocalidades = new SqlCommand(queryAño, conn.getConexion);
                dataReader = buscarLocalidades.ExecuteReader();
                dataReader.Read();
                anioComienzo = dataReader.GetDateTime(0).Year;
                dataReader.Close();
            }
            if (tipo_de_listado.SelectedIndex == 3)
            {
                //Año de facturas
                string queryAño = "SELECT DISTINCT fecha FROM ADIOS_TERCER_ANIO.Factura WHERE fecha =(SELECT MIN(fecha) FROM ADIOS_TERCER_ANIO.Factura)";
                SqlCommand buscarLocalidades = new SqlCommand(queryAño, conn.getConexion);
                dataReader = buscarLocalidades.ExecuteReader();
                dataReader.Read();
                anioComienzo = dataReader.GetDateTime(0).Year;
                dataReader.Close();
            }

            for (; i >= anioComienzo;)
            {
                this.anio.Items.Add(i);
                i--;
            }

            anio.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();
        }
    }
}
