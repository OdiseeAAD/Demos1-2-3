using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesDeel1
{
    internal class EersteDelegate
    {
        delegate void VoidMethode();

        VoidMethode v;

        public void Start()
        {
            v = Doiets;

            v();
        }

        private void Doiets()
        {
            Console.WriteLine("ik doe iets");
        }
    }
}
