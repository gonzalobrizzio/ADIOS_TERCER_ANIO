using MercadoEnvios.ABM_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ComprarOfertar
{
    public partial class frmComprarOfertar : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;
        SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
        
        int nroPagina = 0;

        public frmComprarOfertar()
        {
            InitializeComponent();

            idUsuario.SqlValue = sesion.idUsuario;
            idUsuario.Direction = ParameterDirection.Input;

            this.getData();
        }

        private void getData()
        {

            //--	declare @idUsuario int = 7;
            //--	declare @pagina INT = 3;

                //    DECLARE @cant int = (select count(*) from ADIOS_TERCER_ANIO.Publicacion 
                //            where publicacion.idPublicador != @idUsuario) - @pagina * 20;
                //    IF (@cant > 0)
                //    BEGIN
                //    WITH TablaP as (select TOP (@cant) publicacion.descripcion, publicacion.fechaFin, (select nombre from ADIOS_TERCER_ANIO.TipoPublicacion where id = publicacion.idTipoPublicacion) as tipo,
                //                    publicacion.precio, publicacion.id, visib.porcentaje, publicacion.fechaInicio,publicacion.stock, iif(publicacion.tieneEnvio = 0, 'SI', 'NO') AS envio from ADIOS_TERCER_ANIO.Publicacion publicacion
                //    inner join ADIOS_TERCER_ANIO.Visibilidad visib on publicacion.idVisibilidad = visib.id
                //    where publicacion.idPublicador != @idUsuario and stock > 0 and publicacion.idEstado = 4 
                //    ORDER BY visib.porcentaje asc, publicacion.fechaInicio ASC)

                //    SELECT top 20 * FROM TablaP ORDER by TablaP.porcentaje desc, TablaP.fechaInicio desc
                //    END
                //    ELSE
                //        THROW 50004, 'No hay más paginas para ver!', 1; 
            
            // ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN(@idUsuario INT, @pagina INT)
            String cmd = "ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN";

            SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
            pagina.SqlValue = nroPagina;
            pagina.Direction = ParameterDirection.Input;

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idUsuario);
            da.SelectCommand.Parameters.Add(pagina);

            try
            {
                da.SelectCommand.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

            DataTable tablaDeCompras = new DataTable("Publicaciones para comprar / ofertar");
            da.Fill(tablaDeCompras);
            dgvPublicaciones.DataSource = tablaDeCompras;

            dgvPublicaciones.Columns[0].Width = 200;
            dgvPublicaciones.Columns[1].Width = 70;
            dgvPublicaciones.Columns[2].Width = 100;
            dgvPublicaciones.Columns[3].Width = 50;
            dgvPublicaciones.Columns[4].Visible = false;
            dgvPublicaciones.Columns[5].Visible = false;
            dgvPublicaciones.Columns[6].Visible = false;
            dgvPublicaciones.AllowUserToAddRows = false;
            dgvPublicaciones.AllowUserToDeleteRows = false;
            dgvPublicaciones.ReadOnly = true;

            da.SelectCommand.Parameters.Clear();

        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            nroPagina++;
            btnAnt.Enabled = true;
            this.getData();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            this.getData();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            btnSgte.Enabled = true;
            this.Close();
        }

        public DataTable getAllPublicationByFiltro(DateTime fecha, String descripcion, String rubros)
        {
            DataTable retorno = null;

            SqlConnection conexion = null;
            SqlTransaction trx = null;
            DataTable tabla = null;



            String find = "SELECT " +
                          "p.number AS number,p.description AS description,m.description AS mode,v.description AS visibility,v.publishPrice AS publishPrice," +
                          "(p.stock - (SELECT ISNULL(SUM(quantity),0) FROM GRUPO_GDD.purchase WHERE publication_number = p.number)) 	AS stockRemaining " +
                          " FROM " +
                          "GRUPO_GDD.publication p,GRUPO_GDD.mode m,GRUPO_GDD.visibility v,GRUPO_GDD.publication_has_category pc " +
                          " WHERE " +
                          "p.mode_id = m.id AND p.visibility_code = v.code AND p.number = pc.publication_number AND p.mode_id = 2 " +
                          "AND (p.state_publication_id = 2 OR p.state_publication_id = 3) AND p.expireDate >=  '" + fecha.ToString("yyyyMMdd") + "' AND " +
                          "(p.stock - (SELECT ISNULL(SUM(quantity),0) FROM GRUPO_GDD.purchase WHERE publication_number = p.number)) > 0 ";

            if (!String.IsNullOrEmpty(descripcion))
            {
                find += "AND p.description LIKE '%" + descripcion + "%' ";
            }

            if (!String.IsNullOrEmpty(rubros))
            {
                String findRubros = "";

                string[] a = rubros.Split(';');
                foreach (string i in a)
                {
                    findRubros += "pc.category_id = " + i + " OR ";
                }

                findRubros = findRubros.Substring(0, findRubros.Length - 4);
                find += "AND (" + findRubros + ") ";
            }
            /* "AND p.description = '"+ descripcion +"' AND ("+ findRubros +") " + */
            find += " UNION " +
              "  SELECT " +
              "p.number AS number,p.description AS description,m.description AS mode,v.description AS visibility,v.publishPrice AS publishPrice," +
              "p.stock	AS stockRemaining " +
              "  FROM " +
              "GRUPO_GDD.publication p,GRUPO_GDD.mode m,GRUPO_GDD.visibility v,GRUPO_GDD.publication_has_category pc " +
              " WHERE " +
              "p.mode_id = m.id AND p.visibility_code = v.code AND p.number = pc.publication_number AND p.mode_id = 3 " +
              "AND (p.state_publication_id = 2 OR p.state_publication_id = 3) AND p.expireDate >=  '" + fecha.ToString("yyyyMMdd") + "' ";

            if (!String.IsNullOrEmpty(descripcion))
            {
                find += "AND p.description LIKE '%" + descripcion + "%' ";
            }

            if (!String.IsNullOrEmpty(rubros))
            {
                String findRubros = "";

                string[] a = rubros.Split(';');
                foreach (string i in a)
                {
                    findRubros += "pc.category_id = " + i + " OR ";
                }

                findRubros = findRubros.Substring(0, findRubros.Length - 4);
                find += "AND (" + findRubros + ") ";
            }

            find += "ORDER BY publishPrice DESC";

            try
            {

                conexion = DAOUtils.getConnection();
                conexion.Open();

                trx = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand(find, conexion);
                comando.Transaction = trx;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla = new DataTable();
                adaptador.Fill(tabla);
                conexion.Close();

                retorno = tabla;
                return retorno;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar listar datos.\n" + ex.Message);
            }

            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            int idPublicacion = Convert.ToInt32(dgvPublicaciones[4, dgvPublicaciones.CurrentCell.RowIndex].Value);
            new frmDetalle(idPublicacion).Show();
            this.Hide(); 
        }
    }
}
