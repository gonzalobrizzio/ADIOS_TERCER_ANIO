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
    public partial class frmElegirRol : Form
    {
        public frmElegirRol(string roles)
        {
            InitializeComponent();
            string[] rolesSeparados = roles.Split(',');
            cboRol.Items.AddRange(rolesSeparados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Hide();
                if (cboRol.SelectedItem == "Administrador")
                {
                    new frmPantallaAdministrador().Show();
                    this.Close();
                }
                else
                {
                    new ABM_Usuario.frmPantallaUsuario().Show();
                    this.Close();
                }
            }

        private void frmElegirRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        }
    }
