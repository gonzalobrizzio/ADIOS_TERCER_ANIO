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
    public partial class frmDetalle : Form
    {
        SqlDataReader dataReader;
        Conexion conn;

        Sesion sesion = Sesion.Instance;

        public frmDetalle(int id)
        {
            InitializeComponent();
            this.getData();
        }

        void getData()
        {
            String cmd = "ADIOS_TERCER_ANIO.detallePublicacion";

            SqlParameter pagina = new SqlParameter("@idPublicacion", SqlDbType.Int);
            pagina.SqlValue = nroPagina;
            pagina.Direction = ParameterDirection.Input;

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idUsuario);

            string sacarDatosClientes = "SELECT e.apellido, e.nombre, e.codigoPostal, e.direccion, e.direccion_numero, e.documento, e.dpto, (SELECT nombre FROM ADIOS_TERCER_ANIO.Localidad WHERE id = e.idLocalidad), (SELECT descripcion FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE id = e.idTipoDocumento),e.piso, e.telefono, e.fechaNacimiento  FROM ADIOS_TERCER_ANIO.Usuario p inner join ADIOS_TERCER_ANIO.Persona e on e.idUsuario = p.id WHERE @id = e.id";
            SqlCommand ObtenerCliente = new SqlCommand(sacarDatosClientes, conn.getConexion);
            SqlParameter idUs = new SqlParameter("@id", SqlDbType.Int);
            idUs.SqlValue = sesion.idUsuario;
            idUs.Direction = ParameterDirection.Input;
            ObtenerCliente.Parameters.Add(idUs);
            dataReader = ObtenerCliente.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[0].Equals(DBNull.Value)) { campoApellido.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { campoNombre.Text = dataReader.GetString(1); }
                if (!dataReader[2].Equals(DBNull.Value)) { campoCódigoPostal.Text = dataReader.GetString(2); }
                if (!dataReader[3].Equals(DBNull.Value)) { campoDireccion.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { campoNroDeDireccion.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { campoDni.Text = Convert.ToString(dataReader.GetDecimal(5)); }
                if (!dataReader[6].Equals(DBNull.Value)) { campoDepto.Text = Convert.ToString(dataReader.GetString(6)); }
                if (!dataReader[7].Equals(DBNull.Value)) { comboLocalidad.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { comboTipoDeDocumento.Text = dataReader.GetString(8); }
                if (!dataReader[9].Equals(DBNull.Value)) { campoPiso.Text = Convert.ToString(dataReader.GetDecimal(9)); }
                if (!dataReader[10].Equals(DBNull.Value)) { campoTeléfono.Text = dataReader.GetString(10); }
                if (!dataReader[11].Equals(DBNull.Value)) { campoFechaDeNacimiento.Text = Convert.ToString(dataReader.GetDateTime(11)); }
            }
            dataReader.Close();

        }



    }
}
