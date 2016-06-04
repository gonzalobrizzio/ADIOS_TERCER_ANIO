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
            String query = "SELECT * FROM ADIOS_TERCER_ANIO.Funcionalidad";
            conn = Conexion.Instance;
            SqlCommand buscarFuncionalidades = new SqlCommand(query, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tablaFuncionalidades = new DataTable("Funcionalidades");
            da.Fill(tablaFuncionalidades);
            dgvFuncionalidades.DataSource = tablaFuncionalidades.DefaultView;
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
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidades.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["id"].Value,
                                          rowPrincipal.Cells["descripcion"].Value
                                  };
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFuncionalidades, values);
                dgvFuncionalidadesAgregadas.Rows.Add(row);
                dgvFuncionalidades.Rows.Remove(row);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                row.CreateCells(dgvFuncionalidades, values);

                // Añadimos la nueva fila al segundo control DataGridView.
                //
                dgvFuncionalidades.Rows.Add(row);

            }

           
        }


    }
}
