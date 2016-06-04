using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace MercadoEnvios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form ingresar;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ingresar = new frmIngresar());
        }
    }
}
