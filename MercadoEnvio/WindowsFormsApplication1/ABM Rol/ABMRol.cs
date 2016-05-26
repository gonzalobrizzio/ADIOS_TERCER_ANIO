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
    public partial class frmABMRol : Form
    {
        public frmABMRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmAgregarRol().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvInhabilitados.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvInhabilitados.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Rol borrada con exito!");
                    }
                }
            }

            foreach (DataGridViewCell oneCell in dgvHabilitados.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvHabilitados.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Rol borrado con exito!");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewCell oneCell in dgvHabilitados.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta inhabilitar una linea con un rol vacio");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvHabilitados.Rows.RemoveAt(oneCell.RowIndex);
                        dgvInhabilitados.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvInhabilitados.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta habilitar una linea con un rol vacio");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvInhabilitados.Rows.RemoveAt(oneCell.RowIndex);
                        dgvHabilitados.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dgvHabilitados.CurrentCell.Value as String))
            {
                MessageBox.Show("Intenta modificar un rol en una linea vacia");
            }
            else{
                var rolModificar = new ABM_Rol.frmModificarRoles();
                rolModificar.Show();
            }
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmPantallaAdministrador().Show();
            this.Close();
        }

    }
}
