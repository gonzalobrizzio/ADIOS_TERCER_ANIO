using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class frmAgregarRol : Form
    {
        Conexion conn;
        public frmAgregarRol()
        {
            InitializeComponent();
            String queryFuncionalidades = "SELECT * FROM ADIOS_TERCER_ANIO.Funcionalidad";
            conn = Conexion.Instance;
            SqlCommand buscarRoles = new SqlCommand(queryFuncionalidades, conn.getConexion);
            SqlDataAdapter hb = new SqlDataAdapter(queryFuncionalidades, conn.getConexion);
            DataTable tablaDeFuncionalidades = new DataTable("Funcionalidades");
            hb.Fill(tablaDeFuncionalidades);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Habría que agregar a la base de datos y modificar el listado del abm
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Está intentando agregar un rol sin nombre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dgvFuncionalidadesAgregadas.Rows.Count==0)
                    {
                        MessageBox.Show("No ha agregado funcionalidades a el rol que desea crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            else
            {
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidadesAgregadas.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["ID"].Value,
                                          rowPrincipal.Cells["Nombre"].Value,
                                   };
                // Creamos un nuevo objeto DataGridViewRow.
                //
                DataGridViewRow row = new DataGridViewRow();

                // Creamos las celdas y las rellenamos con los valores existentes
                // en el array.
                //
                row.CreateCells(dgvFuncionalidadesAgregadas, values);

                // Añadimos la nueva fila al segundo control DataGridView.
                //
                dgvFuncionalidadesAgregadas.Rows.Add(row);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvFuncionalidadesAgregadas.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta eliminar una funcionalidad vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dgvFuncionalidadesAgregadas.Rows.RemoveAt(oneCell.RowIndex);
                        dgvFuncionalidades.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void frmAgregarRol_Load(object sender, EventArgs e)
        {

        }


    }
}
