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
            String queryHabilitados = "SELECT id, pregunta, fecha FROM ADIOS_TERCER_ANIO.Pregunta";
            conn = Conexion.Instance;
            da = new SqlDataAdapter(queryHabilitados, conn.getConexion);
            DataTable tablaDeRoles = new DataTable("Preguntas");
            da.Fill(tablaDeRoles);
            dgvPreguntas.DataSource = tablaDeRoles;
            dgvPreguntas.Columns[0].Visible = false;
            dgvPreguntas.Columns[1].Width = 300;
            dgvPreguntas.Columns[2].Width = 300;
            dgvPreguntas.AllowUserToAddRows = false;
            dgvPreguntas.AllowUserToDeleteRows = false;
            dgvPreguntas.ReadOnly = true;
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
