using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class ElegirRol : Form
    {
        public ElegirRol(Form sender)
        {
            InitializeComponent();
        }

        private void ElegirRol_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Hide();
                if (listBox1.Text == "Administrador")
                {
                    new Pantalla_Administrador().Show();
                    this.Close();
                }
                else
                {
                    new ABM_Usuario.Pantalla_de_Usuario().Show();
                    this.Close();
                }
            }
        }
    }
