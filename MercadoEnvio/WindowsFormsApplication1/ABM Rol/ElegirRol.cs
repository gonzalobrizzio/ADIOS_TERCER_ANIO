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
                    new ABM_Usuario.frmPantallaPrincipal("Administrativo").Show();
                    this.Close();
                }
                else if ((cboRol.SelectedItem).Equals("Cliente"))
                {
                    new ABM_Usuario.frmPantallaPrincipal("Cliente").Show();
                    this.Close();
                }
                else if ((cboRol.SelectedItem).Equals("Empresa"))
                {
                    new ABM_Usuario.frmPantallaPrincipal("Empresa").Show();
                    this.Close();
                }

        }

        private void frmElegirRol_Load(object sender, EventArgs e)
        {

        }

        }
    }
