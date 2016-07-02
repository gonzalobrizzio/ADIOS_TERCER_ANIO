using MercadoEnvios.ABM_Visibilidad;
using MercadoEnvios.Historial_Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MercadoEnvios.Login_y_Seguridad;
using System.Data.SqlClient;
using MercadoEnvios.Listado_Estadistico;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmPantallaPrincipal : Form
    {
        Sesion sesion = Sesion.Instance;
        Conexion conn;

        public frmPantallaPrincipal()
        {
            InitializeComponent();

            conn = Conexion.Instance;
            sesion = Sesion.Instance;
            string funcionalidadesQuery = "ADIOS_TERCER_ANIO.ObtenerFuncionalidades";

            SqlDataAdapter da = new SqlDataAdapter(funcionalidadesQuery, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter idRolActual = new SqlParameter("@idRolActual", SqlDbType.Int);
            idRolActual.Direction = ParameterDirection.Input;
            idRolActual.SqlValue = sesion.idRol;
            da.SelectCommand.Parameters.Add(idRolActual);
            da.SelectCommand.ExecuteNonQuery();

            DataTable tablaFun = new DataTable("Funcionalidades");
            da.Fill(tablaFun);
            funcionalidadesR.DataSource = tablaFun.DefaultView;
            funcionalidadesR.Columns[0].Width = 250;
            funcionalidadesR.AllowUserToDeleteRows = false;
            funcionalidadesR.AllowUserToAddRows = false;
            funcionalidadesR.ReadOnly = true;

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new Login_y_Seguridad.frmIngresar().Show();
            this.Close();
        }


        private void funcionalidadesR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            funcionalidadesR.CurrentRow.Selected = true;
        }

        private void btnElegirFuncionalidad_Click(object sender, EventArgs e)
        {
            if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "ABM Visilidad")
            {
                new ABM_Visibilidad.frmABMVisibilidad().Show();
                this.Close();
            }
            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Comprar/Ofertar")
            {
                SqlCommand puedeComprar = new SqlCommand("ADIOS_TERCER_ANIO.puedeComprar", conn.getConexion);
                puedeComprar.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter usr = new SqlParameter("@idUsuario", SqlDbType.Int);
                usr.SqlValue = sesion.idUsuario;
                usr.Direction = ParameterDirection.Input;

                SqlParameter puede = new SqlParameter("@puede", null);
                puede.Direction = ParameterDirection.Output;
                puede.SqlDbType = SqlDbType.Int;

                puedeComprar.Parameters.Add(usr);
                puedeComprar.Parameters.Add(puede);

                try { puedeComprar.ExecuteNonQuery(); }
                catch (SqlException error) { MessageBox.Show(error.Message); }

                if (Convert.ToInt32(puedeComprar.Parameters["@puede"].Value) == 1)
                {
                    sesion.anterior = this;
                    new ComprarOfertar.frmComprarOfertar().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tiene compras sin calificar, debe calificar las compras antes de realizar otra accion");
                }
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Consultar Facturas")
            {
                new Facturas.HistorialDeFacturas().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "ABM Usuario")
            {
                new ABM_Usuario.frmABMUsuario().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Generar Publicacion")
            {
                new Generar_Publicación.frmElegirAccion().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "ABM Rol")
            {
                new ABM_Rol.frmABMRol().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Calificar Vendedor")
            {
                new Calificar.frmCalificacion().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Historial de Compras y Subastas")
            {
                new frmHistorialCliente().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Listado Estadistico")
            {
                new frmListadoEstadistico().Show();
                this.Close();
            }

            else if (this.funcionalidadesR.CurrentRow.Cells[0].Value.ToString() == "Cambiar Contrasenia")
            {
                new frmCambiarContraseña(sesion.usuario).Show();
                this.Close();
            }

        }
    }
}
