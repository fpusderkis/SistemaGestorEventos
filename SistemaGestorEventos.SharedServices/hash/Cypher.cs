using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SistemaGestorEventos.SharedServices.hash
{
    public class Cypher
    {
        private static readonly MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
        public static string Hash(string value, Guid seed)
        {
            var md5data = md5Provider.ComputeHash(Encoding.ASCII.GetBytes(value + seed));
            return (new ASCIIEncoding()).GetString(md5data);
        }
    }
}
