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
            if (Budget < bedrag)
            {
                throw new BudgetTeLaagException();
            }
            Budget -= bedrag;
        }
    }

    class BudgetTeLaagException : Exception
    {
        public BudgetTeLaagException() : base("Budget is te laag")
        {

        }
    }
}
