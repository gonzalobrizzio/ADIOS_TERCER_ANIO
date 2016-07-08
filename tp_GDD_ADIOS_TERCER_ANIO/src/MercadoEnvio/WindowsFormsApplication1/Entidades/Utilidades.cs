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

        public bool validarPorcentaje(Control control, StringBuilder mensajeValidacion)
        {
            if (Convert.ToDecimal(control.Text) >= 1) 
            {
                mensajeValidacion.AppendLine(string.Format(" El {0} debe ser menor o igual a 1 (Lo cual representa al 100%)", control.Name));
                return false;
            }
            return true;
        }

        public bool validarDecimal(Control control, StringBuilder mensajeValidacion)
        {
            try
            {
                decimal esNumero = Convert.ToDecimal(control.Text);
                return true;
            }
            catch
            {
                mensajeValidacion.AppendLine(string.Format(" El campo {0} debe ser numerico.", control.Name));
                return false;
            }
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

        public void validarCantidad(string nro, StringBuilder mensajeValidacion)
        {
            if (Convert.ToInt32(nro.Length) != 8)
            {
                mensajeValidacion.AppendLine(string.Format(" Su número de documento posee menos de 8 caracteres"));
            }
        }

        public void validarDNI(string tipo, Control numero, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Persona e WHERE e.idTipoDocumento = (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE '"+tipo+"' = descripcion) AND e.documento =" + numero.Text);
            
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El tipo de dni {0} con el numero {1} ya existe.", tipo, numero.Text));
            };
        }

        public void validarRazonSocial(Control razonSocial, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Empresa e WHERE e.razonSocial = '" + razonSocial.Text + "'");
            
            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El razón social {0} ya existe.", razonSocial.Text));
            };
        }

        public void validarVisibilidad(Control visibilidad, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Visibilidad v WHERE v.nombre = '" + visibilidad.Text + "'");

            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" La visibilidad {0} ya existe.", visibilidad.Text));
            };
        }

        public void validarRol(Control rol, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM ADIOS_TERCER_ANIO.Rol r WHERE r.nombre = '" + rol.Text + "'");

            if (ejecutarQuery(query.ToString()).Rows.Count > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" El rol {0} ya existe.", rol.Text));
            };
        }

        public void validarCUIT( Control cuit, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT e.cuit FROM ADIOS_TERCER_ANIO.Empresa e WHERE e.cuit = '" + cuit.Text + "'");
            
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

        public void validarFechaDeNacimiento(DateTime fechaMax, DateTime fechaMin, DateTime fecha, StringBuilder mensajeValidacion)
        {
            if (DateTime.Compare(fecha, fechaMin) < 0)
            {
                mensajeValidacion.AppendLine(string.Format(" La fecha {0} es invalida", fecha));
            }

            if (DateTime.Compare(fecha, fechaMax) > 0)
            {
                mensajeValidacion.AppendLine(string.Format(" La fecha {0} es invalida", fecha));
            }


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
            string sacarDuracion = "SELECT duracionDias FROM ADIOS_TERCER_ANIO.Visibilidad WHERE @visibilidad = nombre";
            SqlCommand obtenerDuracion = new SqlCommand(sacarDuracion, conn.getConexion);
            SqlParameter vis = new SqlParameter("@visibilidad", SqlDbType.NVarChar, 255);
            vis.SqlValue = visibilidad;
            vis.Direction = ParameterDirection.Input;
            obtenerDuracion.Parameters.Add(vis);
            SqlDataReader dataReader = obtenerDuracion.ExecuteReader();
            dataReader.Read();
            if (!dataReader[0].Equals(DBNull.Value)) { dias = dataReader.GetInt32(0); }
            else { dias = 7; };

            dataReader.Close();

            return dias;
        }

        public void ingresarNumeroDecimal(System.Windows.Forms.KeyPressEventArgs e)
        {
            {
                String Aceptados = "," + Convert.ToChar(8);

                if (Aceptados.Contains("" + e.KeyChar) || char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public void ingresarMail(System.Windows.Forms.KeyPressEventArgs e)
        {
            {
                String Aceptados = "_.,@-" + Convert.ToChar(8);

                if (Aceptados.Contains("" + e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ' ')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public void ingresarNumero(System.Windows.Forms.KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        public void ingresarNumeroConRaya(System.Windows.Forms.KeyPressEventArgs e)
        {
            {
                String Aceptados = "-" + Convert.ToChar(8);

                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || Aceptados.Contains("" + e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        public void ingresarNombre(System.Windows.Forms.KeyPressEventArgs e)
        {
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

    }
}
