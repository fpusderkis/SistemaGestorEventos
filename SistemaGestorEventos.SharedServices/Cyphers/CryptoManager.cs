using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Cyphers
{

    public class CryptoManager
    {
        private string privateKey;

        private CryptoManager() { }

        public CryptoManager(string key) {
            this.privateKey = key;
        }

        public string DesencriptadoSimetrico(string textoCifrado)
        {
            byte[] cipherBytes = Convert.FromBase64String(textoCifrado);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(this.privateKey, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    textoCifrado = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return textoCifrado;
        }

        public string EncriptadoSimetrico(string textoPlano)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(textoPlano);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(this.privateKey, new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    textoPlano = Convert.ToBase64String(ms.ToArray());
                }
            }
            return textoPlano;
        }

    }

}

