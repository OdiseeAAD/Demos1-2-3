using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Demo : IDemo
    {
        public static void Method3()
        {

        }

        private static void Method4()
        {

        }

        private int member1;

        public int Member1 { get => member1; set => member1 = value; }

        public Demo(int member1)
        {
            Member1 = member1;
        }

        public void Method1()
        {

        }

        private void Method2()
        {

        }
    }
}
