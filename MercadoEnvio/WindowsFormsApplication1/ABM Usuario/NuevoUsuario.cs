using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario(Form sender)
        {
            InitializeComponent();
        }

        private void NuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsr.Text.Length == 0)
            {
                MessageBox.Show("El usuario no puede estar vacío");

                if (txtUsr.Text.Length < 4) {
                    MessageBox.Show("El usuario debe poseer más de 4 carácteres");
                }
            }

            else if (txtContrasenia.Text.Length < 6) {

                MessageBox.Show("La contraseña posee menos de 6 carácteres");
            }

            else if (txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("La dirección de correcto eléctronico no puede ser vacía");

            }
            else if (!(txtCUIT.Text.Length > 0 || txtNroDoc.Text.Length > 0)) {
                MessageBox.Show("Debe indicar algún número de DNI o CUIT");
            }
            else if ((txtCalle.Text.Length == 0 || txtAltura.Text.Length == 0))
            {
                MessageBox.Show("Debe indicar alguna dirección ");
            }

            else
            {
                //new Ingresar().Show();
                this.Close();
            }

            txtContrasenia.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new frmIngresar().Show();
            this.Close();

        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
