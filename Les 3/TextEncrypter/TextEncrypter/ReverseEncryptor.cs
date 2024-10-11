using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncrypter
{
    internal class ReverseEncryptor
    {
        public static string Decrypt(string toDecrypt)
        {
            return new string(toDecrypt.ToArray().Reverse().ToArray());
        }

        public static string Encrypt(string toEncrypt)
        {
            return Decrypt(toEncrypt);
        }
    }
}
