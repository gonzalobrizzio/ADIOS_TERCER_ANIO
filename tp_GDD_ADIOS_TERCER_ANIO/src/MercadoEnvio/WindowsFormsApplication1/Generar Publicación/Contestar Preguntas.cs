using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmContestarPreguntas : Form
    {
        Conexion conn;
        SqlDataAdapter da;
        Sesion sesion = Sesion.Instance;
        Form anterior;

        public frmContestarPreguntas()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getData();
        }

        private void getData(){
            
            String queryHabilitados = "SELECT pregunta.id, pregunta.pregunta, pregunta.fecha, publicacion.descripcion FROM ADIOS_TERCER_ANIO.Pregunta pregunta inner join ADIOS_TERCER_ANIO.Publicacion publicacion on pregunta.idPublicacion = publicacion.id WHERE @idUsuario = publicacion.idPublicador AND pregunta.contestada = 0";
            conn = Conexion.Instance;
            da = new SqlDataAdapter(queryHabilitados, conn.getConexion);

            SqlParameter sesionUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
            sesionUsuario.SqlValue = sesion.idUsuario;
            sesionUsuario.Direction = ParameterDirection.Input;

            da.SelectCommand.Parameters.Add(sesionUsuario);

            DataTable tablaDeRoles = new DataTable("Preguntas");
            da.Fill(tablaDeRoles);
            dgvPreguntas.DataSource = tablaDeRoles;
            dgvPreguntas.Columns[0].Visible = false;
            dgvPreguntas.Columns[1].Width = 300;
            dgvPreguntas.Columns[2].Width = 300;
            dgvPreguntas.AllowUserToAddRows = false;
            dgvPreguntas.AllowUserToDeleteRows = false;
            dgvPreguntas.ReadOnly = true;

            if (dgvPreguntas.Rows.Count == 0)
            {
                btnVer.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Generar_Publicación.frmElegirAccion().Show();
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            new Generar_Publicación.frmVerPregunta(Convert.ToString(dgvPreguntas.CurrentRow.Cells[1].Value), Convert.ToInt32(dgvPreguntas.CurrentRow.Cells[0].Value)).Show();
            this.Hide();
        }
    }
}
