using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios
{
    sealed class Sesion
    {
        public int idUsuario;
        public int idRol;
        private static Sesion instance;
        public Form anterior;
        public string usuario;

        public Sesion(int usr, int rol, Form anterior, string usrS)
        {
            instance = this;
            this.idUsuario = usr;
            this.idRol = rol;
            this.anterior = anterior;
            this.usuario = usrS;
        }

        public static Sesion Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
