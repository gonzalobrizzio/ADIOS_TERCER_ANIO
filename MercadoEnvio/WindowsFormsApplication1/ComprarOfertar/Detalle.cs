﻿using System;
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
        Conexion conn = Conexion.Instance;
        int idPublicacion;

        Sesion sesion = Sesion.Instance;

        public frmDetalle(int id)
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
                //publicacion.descripcion, publicacion.fechaInicio, publicacion.fechaFin,  tipo.nombre, 
                //publicacion.precio, visib.nombre, usr.usuario, rubro.descripcionCorta, 
                //publicacion.stock from ADIOS_TERCER_ANIO.Publicacion publicacion
                lblIdPublicacion.Text = idPublicacion.ToString();
                if (!dataReader[0].Equals(DBNull.Value)) { lblDescripcion.Text = dataReader.GetString(0); }
                if (!dataReader[1].Equals(DBNull.Value)) { lblFechaInicio.Text = Convert.ToString(dataReader.GetDateTime(1)); }
                if (!dataReader[2].Equals(DBNull.Value)) { lblFechaFin.Text = Convert.ToString(dataReader.GetDateTime(2)); }
                if (!dataReader[3].Equals(DBNull.Value)) { lblTipo.Text = dataReader.GetString(3); }
                if (!dataReader[4].Equals(DBNull.Value)) { lblPrecio.Text = Convert.ToString(dataReader.GetDecimal(4)); }
                if (!dataReader[5].Equals(DBNull.Value)) { lblVis.Text = dataReader.GetString(5); }
                if (!dataReader[6].Equals(DBNull.Value)) { lblUsuario.Text = dataReader.GetString(6); }
                if (!dataReader[7].Equals(DBNull.Value)) { lblRubro.Text = dataReader.GetString(7); }
                if (!dataReader[8].Equals(DBNull.Value)) { lblStock.Text = dataReader.GetInt32(8).ToString() + " unidades disponibles."; }
                if (!dataReader[9].Equals(DBNull.Value)) {
                    if(dataReader.GetInt32(9) == 1){ lblEnvio.Text = "Con envío";}
                    else { lblEnvio.Text = "Sin envío"; }
                }
            }
            dataReader.Close();

        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            SqlCommand nuevaPregunta = new SqlCommand("ADIOS_TERCER_ANIO.NuevaPregunta", conn.getConexion);
            nuevaPregunta.CommandType = System.Data.CommandType.StoredProcedure;

            //ADIOS_TERCER_ANIO.NuevaPregunta (@idPublicacion INT, @fecha DATETIME, @pregunta NVARCHAR(255), @idUsuario INT)

            SqlParameter idPubli = new SqlParameter("@idPublicacion", SqlDbType.Int);
            idPubli.SqlValue = idPublicacion;
            idPubli.Direction = ParameterDirection.Input;

            SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
            fecha.SqlValue = DateTime.Today;
            fecha.Direction = ParameterDirection.Input;

            SqlParameter preguntaP = new SqlParameter("@pregunta", SqlDbType.NVarChar, 255);
            preguntaP.SqlValue = txtPregunta.Text;
            preguntaP.Direction = ParameterDirection.Input;

            SqlParameter idUsu = new SqlParameter("@idUsuario", SqlDbType.Int);
            idUsu.SqlValue = sesion.idUsuario;
            idUsu.Direction = ParameterDirection.Input;

            nuevaPregunta.Parameters.Add(idPubli);
            nuevaPregunta.Parameters.Add(fecha);
            nuevaPregunta.Parameters.Add(preguntaP);
            nuevaPregunta.Parameters.Add(idUsu);
        }



    }
}
