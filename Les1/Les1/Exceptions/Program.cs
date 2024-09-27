namespace Exceptions
{
    internal class Program
    {
        static List<int> numbers;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            //

            int x = 10;
            int y = 0;
            try
            {
                DoSomething();
                GooiException();
                numbers.Add(12);
                int resultaat = x / y;
                Console.WriteLine($"Resulaat: {resultaat}");
            }

            catch(DivideByZeroException ex)/* when (ex.Message.Contains("Zero"))*/
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullrefError");
                Console.WriteLine(ex.StackTrace);
            }
            catch(MyCustomException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ik word altijd uitgevoerd!");
            }
        }

        static void GooiException()
        {
            throw new MyCustomException();
        }

        static void DoSomething()
        {
            try
            {
                int y = 0;
                int result = 10 / y;
            }
            catch (NullReferenceException) { 
            
            }
        }
    }
}
