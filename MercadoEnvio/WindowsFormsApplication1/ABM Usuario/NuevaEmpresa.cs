using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmNuevaEmpresa : Form
    {
        SqlCommand agregar;
        SqlParameter idUsuario;
        public frmNuevaEmpresa(SqlCommand agregarUsuario, SqlParameter id)
        {
            InitializeComponent();
            agregar = agregarUsuario;
            idUsuario = id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            SqlParameter mail = new SqlParameter("@mail", SqlDbType.NVarChar, 255);
            mail.SqlValue = null;
            mail.Direction = ParameterDirection.Input;
            agregar.Parameters.Add(mail);
            agregar.ExecuteNonQuery();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmABMUsuario().Show();
            this.Close();
        }
    }
}
