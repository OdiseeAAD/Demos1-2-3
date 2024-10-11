using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesDeel1
{
    internal class NumbersAPI
    {

        public async Task getRandomNumbers( Action<List<int>> onReady, Action<int> printGetal)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int getal = new Random().Next(100);
                numbers.Add(getal);
                printGetal(getal);
                Thread.Sleep(1000);
            }

            onReady(numbers);
        }
    }
}
