using MercadoEnvios.Historial_Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal(String rol)
        {
            InitializeComponent();
            if (rol.Equals("Administrativo")) {
                btnCalificarVendedor.Visible = false;
                btnComprarOfertar.Visible = false;
                btnConsultarFacturas.Visible = false;
                btnGenerarPublicacion.Visible = false;
                btnHistorial.Visible = false;
            }
            else if (rol.Equals("Cliente")) {
                btnABMRol.Visible = false;
                btnABMUsuario.Visible = false;
                btnABMVisibilidad.Visible = false;
                btnGenerarPublicacion.Visible = false;
            }
            else if (rol.Equals("Empresa")) {
                btnABMRol.Visible = false;
                btnABMUsuario.Visible = false;
                btnABMVisibilidad.Visible = false;
                btnCalificarVendedor.Visible = false;
                btnComprarOfertar.Visible = false;
                btnConsultarFacturas.Visible = false;
                btnHistorial.Visible = false;
            }
        }

        private void btnComprarOfertar_Click(object sender, EventArgs e)
        {

        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            new ABM_Usuario.frmABMUsuario().Show();
            this.Hide();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmABMRol().Show();
            this.Hide();
        }

        private void btnABMVisibilidad_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarFacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialCliente frm = new frmHistorialCliente();
            frm.Show(this);
        }

        private void btnGenerarPublicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new frmIngresar().Show();
            this.Close();
        }

        private void btnCalificarVendedor_Click(object sender, EventArgs e)
        {

            new Calificar.frmCalificacion().Show();
            this.Close();
        }
    }
}
