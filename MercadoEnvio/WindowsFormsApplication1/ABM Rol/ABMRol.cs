using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Usuario;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class frmABMRol : Form
    {
        public frmABMRol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmAgregarRol().Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvInhabilitados.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
            }

            foreach (DataGridViewCell oneCell in dgvHabilitados.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

                if (String.IsNullOrEmpty(dgvInhabilitados.CurrentCell.Value as String))
                {
                    MessageBox.Show("Intenta habilitar una linea con un rol vacio", "Error", MessageBoxButtons.OK);
                }
            
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            
                if (String.IsNullOrEmpty(dgvHabilitados.CurrentCell.Value as String))
                {
                    MessageBox.Show("Intenta habilitar una linea con un rol vacio", "Error", MessageBoxButtons.OK);
                }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dgvHabilitados.CurrentCell.Value as String))
            {
                MessageBox.Show("Intenta modificar un rol en una linea vacia", "Error", MessageBoxButtons.OK);
            }
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ABM_Usuario.frmPantallaPrincipal("Administrativo").Show();
            this.Close();
        }

    }
}
