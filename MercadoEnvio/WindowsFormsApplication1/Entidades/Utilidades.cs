using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MercadoEnvios.Entidades
{
    class Utilidades
    {
        public static  String encriptarCadenaSHA256(String s)
        {
            SHA256Managed hasher = new SHA256Managed();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(s);
            byte[] passwordHash = hasher.ComputeHash(passwordBytes);
            string hashString = string.Empty;
            foreach (byte x in passwordHash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
