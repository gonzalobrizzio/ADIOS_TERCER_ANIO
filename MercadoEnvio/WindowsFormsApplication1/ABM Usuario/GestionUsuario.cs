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
            String query = "SELECT u.id, u.usuario as Nombre_de_Usuario, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado, ru.idRol FROM ADIOS_TERCER_ANIO.Usuario u "
                              + "inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol WHERE ru.idRol != 1";

            conn = Conexion.Instance;

            SqlCommand buscarClientes = new SqlCommand(query, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tablaDeClientes = new DataTable("Clientes");
            da.Fill(tablaDeClientes);
            dgvUsuario.DataSource = tablaDeClientes.DefaultView;

            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.ReadOnly = true;
            dgvUsuario.Columns[1].Width = 150;
            dgvUsuario.Columns[2].Width = 150;
            dgvUsuario.Columns[3].Width = 150; 

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 1 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.SqlValue = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value);
                idUsuario.Direction = ParameterDirection.Input;

                actualizacion.Parameters.Add(idUsuario);
                actualizacion.ExecuteNonQuery();

                this.getData();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.SqlValue = Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value);
                idUsuario.Direction = ParameterDirection.Input;

                actualizacion.Parameters.Add(idUsuario);
                actualizacion.ExecuteNonQuery();

                this.getData();
            }
         }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvUsuario.CurrentRow.Cells[0].Value != null)
            {
                sesion.anterior = this;
                if (Convert.ToInt32(dgvUsuario.CurrentRow.Cells[3].Value) == 2)
                {
                    new frmModificarCliente(Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value)).Show();
                    this.Hide();
                }
                else 
                {
                    new frmModificarEmpresa(Convert.ToInt32(dgvUsuario.CurrentRow.Cells[0].Value)).Show();
                    this.Hide();
                }

            }
            else {
                MessageBox.Show("Debe seleccionar un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmABMUsuario_Shown(object sender, EventArgs e)
        {
            sesion.anterior = anterior;
        }
    
    }

    }
