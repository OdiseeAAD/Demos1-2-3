namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(1000);

            while (true)
            {
                Console.WriteLine("Welk bedrag wil je afhalen?");


                string bedrag = Console.ReadLine();

                bankAccount.HaalGeldAf(bedrag);
            }
        }
    }
}
