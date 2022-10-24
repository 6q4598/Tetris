using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pswHash {

    /*
     * 
     * Class Encrypt
     * 
     * Encrypt and Desencrypt a string with MD5 method.
     * 
     */

    internal class EncryptClass {

        public string Encrypt (string input) {

            string hash = "¿Estás sugiriendo la migración del coco?";
            byte[] data = Encoding.UTF8.GetBytes (input);
            MD5 md5 = MD5.Create ();
            TripleDES tripleDES = TripleDES.Create ();
            tripleDES.Key = md5.ComputeHash (UTF32Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock (data, 0, data.Length);

            return Convert.ToBase64String (result);

        }

        public string Decrypt (string input) {

            string hash = "¿Estás sugiriendo la migración del coco?";
            // string hash = "coding con c#";

            byte[] data = Convert.FromBase64String(input);
            MD5 md5 = MD5.Create();
            TripleDES tripleDes = TripleDES.Create();
            tripleDes.Key = md5.ComputeHash(UTF32Encoding.UTF8.GetBytes(hash));
            tripleDes.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF32Encoding.UTF8.GetString(result);

        }

    }

}

