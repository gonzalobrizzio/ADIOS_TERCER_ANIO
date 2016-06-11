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

        public frmElegirRol(string roles)
        {
            InitializeComponent();
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
                    new ABM_Usuario.frmPantallaPrincipal("Administrativo").Show();
                    this.Close();
                }
                else if ((cboRol.SelectedItem).Equals("Cliente"))
                {
                    sesion.idRol = 2;
                    new ABM_Usuario.frmPantallaPrincipal("Cliente").Show();
                    this.Close();
                }
                else if ((cboRol.SelectedItem).Equals("Empresa"))
                {
                    sesion.idRol = 3;
                    new ABM_Usuario.frmPantallaPrincipal("Empresa").Show();
                    this.Close();
                }

        }
        }
    }
