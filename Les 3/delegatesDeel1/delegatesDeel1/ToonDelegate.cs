using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace delegatesDeel1
{
    internal class ToonDelegate
    {
        delegate void ToonMethode(int x, int y);
        delegate void StuurDataMethode(int x, int y);

        Action<int, int> toonMethode;
        Func<int, int, double> berekenMethode;

        public void Start()
        {
            toonMethode = ToonSom;
            toonMethode += ToonVerschil;
            toonMethode(10,5);
            toonMethode -= ToonSom;
            toonMethode(100, 20);
            toonMethode = ToonSom;

            toonMethode(100, 100);

            berekenMethode = BerekenSom;
        }

        public void ToonSom(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void ToonVerschil(int x, int y)
        {
           Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public double BerekenSom (int i, int j)
        {
            return i + j;
        }
    }
}
