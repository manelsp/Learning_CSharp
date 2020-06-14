using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encriptacio
{
    public class Encriptar
    {
        public Encriptar()
        {

        }

        public string GenerarHash(string contrasenya)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] Hash = md5.ComputeHash(Encoding.ASCII.GetBytes(contrasenya));

            return Convert.ToBase64String(Hash);
        }
    }
}
