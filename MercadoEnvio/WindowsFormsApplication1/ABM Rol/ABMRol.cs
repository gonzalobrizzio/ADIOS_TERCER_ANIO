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
using WindowsFormsApplication1.ABM_Usuario;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class frmABMRol : Form
    {
        Conexion conn;
        public frmABMRol()
        {
            InitializeComponent();
            String queryHabilitados = "SELECT id,nombre, iif(deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado FROM ADIOS_TERCER_ANIO.Rol";
            conn = Conexion.Instance;
            SqlCommand buscarRoles = new SqlCommand(queryHabilitados, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(queryHabilitados, conn.getConexion);
            DataTable tablaDeRoles = new DataTable("Roles");
            da.Fill(tablaDeRoles);
            dgvRoles.DataSource = tablaDeRoles.DefaultView;
            dgvRoles.Columns[0].Visible = false;
            dgvRoles.Update();
            dgvRoles.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new ABM_Rol.frmAgregarRol().Show();
            this.Close();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

                if (String.IsNullOrEmpty(dgvRoles.CurrentCell.Value as String))
                {
                    MessageBox.Show("Intenta deshabilitar una linea con un rol vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                String query = "UPDATE ADIOS_TERCER_ANIO.Rol SET deleted = 1 WHERE @nombre = nombre";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                nombre.SqlValue = dgvRoles.CurrentCell.Value.ToString();
                nombre.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(nombre);
                actualizacion.ExecuteNonQuery();
                dgvRoles.Update();
                dgvRoles.Refresh();
                
            
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            
                if (String.IsNullOrEmpty(dgvRoles.CurrentCell.Value as String))
                {
                    MessageBox.Show("Intenta habilitar una linea con un rol vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                String query = "UPDATE ADIOS_TERCER_ANIO.Rol SET deleted = 0 WHERE @nombre = nombre";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                nombre.SqlValue = dgvRoles.CurrentCell.Value.ToString();
                nombre.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(nombre);
                actualizacion.ExecuteNonQuery();
                dgvRoles.Update();
                dgvRoles.Refresh();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(dgvRoles.CurrentCell.Value as String))
            {
                MessageBox.Show("Intenta modificar un rol en una linea vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void btnFuncRol_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dgvRoles.CurrentCell.Value as String))
            {
                MessageBox.Show("Intenta modificar un rol en una linea vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            if(dgvRoles.SelectedRows.Count == 1){
                DataGridViewRow rowPrincipal =  dgvRoles.SelectedRows[0];
                new ABM_Rol.frmVerFuncRol(Convert.ToInt32(rowPrincipal.Cells[0].Value), Convert.ToString(rowPrincipal.Cells[1].Value)).Show();
                this.Close();
            }
            else{
                MessageBox.Show("Debe seleccionar un rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
