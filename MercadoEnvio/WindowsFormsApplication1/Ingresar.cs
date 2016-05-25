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
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chequear en BD si coincide con un usuario y contraseña
            if (textBox1.Text.Equals("gd") && textBox2.Text.Equals("gd2016"))
            {
                //EN BD: if(cantFallidos>0) cantFallidos = 0;
                //EN BD: if(cantRoles > 1) {
                using (var usrRol = new ABM_Rol.ElegirRol(this))
                {
                    this.Hide();
                    usrRol.ShowDialog();
                } 

                // } else {
                //using (var usrUsuario = new ABM_Usuario.ABMUsuario())
                //{
                //    usrUsuario.ShowDialog();
                //    this.Close();
                //} 

            }
            else
            {
                MessageBox.Show("Los datos son inválidos");
                textBox1.Text = "";
                textBox2.Text = "";
                //EN BD: cantFallidos++;
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var usrAgregar = new ABM_Usuario.NuevoUsuario())
            {
                this.Hide();
                usrAgregar.ShowDialog();
            } 
        }


    }
}
