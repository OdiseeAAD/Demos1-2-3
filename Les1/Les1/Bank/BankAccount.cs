using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        public int Budget { get; set; }

        public BankAccount(int budget)
        {
            Budget = budget;
        }

        public void HaalGeldAf(string bedragString)
        {
            int bedrag = int.Parse(bedragString);
            Budget -= bedrag;
        }
    }
}
