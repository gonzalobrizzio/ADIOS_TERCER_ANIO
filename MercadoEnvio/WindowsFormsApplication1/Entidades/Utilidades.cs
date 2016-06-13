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
                mensajeValidacion.AppendLine(string.Format("Lo siguiente : {0}, no puede estar vacio, debe llenarlo", combo.Name));
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
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Usuario u WHERE u.mail='{0}'", mail.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El email {0} ya existe.", mail.Text));
            };
        }

        public void validarDNI(string tipo, Control numero, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Persona e WHERE e.idTipoDocumento = (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE '{0}' = nombre) AND e.documento = {1}", tipo, numero.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El tipo de dni {0} con el numero {1} ya existe.", tipo, numero.Text));
            };
        }

        public void validarRazonSocial(Control razonSocial, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Empresa e WHERE e.razonSocial = '{0}'", razonSocial.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El razón social {0} ya existe.", razonSocial.Text));
            };
        }

        public void validarCUIT( Control cuit, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT e.cuit FROM ADIOS_TERCER_ANIO.Empresa e WHERE e.cuit = '{0}'", cuit.Text);
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El CUIT con el numero {0} ya existe.", cuit.Text));
            };
        }

        public void verSiElCuitEsValido(Control cuit, StringBuilder mensajeValidación)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("IF('{0}' NOT LIKE '%-%-%') SELECT * FROM ADIOS_TERCER_ANIO.TipoDocumento", cuit.Text);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 800;
            cmd.CommandText = query.ToString();
            if (darEscalar(cmd))
            {
                mensajeValidación.AppendLine(string.Format("El cuit tiene un formato invalido"));
            }

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


        public int obtenerDuracionDeVisibilidad(string visibilidad)
        {
            int dias = 0;
            string sacarDuracion = "SELECT duracionDias FROM ADIOS_TERCER_ANIO.Visibilidad WHERE @visibilidad = descripcion";
            SqlCommand obtenerDuracion = new SqlCommand(sacarDuracion, conn.getConexion);
            SqlParameter vis = new SqlParameter("@visibilidad", SqlDbType.NVarChar, 255);
            vis.SqlValue = visibilidad;
            vis.Direction = ParameterDirection.Input;
            obtenerDuracion.Parameters.Add(vis);
            SqlDataReader dataReader = obtenerDuracion.ExecuteReader();
            dataReader.Read();
            dias = dataReader.GetInt32(0);

            return dias;
        }
    }
}
