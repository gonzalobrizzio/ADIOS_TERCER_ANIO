using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmVerPregunta : Form
    {
        Conexion conn;
        int idPreguntaContestada;
        public frmVerPregunta(string pregunta, int idPregunta)
        {
            InitializeComponent();
            lblPregunta.Text = pregunta;
            idPreguntaContestada = idPregunta;
            conn = Conexion.Instance;
        }

        private void Ver_Pregunta_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Generar_Publicación.frmContestarPreguntas().Show();
            this.Close();
        }

        private void btnContestar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ADIOS_TERCER_ANIO.Respuesta (idPregunta, fecha, respuesta) VALUES ("
                + Convert.ToString(idPreguntaContestada) + ", '" + Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]) + "', '" + txtRespuesta.Text + "')";
            string query2 = "UPDATE ADIOS_TERCER_ANIO.Pregunta set contestada = 1 where id = " + idPreguntaContestada;
            SqlCommand respuesta = new SqlCommand(query, conn.getConexion);
            SqlCommand pregunta = new SqlCommand(query2, conn.getConexion);
            try
            {
                respuesta.ExecuteNonQuery();
                pregunta.ExecuteNonQuery();
                new Generar_Publicación.frmContestarPreguntas().Show();
                this.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmVerPregunta_FormClosed(object sender, FormClosedEventArgs e)
        {

            new Generar_Publicación.frmContestarPreguntas().Show();
            this.Close();
        }
    }
}
