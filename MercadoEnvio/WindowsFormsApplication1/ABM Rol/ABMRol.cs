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
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABM_Rol.AgregarRol().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Rol borrada con exito!");
                    }
                }
            }

            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Rol borrado con exito!");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta inhabilitar una linea con un rol vacio");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        dataGridView2.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta habilitar una linea con un rol vacio");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
                        dataGridView1.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dataGridView1.CurrentCell.Value as String))
            {
                MessageBox.Show("Intenta modificar un rol en una linea vacia");
            }
            else{
                var rolModificar = new ABM_Rol.ModificarRoles();
                rolModificar.Show();
            }
        }

    }
}
