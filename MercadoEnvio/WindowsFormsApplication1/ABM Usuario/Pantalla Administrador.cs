using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPantallaAdministrador : Form
    {
        public frmPantallaAdministrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmIngresar().Show();
            this.Close();
        }

        private void btnUsr_Click(object sender, EventArgs e)
        {
            new ABM_Usuario.frmGestionUsuario().Show();
            this.Hide();

        }

        private void frmPantallaAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
