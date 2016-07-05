using MercadoEnvios.ABM_Usuario;
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

namespace MercadoEnvios.ComprarOfertar
{
    public partial class frmComprarOfertar : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;
        SqlParameter idUser = new SqlParameter("@idUsuario", SqlDbType.Int);
        int nroPagina = 0;

        Utilidades fun = new Utilidades();

        public frmComprarOfertar()
        {
            InitializeComponent();

            idUser.SqlValue = sesion.idUsuario;
            idUser.Direction = ParameterDirection.Input;

            dgvRubros.ColumnCount = 1;
            dgvRubros.ColumnHeadersVisible = true;
            dgvRubros.Columns[0].Name = "Rubros";

            dgvFiltros.ColumnCount = 1;
            dgvFiltros.ColumnHeadersVisible = true;
            dgvFiltros.Columns[0].Name = "Rubros";

            string rubrosDisponibles = "SELECT descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro";
            SqlCommand buscarRubrosDisponibles = new SqlCommand(rubrosDisponibles, conn.getConexion);
            SqlDataReader daBuscarRubrosDisponibles = buscarRubrosDisponibles.ExecuteReader();

            if (daBuscarRubrosDisponibles.HasRows)
            {
                while (daBuscarRubrosDisponibles.Read())
                {
                    DataGridViewRow rowdgvFuncionalidadesDisponibles = (DataGridViewRow)dgvRubros.Rows[0].Clone();
                    rowdgvFuncionalidadesDisponibles.Cells[0].Value = daBuscarRubrosDisponibles.GetString(0).ToString();
                    dgvRubros.Rows.Add(rowdgvFuncionalidadesDisponibles);
                }
            }
            daBuscarRubrosDisponibles.Close();
            dgvRubros.Columns[0].Width = 160;
            dgvRubros.AllowUserToAddRows = false;
            dgvRubros.AllowUserToDeleteRows = false;
            dgvRubros.ReadOnly = true;

            dgvFiltros.Columns[0].Width = 160;
            dgvFiltros.AllowUserToAddRows = false;
            dgvFiltros.AllowUserToDeleteRows = false;
            dgvFiltros.ReadOnly = true;

            this.getData();
        }

