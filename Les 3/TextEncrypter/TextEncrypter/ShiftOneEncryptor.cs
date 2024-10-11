using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncrypter
{
    internal class ShiftOneEncryptor 
    {
        public static string Decrypt(string toDecrypt)
        {
            string result = "";

            foreach (char c in toDecrypt)
            {
                if (!char.IsLetter(c))
                {
                    result += c;
                }
                else if (c == 'a')
                {
                    result += 'z';
                }
                else if (c == 'A')
                {
                    result += 'Z';
                } else {
                    result += (char)(c - 1);
                }
            }
            return result;
        }

        public static string Encrypt(string toEncrypt)
        {
            string result = "";

            foreach (char c in toEncrypt)
            {
                if (!char.IsLetter(c))
                {
                    result += c;
                }
                else if (c == 'z')
                {
                    result += 'a';
                }
                else if (c == 'Z')
                {
                    result += 'A';
                }
                else
                {
                    result += (char)(c + 1);
                }
            }
            return result;
        }
    }
}
