using Spectre.Console;
using System.Linq;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = GetListOfCars();
       

            PrintRule("Alle auto's");
            PrintList(cars);

            PrintRule("Auto's met een prijs lager dan 10000");
            PrintList(CarOperations.GetCarsWithAPriceLessThan10000(cars));

            PrintRule("Auto's met een prijs lager dan 15000 en gebouwd na 2016");
            PrintList(CarOperations.GetAllCarsWithAPriceLessThan15000AndBuildAfter2016(cars));

            PrintRule("Alle unieke modelnamen");
            PrintList(CarOperations.GetAllUniqueModelNames(cars));

            PrintRule("Alle unieke modelnamen van auto's met automatische transmissie");
            PrintList(CarOperations.GetAllUniqueModelNamesOfCarsWithAutomaticTransmission(cars));

            PrintRule("Gemiddelde prijs van alle auto's met manuele transmissie");
            AnsiConsole.WriteLine(CarOperations.GetAveragePriceOfCarsWithManualsTransmission(cars));

            PrintRule("Prijs van de duurste ford"); 
            AnsiConsole.WriteLine(CarOperations.GetPriceOfMostExpensiveFord(cars));

            PrintRule("3 goedkoopste wagens, gebouwd na 2016");
            PrintList(CarOperations.Get3CheapestCarsBuildAfter2016(cars));

            PrintRule("aantal auto's met manuale transmissie en een kost lager dan 12500");
            AnsiConsole.WriteLine(CarOperations.GetNumberOfManualCarsThatCostLessThan12500(cars));

            PrintRule("Alle autimatische wagens gesorteerd volgens prijs aflopend");
            PrintList(CarOperations.GetAutomaticCarsSortedByPriceDescending(cars));

            PrintRule("Alle unieke merken van auto's die meer kosten dan 12000 omgekeerd alfabetisch gesorteerd ");
            PrintList(CarOperations.GetUniqueMakesFromCarsThatCostMoreThan12000SortAlfabeticallyDescending(cars));
        }

        private static void PrintRule(string title)
        {
            AnsiConsole.Write(new Rule(title));
        }

        private static void PrintList<T>(IEnumerable<T> items)
        {
            if (items == null)
            {
                AnsiConsole.WriteLine();
                return;
            }
            else
            {
                foreach (T item in items)
                {
                    AnsiConsole.WriteLine(item.ToString());
                }

            }
        }

        private static List<Car> GetListOfCars()
        {
            return new List<Car> {
                new Car("VW", "Golf", 2017, 17495, Transmission.MANUAL),
                new Car("VW", "Polo", 2015, 9850, Transmission.AUTOMATIC),
                new Car("Opel", "Astra", 2016, 11450, Transmission.AUTOMATIC),
                new Car("VW", "Golf", 2018, 18320, Transmission.AUTOMATIC),
                new Car("Ford", "Focus", 2016, 8715, Transmission.MANUAL),
                new Car("Opel", "Corsa", 2017, 9120, Transmission.MANUAL),
                new Car("Ford", "Fiësta", 2016, 7890, Transmission.AUTOMATIC)
            };
        }
    }
}
