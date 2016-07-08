using MercadoEnvios.Entidades;
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
        Utilidades fun = new Utilidades();
        int clienteOEmpresa = 0;

        public frmABMUsuario()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getDataClientes();
            this.getDataEmpresas();
        }

        public void getDataClientes() 
        {
            conn = Conexion.Instance;
            decimal documentoP = -1;
            string nombreP = nombre.Text;
            string apellidoP = apellido.Text;
            string mailP = mailC.Text;

            if (dni.Text != "")
            {
                documentoP = Convert.ToDecimal(dni.Text);
            }

            SqlDataAdapter da = new SqlDataAdapter("ADIOS_TERCER_ANIO.ObtenerUsuariosCliente", conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter documentoK = new SqlParameter("@doc", SqlDbType.NVarChar, 255);
            if (dni.Text.Length == 8)
            {
                documentoK.SqlValue = documentoP;
            }
            else
            {
                documentoK.SqlValue = DBNull.Value;
            }
            documentoK.Direction = ParameterDirection.Input;

            SqlParameter nombreK = new SqlParameter("@nombre", SqlDbType.NVarChar, 255);
            nombreK.SqlValue = nombreP;
            nombreK.Direction = ParameterDirection.Input;

            SqlParameter apellidoK = new SqlParameter("@apellido", SqlDbType.NVarChar, 255);
            apellidoK.SqlValue = apellidoP;
            apellidoK.Direction = ParameterDirection.Input;

            SqlParameter mailK = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mailK.SqlValue = mailP;
            mailK.Direction = ParameterDirection.Input;

            da.SelectCommand.Parameters.Add(documentoK);
            da.SelectCommand.Parameters.Add(nombreK);
            da.SelectCommand.Parameters.Add(apellidoK);
            da.SelectCommand.Parameters.Add(mailK);
            DataTable tablaDeClientes = new DataTable("Clientes");
            da.Fill(tablaDeClientes);
            dgvClientes.DataSource = tablaDeClientes.DefaultView;

            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.Columns[1].Width = 150;
            dgvClientes.Columns[2].Width = 150;
            dgvClientes.Columns[3].Width = 150;
        }

        public void getDataEmpresas()
        {
            conn = Conexion.Instance;
            string cuitP = cuit.Text;
            string razonSocialP = razonSocial.Text;
            string mailP = mailE.Text;

            SqlDataAdapter data = new SqlDataAdapter("ADIOS_TERCER_ANIO.ObtenerUsuariosEmpresa", conn.getConexion);
            DataTable tablaDeEmpresas = new DataTable("Empresas");
            data.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter cuitK = new SqlParameter("@cuit", SqlDbType.NVarChar, 255);
            cuitK.SqlValue = cuitP;
            cuitK.Direction = ParameterDirection.Input;

            SqlParameter razonSocialK = new SqlParameter("@razonSocial", SqlDbType.NVarChar, 255);
            razonSocialK.SqlValue = razonSocialP;
            razonSocialK.Direction = ParameterDirection.Input;

            SqlParameter mailK = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mailK.SqlValue = mailP;
            mailK.Direction = ParameterDirection.Input;

            data.SelectCommand.Parameters.Add(cuitK);
            data.SelectCommand.Parameters.Add(razonSocialK);
            data.SelectCommand.Parameters.Add(mailK);
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
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteOEmpresa == 0)
            {
                if (dgvClientes.Rows.Count != 0)
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
            }
            else
            {
                if (dgvEmpresas.Rows.Count != 0)
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
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (clienteOEmpresa == 0)
            {
                if (dgvClientes.Rows.Count != 0)
                {
                    if (dgvClientes.CurrentRow.Selected == false)
                    {
                        MessageBox.Show("Debe seleccionar un usuario de tipo Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0, intentos = 0 WHERE @idUsuario = id";
                        SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                        SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                        idUsuario.Direction = ParameterDirection.Input;
                        actualizacion.Parameters.Add(idUsuario);
                        idUsuario.SqlValue = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                        actualizacion.ExecuteNonQuery();
                        this.getDataClientes();
                    }
                }
            }
            else{
                if (dgvEmpresas.Rows.Count != 0)
                {
                    if (dgvEmpresas.CurrentRow.Selected == false)
                    {
                        MessageBox.Show("Debe seleccionar un usuario de tipo Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0, intentos = 0 WHERE @idUsuario = id";
                        SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                        SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                        idUsuario.Direction = ParameterDirection.Input;
                        actualizacion.Parameters.Add(idUsuario);
                        idUsuario.SqlValue = Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value);
                        actualizacion.ExecuteNonQuery();
                        this.getDataEmpresas();
                    }
                }
            }

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (clienteOEmpresa == 0)
            {
                if (dgvClientes.Rows.Count != 0)
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
                        this.getDataClientes();
                    }
                }
            }
            else
            {
                if (dgvEmpresas.Rows.Count != 0)
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
                        this.getDataEmpresas();
                    }
                }
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            new frmNuevoUsuario().Show();
            sesion.anterior = this;
            this.Hide();
        }

        private void E_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (E.SelectedIndex == 0)
            {
                clienteOEmpresa = 0;
            }
            else
            {
                clienteOEmpresa = 1;
            }
        }


        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.getDataClientes();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            this.getDataClientes();
        }

        private void dni_TextChanged(object sender, EventArgs e)
        {
                this.getDataClientes();
        }

        private void mailC_TextChanged(object sender, EventArgs e)
        {
            this.getDataClientes();
        }

        private void cuit_TextChanged(object sender, EventArgs e)
        {
            this.getDataEmpresas();
        }

        private void razonSocial_TextChanged(object sender, EventArgs e)
        {
            this.getDataEmpresas();
        }

        private void mailE_TextChanged(object sender, EventArgs e)
        {
            this.getDataEmpresas();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNombre(e);
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNombre(e);
        }

        private void dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumero(e);
        }

        private void mailC_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarMail(e);
        }

        private void cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumeroConRaya(e);
        }

        private void mailE_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarMail(e);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            if (clienteOEmpresa == 0)
            {
                if (dgvClientes.Rows.Count != 0)
                {
                    if (dgvClientes.CurrentRow.Selected == false)
                    {
                        MessageBox.Show("Debe seleccionar un usuario de tipo Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        this.verCant(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                    }
                }
            }
            else
            {
                if (dgvEmpresas.Rows.Count != 0)
                {
                    if (dgvEmpresas.CurrentRow.Selected == false)
                    {
                        MessageBox.Show("Debe seleccionar un usuario de tipo Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.verCant(Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value));
                    }
                }
            }
        }


        public void verCant(int idUsuario)
        {
            string queryBuscarRoles = "SELECT r.nombre FROM ADIOS_TERCER_ANIO.Rol r LEFT JOIN ADIOS_TERCER_ANIO.RolUsuario rolU ON r.id = rolU.idRol AND rolU.idUsuario = " + idUsuario + " WHERE rolU.idRol is null AND r.deleted = 0";
            SqlCommand buscarRoles = new SqlCommand(queryBuscarRoles, conn.getConexion);
            SqlDataReader dataReader = buscarRoles.ExecuteReader();
            dataReader.Read();

            if(dataReader.HasRows)
            {
                dataReader.Close();
                new AgregarRolAUsuario(idUsuario).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario posee todos los roles!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataReader.Close();
            }
        }
    
    }

    }
