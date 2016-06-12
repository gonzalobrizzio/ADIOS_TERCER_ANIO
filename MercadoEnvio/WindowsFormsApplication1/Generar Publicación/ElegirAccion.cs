using MercadoEnvios.ABM_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmElegirAccion : Form
    {
        Sesion sesion;
        public frmElegirAccion()
        {
            InitializeComponent();
        }

        private void btnNuevaPublicacion_Click(object sender, EventArgs e)
        {
            new Generar_Publicación.frmGenerarPublicacion().Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();
        }

        private void btnModificarPublicacion_Click(object sender, EventArgs e)
        {
            new Generar_Publicación.frmModificarPublicacion().Show();
        }
    }
}
