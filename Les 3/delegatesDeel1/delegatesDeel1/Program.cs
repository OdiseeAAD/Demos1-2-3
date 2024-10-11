
namespace delegatesDeel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //EersteDelegate ed = new EersteDelegate();

            //ed.Start();

            //ToonDelegate td = new ToonDelegate();
            //td.Start();

            NumbersAPI numbersAPI = new NumbersAPI();

            var numbers = numbersAPI.getRandomNumbers(PrintNumbers, PrintNumber);
            string s = Console.ReadLine();

            
        }

        private static void PrintNumber(int i)
        {
            Console.WriteLine(i);
        }

        private static void PrintNumbers(List<int> numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
