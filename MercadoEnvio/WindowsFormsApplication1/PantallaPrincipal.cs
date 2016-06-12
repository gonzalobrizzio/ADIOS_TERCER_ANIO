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
        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmPantallaPrincipal()
        {
            InitializeComponent();
            anterior = sesion.anterior;

            if (sesion.idRol == 1) {
                btnCalificarVendedor.Visible = false;
                btnComprarOfertar.Visible = false;
                btnConsultarFacturas.Visible = false;
                btnGenerarPublicacion.Visible = false;
                btnHistorial.Visible = false;
            }
            else if (sesion.idRol == 2)
            {
                btnABMRol.Visible = false;
                btnABMUsuario.Visible = false;
                btnABMVisibilidad.Visible = false;
                btnConsultarFacturas.Visible = false;
            }
            else if (sesion.idRol == 3)
            {
                btnABMRol.Visible = false;
                btnABMUsuario.Visible = false;
                btnABMVisibilidad.Visible = false;
                btnCalificarVendedor.Visible = false;
                btnComprarOfertar.Visible = false;
                btnHistorial.Visible = false;
            }
        }

        private void btnComprarOfertar_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ComprarOfertar.ComprarOfertar().Show();
            this.Hide();
        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Usuario.frmABMUsuario().Show();
            this.Hide();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new ABM_Rol.frmABMRol().Show();
            this.Hide();
        }

        private void btnABMVisibilidad_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarFacturas_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new Facturas.HistorialDeFacturas().Show();
            this.Hide();
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
            this.Hide();
        }

        private void btnCalificarVendedor_Click(object sender, EventArgs e)
        {
            sesion.anterior = this;
            new Calificar.frmCalificacion().Show();
            this.Hide();
        }

        private void frmPantallaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            sesion.anterior.Show();
        }

        private void frmPantallaPrincipal_Shown(object sender, EventArgs e)
        {
            sesion.anterior = anterior;
        }
    }
}
