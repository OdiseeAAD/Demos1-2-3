using System.Collections.Generic;
using System.Linq;

namespace Car
{
    class CarOperations
    {

        //1. Een List<> met alle auto’s die minder kosten dan €10.000,00 (tip: gebruik de ToList()-methode van IEnumerable<> om een IEnumerable om te zetten naar een List<>).
        public static IEnumerable<Car> GetCarsWithAPriceLessThan10000(List<Car> cars)
        {
            return null; ;
        }

        //2. Alle auto’s die minder kosten dan €15.000,00 en die ná 2016 gebouwd zijn.
        public static IEnumerable<Car> GetAllCarsWithAPriceLessThan15000AndBuildAfter2016(List<Car> cars)
        {
            return null;
        }

        //3. Een IEnumerable<> met alle model-namen van de verschillende auto’s (tip: gebruik de methode Distinct() om duplicaten te verwijderen).
        public static IEnumerable<string> GetAllUniqueModelNames(List<Car> cars)
        {
            return null;
        }

        //4. Een List<> met de model-namen van alle auto’s met een automatische transmissie.Verwijder eventuele duplicaten!
        public static  IEnumerable<string> GetAllUniqueModelNamesOfCarsWithAutomaticTransmission(List<Car> cars)
        {
            return null;
        }

        //5. Bereken de gemiddelde prijs van de auto’s met een manuele transmissie.
        public static double GetAveragePriceOfCarsWithManualsTransmission(List<Car> cars)
        {
            return 0.0;
        }

        //6. De prijs van de duurste auto van het merk Ford.
        public static double GetPriceOfMostExpensiveFord(List<Car> cars)
        {
            return 0.0;
        }

        //7. De drie goedkoopste auto’s met een bouwjaar ná 2016 (tip: maak gebruik van de methode Take(..) om het aantal resultaten te beperken).
        public static IEnumerable<Car> Get3CheapestCarsBuildAfter2016(List<Car> cars)
        {
            return null;
        }

        //8. Het aantal auto’s met een manuele transmissie die minder kosten dan €12.500,00.
        public static int GetNumberOfManualCarsThatCostLessThan12500(List<Car> cars)
        {
            return 0;
        }

        //9. Een List<> met de auto’s die een automatische transmissie hebben, gesorteerd van duur naar goedkoop.
        public static List<Car> GetAutomaticCarsSortedByPriceDescending(List<Car> cars)
        {
            return null;
        }

        //10. Een lijst met de merknamen van de auto’s die meer kosten dan €12.000,00, alfabetische gesorteerd (aflopend). Vermijd dubbels!
        public static IEnumerable<string> GetUniqueMakesFromCarsThatCostMoreThan12000SortAlfabeticallyDescending(List<Car> cars)
        {
            return null;
        }
    }
}
