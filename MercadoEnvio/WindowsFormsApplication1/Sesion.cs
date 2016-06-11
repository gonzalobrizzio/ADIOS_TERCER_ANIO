using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoEnvios
{
    sealed class Sesion
    {
        public int idUsuario;
        public int idRol;
        private static Sesion instance;

        public Sesion(int usr, int rol)
        {
            instance = this;
            this.idUsuario = usr;
            this.idRol = rol;
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
