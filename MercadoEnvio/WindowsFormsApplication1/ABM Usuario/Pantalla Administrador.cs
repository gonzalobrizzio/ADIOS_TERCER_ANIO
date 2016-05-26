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
    public partial class Pantalla_Administrador : Form
    {
        public Pantalla_Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABM_Rol.ABMRol().Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Ingresar().Show();
            this.Close();
        }
    }
}
