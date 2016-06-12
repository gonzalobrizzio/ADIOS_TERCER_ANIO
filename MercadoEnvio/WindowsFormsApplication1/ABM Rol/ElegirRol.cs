using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MercadoEnvios.ABM_Rol
{
    public partial class frmElegirRol : Form
    {
        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmElegirRol(string roles)
        {
            InitializeComponent();
            anterior = sesion.anterior;
            string[] rolesSeparados = roles.Split(',');
            cboRol.Items.AddRange(rolesSeparados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (cboRol.SelectedItem == null)
                {
                    MessageBox.Show("No ha seleccionado un rol valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if ((cboRol.SelectedItem).Equals("Administrativo"))
                {
                    sesion.idRol = 1;
                    new ABM_Usuario.frmPantallaPrincipal().Show();
                    this.Hide();
                }
                else if ((cboRol.SelectedItem).Equals("Cliente"))
                {
                    sesion.idRol = 2;
                    new ABM_Usuario.frmPantallaPrincipal().Show();
                    this.Hide();
                }
                else if ((cboRol.SelectedItem).Equals("Empresa"))
                {
                    sesion.idRol = 3;
                    new ABM_Usuario.frmPantallaPrincipal().Show();
                    this.Hide();
                }

        }

        private void frmElegirRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            sesion.anterior.Show();
        }

        }
    }