        private void getData()
        {
            txtPagina.Text = nroPagina.ToString();

            getPublicacionesPagina();

            if (nroPagina == 0)
            {
                btnPrimeraPag.Enabled = false;
                btnAnt.Enabled = false;
            }

            if (dgvPublicaciones.RowCount == 0 && nroPagina == 0 || dgvPublicaciones.RowCount < 10 && nroPagina == 0)
            {
                if (btnSgte.Enabled == true)
                {
                    btnSgte.Enabled = false;
                }

                if (btnAnt.Enabled == true)
                {
                    btnAnt.Enabled = false;
                }

                if (dgvPublicaciones.RowCount == 0 && nroPagina == 0)
                {
                    if (btnDetalle.Enabled == true)
                    {
                        btnDetalle.Enabled = false;
                    }
                }

                if (btnPrimeraPag.Enabled == true)
                {
                    btnPrimeraPag.Enabled = false;
                }

                if (button1.Enabled == true)
                {
                    button1.Enabled = false;
                }
            }

            if (dgvRubros.RowCount == 0)
            {
                btnQuitar.Enabled = false;
                btnAgregar.Enabled = false;
            }

        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            if (nroPagina < getCantPublicaciones() / 10)
            {
                nroPagina++;
                btnAnt.Enabled = true;
                btnPrimeraPag.Enabled = true;
                this.getData();
                getPublicacionesPagina();
            }
            else
            {
                btnSgte.Enabled = false;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            getData();
            button1.Enabled = true;
            btnSgte.Enabled = true;
            getPublicacionesPagina();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            btnSgte.Enabled = true;
            this.Close();
        }

        public int getCantPublicaciones()
        {
            int retorno = 0;

            String queryCant = "SELECT COUNT(publicacion.id) FROM ADIOS_TERCER_ANIO.Publicacion publicacion " +
            "inner join ADIOS_TERCER_ANIO.Visibilidad visib ON publicacion.idVisibilidad = visib.id " +
            "inner join ADIOS_TERCER_ANIO.TipoPublicacion tipoP ON tipoP.id = publicacion.idTipoPublicacion " +
            "inner join ADIOS_TERCER_ANIO.Rubro rubro ON rubro.id = publicacion.idRubro ";

            //"WHERE publicacion.idPublicador != " + sesion.idUsuario + ") - " + nroPagina + " * 20";  -> FINAL

            if (!String.IsNullOrEmpty(txtDescripción.Text))
            {
                queryCant += " AND publicacion.descripcion LIKE '%" + txtDescripción.Text + "%' ";
            }

            if (dgvFiltros.RowCount != 0)
            {
                String findRubros = "";

                foreach (DataGridViewRow rowPrincipal in dgvFiltros.Rows)
                {
                    object[] values = {
                                          rowPrincipal.Cells["Rubros"].Value
                                  };

                    findRubros += " rubro.descripcionCorta = '" + Convert.ToString(values[0]) + "' OR ";
                }

                findRubros = findRubros.Substring(0, findRubros.Length - 4);
                queryCant += " AND (" + findRubros + ") ";
            }

            queryCant += " WHERE publicacion.idPublicador != " + sesion.idUsuario + "and publicacion.stock > 0";
            queryCant += " AND (publicacion.idEstado = 2 OR publicacion.idEstado = 3)";

            try
            {
                SqlCommand comando = new SqlCommand(queryCant, conn.getConexion);
                retorno = (Int32)comando.ExecuteScalar();
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener publicaciones.\n" + ex.Message);
            }
        }

        public void getPublicacionesPagina()
        {

            int paginaInicio = getCantPublicaciones() - nroPagina * 10;

            String queryPublicaciones = "WITH tabla AS (SELECT TOP " + paginaInicio +
                                                                    " publicacion.descripcion, " +
                                                                    "tipoP.nombre AS tipo, " +
                                                                    "publicacion.precio, " +
                                                                    "publicacion.fechaInicio as fechaInicio, " +
                                                                    "publicacion.fechaFin, " +
                                                                    "publicacion.stock, " +
                                                                    "rubro.descripcionCorta as rubro, " +
                                                                    "IIF(publicacion.tieneEnvio = 0, 'SI', 'NO') AS envio, " +
                                                                    "visib.porcentaje as porcentaje, " +
                                                                    "publicacion.id " +
                                                    "FROM ADIOS_TERCER_ANIO.Publicacion publicacion " +
                            "inner join ADIOS_TERCER_ANIO.Visibilidad visib ON publicacion.idVisibilidad = visib.id " +
                            "inner join ADIOS_TERCER_ANIO.TipoPublicacion tipoP ON tipoP.id = publicacion.idTipoPublicacion " +
                            "inner join ADIOS_TERCER_ANIO.Rubro rubro ON rubro.id = publicacion.idRubro ";

            //"WHERE publicacion.idPublicador != " + sesion.idUsuario + ") - " + nroPagina + " * 20";  -> FINAL

            if (!String.IsNullOrEmpty(txtDescripción.Text))
            {
                queryPublicaciones += "AND publicacion.descripcion LIKE '%" + txtDescripción.Text + "%' ";
            }

            if (dgvFiltros.RowCount != 0)
            {
                String findRubros = "";

                foreach (DataGridViewRow rowPrincipal in dgvFiltros.Rows)
                {
                    object[] values = {
                                          rowPrincipal.Cells["Rubros"].Value
                                  };

                    findRubros += " rubro.descripcionCorta = '" + Convert.ToString(values[0]) + "' OR ";
                }

                findRubros = findRubros.Substring(0, findRubros.Length - 4);
                queryPublicaciones += " AND (" + findRubros + ") ";
            }

            queryPublicaciones += " WHERE publicacion.idPublicador != " + sesion.idUsuario + " and publicacion.stock > 0 " +
                            " AND (publicacion.idEstado = 2 OR publicacion.idEstado = 3)" +
                        " ORDER BY visib.porcentaje asc, publicacion.fechaInicio ASC)" +
                        " SELECT TOP 10 * FROM tabla ORDER by tabla.porcentaje DESC, tabla.fechaInicio DESC";

            //MessageBox.Show(queryPublicaciones);

            da = new SqlDataAdapter(queryPublicaciones, conn.getConexion);

            try
            {
                da.SelectCommand.ExecuteNonQuery();
                DataTable tablaPublicaciones = new DataTable("Facturas");
                da.Fill(tablaPublicaciones);
                dgvPublicaciones.DataSource = tablaPublicaciones;
                //" publicacion.descripcion, " +
                //"tipop.nombre as tipo, " +
                //"publicacion.precio, " +
                //"publicacion.fechainicio, " +
                //"publicacion.fechafin, " +
                //"publicacion.stock, " +
                //"rubro.descripcioncorta as rubro, " +
                //"iif(publicacion.tieneenvio = 0, 'si', 'no') as envio " +
                //"visib.porcentaje, " +
                //"publicacion.id, " + 
                dgvPublicaciones.Columns[0].Width = 200;
                dgvPublicaciones.Columns[1].Width = 100;
                dgvPublicaciones.Columns[2].Width = 50;
                dgvPublicaciones.Columns[3].Width = 75;
                dgvPublicaciones.Columns[4].Width = 75;
                dgvPublicaciones.Columns[5].Width = 50;
                dgvPublicaciones.Columns[6].Width = 150;
                dgvPublicaciones.Columns[7].Visible = false;
                dgvPublicaciones.Columns[8].Visible = false;
                dgvPublicaciones.Columns[9].Visible = false;
                dgvPublicaciones.AllowUserToDeleteRows = false;
                dgvPublicaciones.AllowUserToAddRows = false;
                dgvPublicaciones.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar obtener publicaciones.\n" + ex.Message);

            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            int idPublicacion = Convert.ToInt32(dgvPublicaciones[9, dgvPublicaciones.CurrentCell.RowIndex].Value);
            new frmDetalle(idPublicacion).Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvRubros.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Rubros"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)dgvRubros.Rows[0].Clone();
                row.Cells[0].Value = values[0];
                dgvFiltros.Rows.Add(row);
                dgvRubros.Rows.Remove(rowPrincipal);
            }
            nroPagina = 0;
            getData();
            if (0 < getCantPublicaciones() / 10)
            {
                button1.Enabled = true;
                btnSgte.Enabled = true;
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in dgvFiltros.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["Rubros"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)dgvFiltros.Rows[0].Clone();
                row.Cells[0].Value = values[0];
                dgvRubros.Rows.Add(row);
                dgvFiltros.Rows.Remove(rowPrincipal);

            }
            nroPagina = 0;
            getData();
            if (0 < getCantPublicaciones() / 10)
            {
                button1.Enabled = true;
                btnSgte.Enabled = true;
            }
        }

        private void dgvRubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRubros.CurrentRow.Selected = true;
        }

        private void dgvFiltros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFiltros.Rows.Count > 0)
            {
            dgvFiltros.CurrentRow.Selected = true;
            }
        }

        private void frmComprarOfertar_Load(object sender, EventArgs e)
        {

        }

        private void txtDescripción_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            nroPagina = 0;
            getData();
            btnSgte.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nroPagina = getCantPublicaciones() / 10;
            getData();
            btnPrimeraPag.Enabled = true;
            btnSgte.Enabled = false;
            btnAnt.Enabled = true;
            button1.Enabled = false;
        }

        private void txtPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumero(e);
        }

        private void txtPagina_TextChanged(object sender, EventArgs e)
        {
            if (txtPagina.Text != "")
            {
                if (Convert.ToInt32(txtPagina.Text) <= getCantPublicaciones() / 10)
                {
                    nroPagina = Convert.ToInt32(txtPagina.Text);
                    getData();
                    if (nroPagina != 0)
                    {
                        btnPrimeraPag.Enabled = true;
                        btnAnt.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Número de página excedido del máximo existente.");
                    txtPagina.Text = "0";
                }
            }
        }
    }
}