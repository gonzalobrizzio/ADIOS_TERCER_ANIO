using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Entidades
{
    class Utilidades
    {
        private Conexion conn = Conexion.Instance;
        
        public static  String encriptarCadenaSHA256(String s)
        {
            SHA256Managed hasher = new SHA256Managed();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(s);
            byte[] passwordHash = hasher.ComputeHash(passwordBytes);
            string hashString = string.Empty;
            foreach (byte x in passwordHash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public bool validarNoVacio(Control control, StringBuilder mensajeValidacion)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                mensajeValidacion.AppendLine(string.Format(" El campo {0} no puede estar en blanco.", control.Name));
                return false;
            }
            return true;
        }

        public bool validarComboVacio(ComboBox combo, StringBuilder mensajeValidacion)
        {
            if (combo.SelectedIndex > -1)
                return true;
            else
            {

                return false;
            }
        }


        public bool validarNumerico(Control control, StringBuilder mensajeValidacion)
        {

            try
            {
                int esNumero = Convert.ToInt32(control.Text);
                return true;
            }
            catch
            {
                mensajeValidacion.AppendLine(string.Format(" El campo {0} debe ser numerico.", control.Name));
                return false;
            }
        }

        public void validarEmail(Control mail, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Persona p WHERE p.mail='{0}'", mail.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El email {0} ya existe.", mail.Text));
            };
        }

        //TODO
        public void validarDNI(string tipo, Control numero, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Persona p WHERE e.dni_tipo=(SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE {0} = e.idTipoDocumento) AND e.dni_nro={1}", tipo, numero.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El tipo de dni {0} con el numero {1} ya existe.", tipo, numero.Text));
            };
        }

        public void validarRazonSocial(Control razonSocial, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Empresa e WHERE {0} = e.razonSocial ", razonSocial.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El razón social {0} ya existe.", razonSocial.Text));
            };
        }

        public void validarCUIT( Control cuit, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Empresa e WHERE {0} = e.cuit ", cuit.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El CUIT con el numero {0} ya existe.", cuit.Text));
            };
        }

        public void validarUsuario(Control usuario, StringBuilder mensajeValidacion)
        {
            conn = Conexion.Instance;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Usuario u WHERE u.usuario='{0}'", usuario.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El usuario {0} ya existe.", usuario.Text));
            };
        }

        public DataTable ejecutarQuery(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 800;

            cmd.Connection = conn.getConexion;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tabla = new DataTable();
            tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(tabla);

            return tabla;
        }

        public bool darEscalar(SqlCommand cmd)
        {
            cmd.Connection = conn.getConexion;
            if (cmd.ExecuteScalar() != null)
                return true;
            else
                return false;
        }

    }
}
