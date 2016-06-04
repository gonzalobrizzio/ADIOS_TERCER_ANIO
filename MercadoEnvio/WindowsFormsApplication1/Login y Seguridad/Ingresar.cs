using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmIngresar : Form
    {
        Conexion conn = Conexion.Instance;

        public frmIngresar()
        {
            InitializeComponent();       
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("login", conn.getConexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter usuario = new SqlParameter("@usuario", txtUsr.Text);
            usuario.Direction = ParameterDirection.Input;
            usuario.SqlDbType = SqlDbType.NVarChar;
            SqlParameter pass = new SqlParameter("@pass", txtContra.Text);
            pass.Direction = ParameterDirection.Input;
            pass.SqlDbType = SqlDbType.NVarChar;
            SqlParameter idUsuario = new SqlParameter("@idUsuario", null);
            idUsuario.Direction = ParameterDirection.Output;
            idUsuario.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(usuario);
            cmd.Parameters.Add(pass);
            cmd.Parameters.Add(idUsuario);
            try
            {
                
                cmd.ExecuteNonQuery();
                int idUsuarioDB = Int32.Parse(cmd.Parameters["@idUsuario"].Value.ToString());
                //Calculo cantidad roles
                string queryCantidadRoles = "Select @cantidad = count(*) "
                                + "from ADIOS_TERCER_ANIO.RolUsuario ru "
                                + "where ru.idUsuario = @idUsuario";
                SqlCommand cantidadRoles = new SqlCommand(queryCantidadRoles, conn.getConexion);
                SqlParameter cantidad = new SqlParameter("@cantidad", SqlDbType.Int);
                cantidad.Direction = ParameterDirection.Output;
                SqlParameter idUsuarioABuscar = new SqlParameter("@idUsuario", idUsuarioDB);
                idUsuarioABuscar.Direction = ParameterDirection.Input;
                idUsuarioABuscar.SqlDbType = SqlDbType.Int;
                cantidadRoles.Parameters.Add(cantidad);
                cantidadRoles.Parameters.Add(idUsuarioABuscar);
                cantidadRoles.ExecuteNonQuery();
                int cantidadRolesUsuario = Int32.Parse(cantidadRoles.Parameters["@cantidad"].Value.ToString());
                //Busco Los roles
                string queryBuscarRoles = "Select r.id, r.nombre "
                    //"Select @idRol = r.id, @nombreRol = r.nombre "
                                + "from ADIOS_TERCER_ANIO.RolUsuario ru "
                                + "inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol "
                                + "where ru.idUsuario = @idUsuarioABuscarRoles and ru.deleted = 0";
                SqlCommand buscarRoles = new SqlCommand(queryBuscarRoles, conn.getConexion);
                //SqlParameter idRol = new SqlParameter("@idRol", null);
                //idRol.Direction = ParameterDirection.Output;
                //idRol.SqlDbType = SqlDbType.Int;
                //SqlParameter nombreRol = new SqlParameter("@nombreRol", SqlDbType.NVarChar, 255);
                //nombreRol.Direction = ParameterDirection.Output;
                SqlParameter idUsuarioABuscarRoles = new SqlParameter("@idUsuarioABuscarRoles", idUsuarioDB);
                idUsuarioABuscarRoles.Direction = ParameterDirection.Input;
                idUsuarioABuscarRoles.SqlDbType = SqlDbType.Int;
                //buscarRoles.Parameters.Add(idRol);
                //buscarRoles.Parameters.Add(nombreRol);
                buscarRoles.Parameters.Add(idUsuarioABuscarRoles);                
                SqlDataReader dataReader = buscarRoles.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (cantidadRolesUsuario > 1)
                    {
                        dataReader.Read();
                        string roles = dataReader.GetString(1);
                        while (dataReader.Read())
                        {
                            roles = roles + "," + dataReader.GetString(1);
                        }
                        Form formrol = new ABM_Rol.frmElegirRol(roles);
                        dataReader.Close();
                        formrol.Show();
                        this.Hide();

                    }
                    if (cantidadRolesUsuario == 1)
                    {
                        dataReader.Read();
                        int rolActual = dataReader.GetInt32(0);
                        switch (rolActual)
                        {
                            case 1:
                                new ABM_Usuario.frmPantallaPrincipal("Administrador").Show();
                                dataReader.Close();
                                this.Hide();
                                break;
                            case 2:
                                new ABM_Usuario.frmPantallaPrincipal("Cliente").Show();
                                dataReader.Close();
                                this.Hide();
                                break;
                            case 3:
                                //new ABM_Usuario.frmPantallaPrincipal("Empresa").Show();
                                //dataReader.Close();
                                //this.Hide();
                                break;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No se pudieron cargar los roles");
                    dataReader.Close();
                    this.Show();
                }

            }
            catch (SqlException error)
            {
                MessageBox.Show(Convert.ToString(error.Message));
                txtContra.Text = "";
            }
        }

        private void Ingresar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.salir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.salir();
        }

        private void salir(){
            conn.cerrarConexion();
            Application.Exit();
        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {

        }


    }
}
