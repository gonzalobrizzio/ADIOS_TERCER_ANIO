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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox7.Text.Length == 0)
            {
                MessageBox.Show("El usuario no puede estar vacío");
            }

            else if (textBox7.Text.Length < 6) {

                MessageBox.Show("La contraseña posee menos de 6 carácteres");
            }

            else if (textBox6.Text.Length == 0)
            {
                MessageBox.Show("La dirección de correcto eléctronico no puede ser vacía");

            }
            else if (!(textBox8.Text.Length > 0 || textBox3.Text.Length > 0)) {
                MessageBox.Show("Debe indicar algún número de DNI o CUIT");
            }
            else if (!(textBox10.Text.Length == 0 || textBox9.Text.Length == 0))
            {
                MessageBox.Show("Debe indicar alguna dirección ");
            }

            else
            {
                new Ingresar().Show();
                this.Close();
            }

            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Ingresar().Show();
            this.Close();

        }

    }
}
