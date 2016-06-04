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
    public partial class frmModificarRoles : Form
    {
        public frmModificarRoles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvFuncionalidadesTotales.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta agregar una funcionalidad con una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvFuncionalidadesActuales.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvFuncionalidadesActuales.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvFuncionalidadesActuales.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Funcionalidad borrada con exito!");
                    }
                }
            }
        }

        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAgregar_Click(sender, e);
        }

        private void ModificarRoles_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           //Igual que en el agregar, hay que modificar la BD y el mismo ABM
                this.Close();
        }

    }
}
