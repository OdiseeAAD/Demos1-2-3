using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    public class NumbersOperations
    {


        // 1. De getalen die groter of gelijk zijn aan 50
        public static IEnumerable<int> GetNumbersHigherOrEqualTo50(int[] numbers)
        {
            return numbers.Where(x=> x>=50);
        }

        // 2. De getallen tussen 30 en 60 (beide grenzen inbegrepen)
        public static IEnumerable<int> GetNumbersBetween30And60Including(int[] numbers)
        {
            return null;
        }

        // 3. Alle oneven getallen
        public static IEnumerable<int> GetOddNumbers(int[] numbers)
        {
            return null;
        }

        // 4. De getallen die zowel een veelvoud zijn van 3 als van 5
        public static IEnumerable<int> GetMultiplesOf3And5(int[] numbers)
        {
            return null;
        }

        // 5. Een IEnumerable<> waarbij elk getal vervangen werd door het dubbele van het oorspronkelijke getal
        public static IEnumerable<int> GetDoubles(int[] numbers)
        {
            return null;
        }

        // 6. Een IEnumerable<> waarbij elk oneven getal vervangen werd door de helft van het oorspronkelijke getal
        public static IEnumerable<double> GetHalfOfOddNumbers(int[] numbers)
        {
            return null;
        }

        // 7. Het aantal getallen die een veelvoud zijn van 5 (tip: maak hiervoor uitsluitend gebruik van de Count(..)-methode!)
        public static int CountMultiplesOf5(int[] numbers)
        {
            return 0;
        }

        // 8. Het laatste getal in de array waarvan het kwadraat kleiner is dan 2000 (Tip: maak hiervoor uitsluitend gebruik van de methode Last(..)!
        public static int GetLastNumberWithSquareSmallerThan2000(int[] numbers)
        {
            return 0;
        }

        // 9. De som van alle getallen die deelbaar zijn door 5 of 6.
        public static int GetSumOfNumbersDividebleBy5Or6(int[] numbers)
        {
            return 0;
        }

        // 10. Alle oneven getallen in de array, gesorteerd van groot naar klein
        public static IEnumerable<int> GetAllOddNumbersSortedDescending(int[] numbers)
        {
            return null;
        }
    }
}
