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

            dgvFuncionalidadesAgregadas.ColumnCount = 1;
            dgvFuncionalidadesAgregadas.ColumnHeadersVisible = true;
            dgvFuncionalidadesAgregadas.Columns[0].Name = "Descripcion";

            dgvFuncionalidades.ColumnCount = 1;
            dgvFuncionalidades.ColumnHeadersVisible = true;
            dgvFuncionalidades.Columns[0].Name = "Descripcion";

            String query = "SELECT Descripcion FROM ADIOS_TERCER_ANIO.Funcionalidad";
            conn = Conexion.Instance;
            SqlCommand buscarFuncionalidades = new SqlCommand(query, conn.getConexion);
            SqlDataReader da = buscarFuncionalidades.ExecuteReader();
            
            if(!da.HasRows){
                MessageBox.Show("Error al cargar funcionalidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new ABM_Rol.frmABMRol().Show();
                this.Close();
            }
            while(da.Read()){
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFuncionalidades, da.GetString(0).ToString());
                dgvFuncionalidades.Rows.Add(row);
            }


            da.Close();
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
                String queryRol = "INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES (@nombre)";
                SqlCommand agregarRol = new SqlCommand(queryRol, conn.getConexion);
                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
                nombre.SqlValue = txtNombre.Text;
                nombre.Direction = ParameterDirection.Input;
                agregarRol.Parameters.Add(nombre);
                agregarRol.ExecuteNonQuery();
                new ABM_Rol.frmABMRol().Show();

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
                                          rowPrincipal.Cells["Descripcion"].Value
                                  };
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFuncionalidades, values);
                dgvFuncionalidadesAgregadas.Rows.Add(row);
                dgvFuncionalidades.Rows.Remove(rowPrincipal);

            }

         


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFuncionalidadesAgregadas.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Descripcion"].Value
                                  };
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvFuncionalidadesAgregadas, values);
                dgvFuncionalidades.Rows.Add(row);
                dgvFuncionalidadesAgregadas.Rows.Remove(rowPrincipal);
            }

           
        }

        private void frmAgregarRol_Load(object sender, EventArgs e)
        {

        }


    }
}
