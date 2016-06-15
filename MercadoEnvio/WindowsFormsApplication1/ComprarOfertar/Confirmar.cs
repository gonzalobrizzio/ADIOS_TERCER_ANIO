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
    public partial class frmConfirmar : Form
    {
        SqlDataReader dataReader;
        Conexion conn = Conexion.Instance;
        int idPublicacion;
        String tipoCompra;

        Sesion sesion = Sesion.Instance;

        public frmConfirmar(int id)
        {
            InitializeComponent();
            idPublicacion = id;
            this.getData();
        }

        void getData()
        {
            String cmd = "ADIOS_TERCER_ANIO.detallePublicacion";
            SqlCommand detallePublicacion = new SqlCommand(cmd, conn.getConexion);
            detallePublicacion.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter idP = new SqlParameter("@idPublicacion", SqlDbType.Int);
            idP.SqlValue = idPublicacion;
            idP.Direction = ParameterDirection.Input;
            detallePublicacion.Parameters.Add(idP);

            dataReader = detallePublicacion.ExecuteReader();
            dataReader.Read();

            if (dataReader.HasRows)
            {
                if (!dataReader[3].Equals(DBNull.Value))
                {
                    tipoCompra = dataReader.GetString(3);
                    if (tipoCompra.Equals("Compra inmediata")) {
                        btnConfirmar.Text = "Comprar";
                        lblNumeric.Text = "Cantidad";
                        if (!dataReader[8].Equals(DBNull.Value)) { lblCantPrecio.Text = "Cantidad máxima: " + dataReader.GetInt32(8).ToString(); }
                    }
                    else {
                        btnConfirmar.Text = "Ofertar";
                        lblNumeric.Text = "Monto: ";
                        if (!dataReader[4].Equals(DBNull.Value)) { lblCantPrecio.Text = "Monto minimo: " + Convert.ToString(dataReader.GetDecimal(4)); }
                    }
                }
                
                if (!dataReader[0].Equals(DBNull.Value)) { this.Text = btnConfirmar.Text + " " + dataReader.GetString(0); }
            }
            dataReader.Close();
        }
    }
}
