using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Adres : IAdres, IComparable
    {
        public Adres(string straat, string huisnummer, int postcode, string gemeente, string land)
        {
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
            Land = land;
        }

        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Land { get; set; }

        public int CompareTo(object? obj)
        {
            if(!(obj is IAdres))
            {
                throw new ArgumentException("Object is geen IAdres object");
            }

            IAdres other = obj as IAdres;

            if (Land.CompareTo(other.Land) == 0) {
                if (Gemeente.CompareTo(other.Gemeente) == 0)
                {
                    if(Straat.CompareTo(other.Straat) == 0)
                    {
                        return Huisnummer.CompareTo(other.Huisnummer);
                    } else
                    {
                        return Straat.CompareTo(other.Straat);
                    }
                }
                else
                {
                    return Gemeente.CompareTo(other.Gemeente);
                }
            }
            return Land.CompareTo(other.Land);
        }

        public override string? ToString()
        {
            return $"{Straat} {Huisnummer}, {Postcode} {Gemeente} {Land}";
        }
    }
}
