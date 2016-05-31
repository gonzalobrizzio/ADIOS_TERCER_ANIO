using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Conexion
    {
        private string source;
        private string nombreInstancia;
        private string nombreBD;
        private string user;
        private string password;
        private SqlConnection conn;
        private string p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;

        public Conexion(String _source, String _nombreInstancia, String _nombreBD, String _user, String _password)
        {
            this.source = _source;
            this.nombreInstancia = _nombreInstancia;
            this.nombreBD = _nombreBD;
            this.user = _user;
            this.password = _password;
        }

        public void conectar(){
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
            
        public String conecctionString(){
            return    "Data Source=" + this.source + "\\" + this.nombreInstancia
                       + ";Initial Catalog=" + this.nombreBD
                       + ";User ID=" + this.user
                       + ";Password=" + this.password
                       + ";Trusted_Connection=False;";
        }   
        
        public SqlConnection getConexion(){
            return this.conn;
        }

        public void cerrarConexion(){
            this.conn.Close();
        }
    }
}
