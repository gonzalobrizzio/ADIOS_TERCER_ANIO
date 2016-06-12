using MercadoEnvios.ABM_Usuario;
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

namespace MercadoEnvios.Generar_Publicación
{
    public partial class frmGenerarPublicacion : Form
    {
        Conexion conn;
        Sesion sesion;
        Utilidades funcion = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();
        public frmGenerarPublicacion()
        {
            InitializeComponent();
            this.conn = Conexion.Instance;
            this.loadGrid();
        }

        private void loadGrid()
        {

            rubrosSeleccionados.ColumnCount = 2;
            rubrosSeleccionados.ColumnHeadersVisible = true;
            rubrosSeleccionados.Columns[1].Name = "Rubro";
            rubrosSeleccionados.Columns[0].Name = "ID";
            rubrosSeleccionados.Columns[0].Visible = false;

            rubros.ColumnCount = 2;
            rubros.ColumnHeadersVisible = true;
            rubros.Columns[1].Name = "Rubro";
            rubros.Columns[0].Name = "ID";
            rubros.Columns[0].Visible = false;

            rubros.Columns[1].Width = 350;
            rubrosSeleccionados.Columns[1].Width = 350;

            String rubrosDisponibles = "SELECT r.id, r.descripcionCorta FROM ADIOS_TERCER_ANIO.Rubro r";
            conn = Conexion.Instance;
            SqlCommand buscarRubrosDisponibles = new SqlCommand(rubrosDisponibles, conn.getConexion);
            SqlDataReader dabuscarRubrosDisponibles = buscarRubrosDisponibles.ExecuteReader();

            if (dabuscarRubrosDisponibles.HasRows)
            {
                while (dabuscarRubrosDisponibles.Read())
                {
                    DataGridViewRow rowdgvRubrosDisponibles = (DataGridViewRow)rubros.Rows[0].Clone();
                    rowdgvRubrosDisponibles.Cells[1].Value = dabuscarRubrosDisponibles.GetString(1).ToString();
                    rowdgvRubrosDisponibles.Cells[0].Value = dabuscarRubrosDisponibles.GetInt32(0);
                    rubros.Rows.Add(rowdgvRubrosDisponibles);
                }
            }
            dabuscarRubrosDisponibles.Close();

            rubros.AllowUserToAddRows = false;
            rubros.AllowUserToDeleteRows = false;
            rubrosSeleccionados.AllowUserToAddRows = false;
            rubrosSeleccionados.AllowUserToDeleteRows = false;

            string queryVisibilidad = "SELECT descripcion FROM ADIOS_TERCER_ANIO.Visibilidad";
            SqlCommand buscarVisibilidades = new SqlCommand(queryVisibilidad, conn.getConexion);
            SqlDataReader dataReader = buscarVisibilidades.ExecuteReader();
            while (dataReader.Read())
            {
                visibilidad.Items.Add(dataReader.GetString(0));
            }

            dataReader.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            funcion.validarComboVacio(visibilidad, mensajeValidacion);
            funcion.validarComboVacio(tipoDePublicacion, mensajeValidacion);
            funcion.validarNoVacio(descripcion, mensajeValidacion);
            funcion.validarNoVacio(precio, mensajeValidacion);

            bool validaciones;

            if (rubrosSeleccionados.Rows.Count == 0)
            {
                mensajeValidacion.AppendLine("No ha agregado funcionalidades a el rol que desea crear");
            }

            if (mensajeValidacion.Length > 0)
            {
                validaciones = false;
                MessageBox.Show(mensajeValidacion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensajeValidacion = new StringBuilder();

            }
            else
            {validaciones = true;}

            if (validaciones)
            {

                new frmPantallaPrincipal().Show();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in rubros.SelectedRows) 
            {
                object[] values = {
                                      row.Cells["ID"].Value,
                                      row.Cells["Rubro"].Value
                                  };
                DataGridViewRow rowp = (DataGridViewRow) rubros.Rows[0].Clone();
                rowp.Cells[0].Value = values[0];
                rowp.Cells[1].Value = values[1];
                rubrosSeleccionados.Rows.Add(rowp);
                rubros.Rows.Remove(row);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rowPrincipal in rubrosSeleccionados.SelectedRows)
            {
                object[] values = {
                                          rowPrincipal.Cells["ID"].Value,
                                          rowPrincipal.Cells["Rubro"].Value
                                  };
                DataGridViewRow row = (DataGridViewRow)rubrosSeleccionados.Rows[0].Clone();
                row.Cells[0].Value = values[0];
                row.Cells[1].Value = values[1];
                rubros.Rows.Add(row);
                rubrosSeleccionados.Rows.Remove(rowPrincipal);

            }
        }
    }


}
