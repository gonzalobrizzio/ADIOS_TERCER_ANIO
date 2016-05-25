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
    public partial class Pantalla_de_Usuario : Form
    {
        public Pantalla_de_Usuario()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Ingresar().Show();
            this.Close();
        }
    }
}
