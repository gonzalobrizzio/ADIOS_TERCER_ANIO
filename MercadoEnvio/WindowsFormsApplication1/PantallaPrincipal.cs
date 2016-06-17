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
            
            btnABMVisibilidad.Visible = false;
            btnComprarOfertar.Visible = false;
            btnConsultarFacturas.Visible = false;
            btnABMUsuario.Visible = false;
            btnGenerarPublicacion.Visible = false;
            btnABMRol.Visible = false;
            btnCalificarVendedor.Visible = false;
            btnHistorial.Visible = false;
            btnListado.Visible = false;

            conn = Conexion.Instance;

            string funcionalidadesQuery = "select f.idFuncionalidad from ADIOS_TERCER_ANIO.FuncionalidadRol f "
                                   + "where f.idRol = @idRolActual";
            SqlCommand subastas = new SqlCommand(funcionalidadesQuery, conn.getConexion);
            SqlParameter idRolActual = new SqlParameter("@idRolActual", SqlDbType.Int);
            idRolActual.Direction = ParameterDirection.Input;
            idRolActual.SqlValue = sesion.idRol;
            subastas.Parameters.Add(idRolActual);
            SqlDataReader da = subastas.ExecuteReader();
            List<Int32> listF = new List<Int32>();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    listF.Add(da.GetInt32(0));
                }
            }
            da.Close();
           
            if(listF.Contains(1)){
                btnABMVisibilidad.Visible = true;
            }
            if(listF.Contains(2)){
                btnComprarOfertar.Visible = true;
            }
            if(listF.Contains(3)){
                btnConsultarFacturas.Visible = true;
            }
            if(listF.Contains(4)){
                btnABMUsuario.Visible = true;
            }
            if(listF.Contains(5)){
                btnGenerarPublicacion.Visible = true;
            }
            if(listF.Contains(6)){
                btnABMRol.Visible = true;
            }
            if(listF.Contains(7)){
                btnCalificarVendedor.Visible = true;
            }
            if (listF.Contains(8))
            {
                btnHistorial.Visible = true;
            }
            if (listF.Contains(9))
            {
                btnListado.Visible = true;
            }
        }

        private void btnComprarOfertar_Click(object sender, EventArgs e)
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

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Usuario.frmABMUsuario().Show();
            this.Close();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }

        private void btnABMVisibilidad_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Visibilidad.frmABMVisibilidad().Show();
            this.Close();
        }

        private void btnConsultarFacturas_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new Facturas.HistorialDeFacturas().Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            frmHistorialCliente frm = new frmHistorialCliente();
            frm.Show(this);
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new Generar_Publicación.frmElegirAccion().Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new Login_y_Seguridad.frmIngresar().Show();
            this.Close();
        }

        private void btnCalificarVendedor_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new Calificar.frmCalificacion().Show();
            this.Close();
        }

        private void frmPantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            new frmListadoEstadistico().Show();
            this.Close();
        }
    }
}
