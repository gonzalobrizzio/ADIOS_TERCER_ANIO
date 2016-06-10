using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoEnvios
{
    sealed class Sesion
    {
        public int idUsuario;
        public string[] idRol = {null, null, null, null, null};
        public int cantidadRoles;

        public static Sesion Instance
        {
            get
            {
                return new Sesion();
            }
        }

        public void agregarRol(string rol){
            int i = 0;
            while (this.idRol[i] != null) i++;
            idRol[i] = String.Copy(rol);
        }
    }
}
