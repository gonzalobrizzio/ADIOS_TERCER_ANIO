using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MercadoEnvios.ABM_Rol
{
    public partial class frmVerFuncRol : Form
    {
        Conexion conn;
        Form anterior;
        Sesion sesion = Sesion.Instance;

        public frmVerFuncRol(int idRolBuscado, string nombreRol)
        {
            InitializeComponent();
            anterior = sesion.anterior;

            txtNombre.Text = nombreRol;
           
            txtNombre.Enabled = false;

            dgvFuncionalidades.ColumnCount = 1;
            dgvFuncionalidades.ColumnHeadersVisible = true;
            dgvFuncionalidades.Columns[0].Name = "Funcionalidad";

            dgvFuncionalidades.Columns[0].Width = 700;          
            
            String query = "SELECT F.Descripcion FROM ADIOS_TERCER_ANIO.Funcionalidad F "
                         + "INNER JOIN ADIOS_TERCER_ANIO.FuncionalidadRol FR on FR.idFuncionalidad = F.id "
                         + "WHERE FR.idRol = @idRol and FR.deleted = 0";
            conn = Conexion.Instance;
            SqlCommand buscarFuncionalidades = new SqlCommand(query, conn.getConexion);
            SqlParameter idRol = new SqlParameter("@idRol", SqlDbType.Int);
            idRol.SqlValue = idRolBuscado;
            idRol.Direction = ParameterDirection.Input;
            buscarFuncionalidades.Parameters.Add(idRol);
            SqlDataReader da = buscarFuncionalidades.ExecuteReader();
            
            while(da.Read()){
                DataGridViewRow row = (DataGridViewRow)dgvFuncionalidades.Rows[0].Clone();
                row.Cells[0].Value = da.GetString(0).ToString();
                dgvFuncionalidades.Rows.Add(row);
            }
            da.Close();
            dgvFuncionalidades.AllowUserToAddRows = false;
            dgvFuncionalidades.AllowUserToDeleteRows = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.salir();
        }

        public void salir()
        {
            new ABM_Rol.frmABMRol().Show();
            this.Close();
        }
        private void frmVerFuncRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.salir();
        }
    }
}
