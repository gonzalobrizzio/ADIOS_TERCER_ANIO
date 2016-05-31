using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class frmPantallaUsuario : Form
    {
        public frmPantallaUsuario()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmIngresar().Show();
            this.Close();
        }

        private void frmPantallaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            new Calificar.frmCalificacion().Show();
            this.Close();
        }
    }
}
