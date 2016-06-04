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
    public partial class frmAgregarRol : Form
    {
        public frmAgregarRol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboFuncionalidad.Text == "")
            {

                MessageBox.Show("El valor que intenta agregar es vacio!");
            }
            else {
                dgvFuncionalidades.Rows.Add(cboFuncionalidad.Text);
                cboFuncionalidad.Items.Remove(cboFuncionalidad.SelectedItem);
                cboFuncionalidad.Text = "";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Habría que agregar a la base de datos y modificar el listado del abm
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Está intentando agregar un rol sin nombre!");
            }
            else
            {
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
