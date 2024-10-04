using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IAdres
    {
        string Straat { get; }
        string Huisnummer { get; }
        int Postcode { get;}
        string Gemeente { get; }
        string Land { get;  }

        string? ToString();
    }
}
