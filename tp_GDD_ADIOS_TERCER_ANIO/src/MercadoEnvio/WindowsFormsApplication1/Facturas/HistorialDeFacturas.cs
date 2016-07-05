using MercadoEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Facturas
{
    public partial class HistorialDeFacturas : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;
        Utilidades fun = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();
        int cantidad;
        int nroPagina = 0;
        Sesion sesion;
        public HistorialDeFacturas()
        {
            InitializeComponent();
            sesion = Sesion.Instance;
            this.getData();

            if(dgvFacturas.Rows.Count == 0){
                btnAnt.Enabled = false;
                btnSgte.Enabled = false;
                btnFiltrar.Enabled = false;
            }

            if (sesion.idRol != 1)
            {
                checkBox3.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                destinatarioTxt.Visible = false;
            }
        }

        private void getData()
        {
            DateTime fechaDesdeD = DateTime.ParseExact("1900-02-28 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                            System.Globalization.CultureInfo.InvariantCulture);
            DateTime fechaHastaD = DateTime.ParseExact("3000-05-28 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
            decimal desdePrecioD = -1;
            decimal hastaPrecioD = -1;
            string descripcionD = "";
            string destinatarioD = "";
           
           if (checkBox1.Checked)
           {
               if (fechaDesdeDtp.Value < fechaHastaDtp.Value)
               {
                   fechaDesdeD = fechaDesdeDtp.Value;
                   fechaHastaD = fechaHastaDtp.Value;
               }
               else
               {
                   fechaHastaD = fechaDesdeDtp.Value;
                   fechaDesdeD = fechaHastaDtp.Value;
               }
           }

           if (checkBox2.Checked)
           {

               if (fun.validarNoVacio(desdePrecioTxt, mensajeValidacion) && fun.validarNoVacio(hastaPrecioTxt, mensajeValidacion))
               {
                   if (fun.validarDecimal(hastaPrecioTxt, mensajeValidacion) && fun.validarDecimal(hastaPrecioTxt, mensajeValidacion))
                   {
                       if (Convert.ToDecimal(desdePrecioTxt.Text) < Convert.ToDecimal(hastaPrecioTxt.Text))
                       {
                           desdePrecioD = Convert.ToDecimal(desdePrecioTxt.Text);
                           hastaPrecioD = Convert.ToDecimal(hastaPrecioTxt.Text);
                       }
                       else
                       {
                           hastaPrecioD = Convert.ToDecimal(desdePrecioTxt.Text);
                           desdePrecioD = Convert.ToDecimal(hastaPrecioTxt.Text);
                       }

                   }
               }

           }

           if (checkBox4.Checked)
           {
                    descripcionD = descripcionTxt.Text;
           }

           if (checkBox3.Checked)
           {
                   destinatarioD = destinatarioTxt.Text;
           }

           if (mensajeValidacion.Length == 0)
           {
               //ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT, @idRol INT, @fechaDesde DATETIME,
               //@fechaHasta DATETIME, @desdePrecio DECIMAL(18,2), @hastaPrecio DECIMAL (18,2),
               //@descripcion NVARCHAR(255), @destinatario NVARCHAR(255))
               String cmd = "ADIOS_TERCER_ANIO.obtenerFacturasPaginaN";

               SqlParameter cant = new SqlParameter("@cant", SqlDbType.Int);
               cant.SqlValue = DBNull.Value;
               cant.Direction = ParameterDirection.Output;

               SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
               idUsuario.SqlValue = sesion.idUsuario;
               idUsuario.Direction = ParameterDirection.Input;

               SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
               pagina.SqlValue = nroPagina;
               pagina.Direction = ParameterDirection.Input;

               SqlParameter idRol = new SqlParameter("@idRol", SqlDbType.Int);
               idRol.SqlValue = sesion.idRol;
               idRol.Direction = ParameterDirection.Input;

               SqlParameter fechaDesde = new SqlParameter("@fechaDesde", SqlDbType.DateTime);
               if (Convert.ToString(fechaDesdeD) != "" || Convert.ToString(fechaDesdeD) != null)
               {
                   fechaDesde.SqlValue = fechaDesdeD;
                   fechaDesde.Direction = ParameterDirection.Input;
               }
               else
               {
                   fechaDesde.SqlValue = DBNull.Value;
                   fechaDesde.Direction = ParameterDirection.Input;
               }

               SqlParameter fechaHasta = new SqlParameter("@fechaHasta", SqlDbType.DateTime);
               if (Convert.ToString(fechaHastaD) != "" || Convert.ToString(fechaHastaD) != null)
               {
                   fechaHasta.SqlValue = fechaHastaD;
                   fechaHasta.Direction = ParameterDirection.Input;
               }
               else
               {
                   fechaHasta.SqlValue = DBNull.Value;
                   fechaHasta.Direction = ParameterDirection.Input;
               }

               SqlParameter desdePrecio = new SqlParameter("@desdePrecio", SqlDbType.Decimal);
               desdePrecio.SqlValue = desdePrecioD;
               desdePrecio.Direction = ParameterDirection.Input;

               SqlParameter hastaPrecio = new SqlParameter("@hastaPrecio", SqlDbType.Decimal);
               hastaPrecio.SqlValue = hastaPrecioD;
               hastaPrecio.Direction = ParameterDirection.Input;

               SqlParameter descripcion = new SqlParameter("@descripcion", SqlDbType.NVarChar, 255);
               descripcion.SqlValue = descripcionD;
               descripcion.Direction = ParameterDirection.Input;

               SqlParameter destinatario = new SqlParameter("@destinatario", SqlDbType.NVarChar, 255);
               destinatario.SqlValue = destinatarioD;
               destinatario.Direction = ParameterDirection.Input;

               da = new SqlDataAdapter(cmd, conn.getConexion);
               da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
               da.SelectCommand.Parameters.Add(idUsuario);
               da.SelectCommand.Parameters.Add(pagina);
               da.SelectCommand.Parameters.Add(idRol);
               da.SelectCommand.Parameters.Add(destinatario);
               da.SelectCommand.Parameters.Add(descripcion);
               da.SelectCommand.Parameters.Add(fechaHasta);
               da.SelectCommand.Parameters.Add(fechaDesde);
               da.SelectCommand.Parameters.Add(desdePrecio);
               da.SelectCommand.Parameters.Add(hastaPrecio);
               da.SelectCommand.Parameters.Add(cant);

               try
               {
                   da.SelectCommand.ExecuteNonQuery();
                   DataTable tablaDeFacturas = new DataTable("Facturas");
                   da.Fill(tablaDeFacturas);
                   dgvFacturas.DataSource = tablaDeFacturas;
                   dgvFacturas.Columns[0].Width = 150;
                   dgvFacturas.Columns[1].Width = 100;
                   dgvFacturas.Columns[2].Width = 100;
                   dgvFacturas.Columns[3].Width = 100;
                   dgvFacturas.AllowUserToDeleteRows = false;
                   dgvFacturas.AllowUserToAddRows = false;
                   dgvFacturas.ReadOnly = true;
                   if (nroPagina == 0)
                   {
                       cantidad = Convert.ToInt32(da.SelectCommand.Parameters["@cant"].Value) / 10;
                       btnPrimeraPag.Enabled = false;
                   }

                   if (nroPagina >= cantidad)
                   {
                       if (btnSgte.Enabled == true)
                       {
                           btnSgte.Enabled = false;
                       }
                   }
                   else
                   {
                       btnSgte.Enabled = true;
                   }

                   if (nroPagina == 0 && dgvFacturas.Rows.Count < 10)
                   {
                       if (btnAnt.Enabled == true)
                       {
                           btnAnt.Enabled = false;
                       }

                       if (btnSgte.Enabled == false)
                       {
                           btnSgte.Enabled = false;
                       }

                       if (btnPrimeraPag.Enabled == true)
                       {
                           btnPrimeraPag.Enabled = false;
                       }

                       if (button1.Enabled == true)
                       {
                           button1.Enabled = false;
                       }
                   }
                   else
                   {
                       button1.Enabled = true;
                       btnSgte.Enabled = true;
                       btnAnt.Enabled = true;
                   }
               }
               catch (SqlException error)
               {
                   btnSgte.Enabled = false;
                   MessageBox.Show("No hay páginas para mostrar con esos valores");
               }
           }
           else 
           {
               MessageBox.Show(Convert.ToString(mensajeValidacion));
               mensajeValidacion = new StringBuilder();
           }

           if (nroPagina == 0)
           {
               btnAnt.Enabled = false;
           }

        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            btnSgte.Enabled = true;
            this.getData();
        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            if (nroPagina <= cantidad)
            {
                nroPagina++;
                btnAnt.Enabled = true;
                btnPrimeraPag.Enabled = true;
                this.getData();
            }
            else
            {
                btnSgte.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new MercadoEnvios.ABM_Usuario.frmPantallaPrincipal().Show();
            this.Close();
        }

        private void HistorialDeFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            nroPagina = 0;
            this.getData();
            btnSgte.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fechaDesdeDtp.Enabled = true;
                fechaHastaDtp.Enabled = true;
            }
            else
            {
                fechaDesdeDtp.Enabled = false;
                fechaHastaDtp.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                desdePrecioTxt.ReadOnly = false;
                hastaPrecioTxt.ReadOnly = false;
            }
            else
            {
                desdePrecioTxt.ReadOnly = true;
                hastaPrecioTxt.ReadOnly = true;
                desdePrecioTxt.Text = "";
                hastaPrecioTxt.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                destinatarioTxt.ReadOnly = false;
            }
            else
            {
                destinatarioTxt.ReadOnly = true;
                destinatarioTxt.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                descripcionTxt.ReadOnly = false;
            }
            else
            {
                descripcionTxt.ReadOnly = true;
                descripcionTxt.Text = "";
            }
        }

        private void desdePrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumeroDecimal(e);
        }

        private void hastaPrecioTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.ingresarNumeroDecimal(e);
        }

        private void destinatarioTxt_TextChanged(object sender, EventArgs e)
        {
            nroPagina = 0;
            this.getData();
            btnSgte.Enabled = true;
        }

        private void descripcionTxt_TextChanged(object sender, EventArgs e)
        {
            nroPagina = 0;
            this.getData();
            btnSgte.Enabled = true;
        }

        private void fechaHastaDtp_ValueChanged(object sender, EventArgs e)
        {
            nroPagina = 0;
            this.getData();
            btnSgte.Enabled = true;
        }

        private void fechaDesdeDtp_ValueChanged(object sender, EventArgs e)
        {
            nroPagina = 0;
            this.getData();
            btnSgte.Enabled = true;
        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            nroPagina = 0;
            this.getData();
            btnSgte.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nroPagina = cantidad;
            this.getData();
            btnPrimeraPag.Enabled = true;
            btnSgte.Enabled = false;
            btnAnt.Enabled = true;
            button1.Enabled = false;
        }
    }
}