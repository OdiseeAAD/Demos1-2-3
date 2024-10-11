using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncrypter
{
    internal class ReverseAlphabetEncryptor
    {
        const string alpfabet = "abcdefghijklmnopqrstuvwxyz";
        public static string Decrypt(string toDecrypt)
        {
            return GetMirroredAlfabetString(toDecrypt);
        }

        public static string Encrypt(string toEncrypt)
        {
            return GetMirroredAlfabetString(toEncrypt);
        }

        private static string GetMirroredAlfabetString(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                     result += char.ToUpper(MirrorChar(char.ToLower(c)));

                    } else
                    {
                        result += MirrorChar(c);
                    }
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }

        private static char MirrorChar(char c)
        {
            int positie = alpfabet.IndexOf(c);
            char newChar = alpfabet[25- positie];
            return newChar;
        }
    }
}
