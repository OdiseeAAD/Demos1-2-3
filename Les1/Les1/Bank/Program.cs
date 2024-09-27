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

                try
                {
                    bankAccount.HaalGeldAf(bedrag);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dit is geen geldig formaat");
                }
                catch(BudgetTeLaagException ex)
                {
                    Console.WriteLine(ex.Message);
                } finally
                {
                    Console.WriteLine($"Je huidige budget is {bankAccount.Budget}");
                }
            }
        }
    }
}
