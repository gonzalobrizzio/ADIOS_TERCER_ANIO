using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmNuevoCliente : Form
    {
        SqlCommand agregar;
        public frmNuevoCliente(SqlCommand agregarUsuario)
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            new frmABMUsuario().Show();
            agregar.ExecuteNonQuery();
            this.Close();

        }
    }
}
