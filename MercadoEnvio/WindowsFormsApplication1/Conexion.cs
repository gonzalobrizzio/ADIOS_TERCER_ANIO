using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MercadoEnvios
{
    sealed class Conexion
    {
        private string source;
        private string nombreInstancia;
        private string nombreBD;
        private string user;
        private string password;
        private SqlConnection conn;
        private static readonly Conexion instance = new Conexion(ConfigurationManager.AppSettings["local"],
                                                                 ConfigurationManager.AppSettings["tipo"],
                                                                 ConfigurationManager.AppSettings["base"],
                                                                 ConfigurationManager.AppSettings["user"],
                                                                 ConfigurationManager.AppSettings["password"]);


        public Conexion(String _source, String _nombreInstancia, String _nombreBD, String _user, String _password)
        {
            this.source = _source;
            this.nombreInstancia = _nombreInstancia;
            this.nombreBD = _nombreBD;
            this.user = _user;
            this.password = _password;
            this.conectar();
        }

        public void conectar()
        {
            this.conn = new SqlConnection();
            conn.ConnectionString = this.conecctionString();
            try
            {
                this.conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo establecer la conexión con la Base de datos.");
                Application.Exit();
            }
        }

        public String conecctionString()
        {
            return "Data Source=" + this.source + "\\" + this.nombreInstancia
                       + ";Initial Catalog=" + this.nombreBD
                       + ";User ID=" + this.user
                       + ";Password=" + this.password
                       + ";Trusted_Connection=False;";
        }

        public void cerrarConexion()
        {
            this.conn.Close();
        }

        public static Conexion Instance
        {
            get
            {
                return instance;
            }
        }

        public SqlConnection getConexion { 
            get{
                return conn;
            }
        }

    }
}
