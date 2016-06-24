using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmABMUsuario : Form
    {
        Conexion conn;
        Form anterior;
        Sesion sesion = Sesion.Instance;

        public frmABMUsuario()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getData();
        }

        public void getData() 
        {
            String query = "SELECT u.id, u.usuario AS Usuario, u.mail AS Mail, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado, e.nombre AS Nombre, e.apellido AS Apellido, e.documento AS Documento FROM ADIOS_TERCER_ANIO.Usuario u "
                              + "inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol inner join ADIOS_TERCER_ANIO.Persona e on u.id = e.idUsuario WHERE ru.idRol != 1";

            conn = Conexion.Instance;

            SqlCommand buscarClientes = new SqlCommand(query, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tablaDeClientes = new DataTable("Clientes");
            da.Fill(tablaDeClientes);
            dgvClientes.DataSource = tablaDeClientes.DefaultView;

            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.Columns[1].Width = 150;
            dgvClientes.Columns[2].Width = 150;
            dgvClientes.Columns[3].Width = 150;

            String queryE = "SELECT u.id, u.usuario AS Usuario, u.mail AS Mail, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado, e.razonSocial AS Razon_Social, e.cuit AS CUIT FROM ADIOS_TERCER_ANIO.Usuario u "
                              + "inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol inner join ADIOS_TERCER_ANIO.Empresa e on u.id = e.idUsuario  WHERE ru.idRol != 1";

            conn = Conexion.Instance;

            SqlCommand buscarEmpresas = new SqlCommand(queryE, conn.getConexion);
            SqlDataAdapter data = new SqlDataAdapter(queryE, conn.getConexion);
            DataTable tablaDeEmpresas = new DataTable("Empresas");
            data.Fill(tablaDeEmpresas);
            dgvEmpresas.DataSource = tablaDeEmpresas.DefaultView;

            dgvEmpresas.AllowUserToAddRows = false;
            dgvEmpresas.AllowUserToDeleteRows = false;
            dgvEmpresas.ReadOnly = true;
            dgvEmpresas.Columns[1].Width = 150;
            dgvEmpresas.Columns[2].Width = 150;
            dgvEmpresas.Columns[3].Width = 150; 

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmNuevoUsuario().Show();
            sesion.anterior = this;
            this.Hide();
        }

        private void frmABMUsuario_Shown(object sender, EventArgs e)
        {
            sesion.anterior = anterior;
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.CurrentRow.Selected = false;
            dgvEmpresas.CurrentRow.Selected = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmpresas.CurrentRow.Selected = false;
            dgvClientes.CurrentRow.Selected = true;
        }

        private void btnHabilitarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un usuario de tipo Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                idUsuario.SqlValue = Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                this.getData();
            }
        }

        private void btnDeshabilitarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un usuario de tipo Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 1 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                idUsuario.SqlValue = Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value);
                actualizacion.ExecuteNonQuery();
                this.getData();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentCell.Selected == false)
            {
                MessageBox.Show("Debe elegir un usuario de tipo Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                new frmModificarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)).Show();
                this.Close();
            }

        }

        private void btnModificarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.CurrentCell.Selected == false)
            {
                MessageBox.Show("Debe elegir un usuario de tipo Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                new frmModificarEmpresa(Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value)).Show();
                this.Close();

            }
        }

        private void btnDeshabilitarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un usuario de tipo Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 1 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                idUsuario.SqlValue = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                actualizacion.ExecuteNonQuery();

                this.getData();
            }
        }

        private void btnHabilitarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un usuario de tipo Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                idUsuario.SqlValue = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                actualizacion.ExecuteNonQuery();
                this.getData();
            }
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEmpresas_Click(object sender, EventArgs e)
        {

        }
    
    }

    }
