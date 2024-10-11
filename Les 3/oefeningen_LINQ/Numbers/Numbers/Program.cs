using Spectre.Console;
using System;
using System.Collections.Generic;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GetRandomArray(10);
           

            PrintRule("Start nummers");
            PrintArray(numbers);

            PrintRule("nummers hoger dan of gelijk aan 50");
            PrintArray(NumbersOperations.GetNumbersHigherOrEqualTo50(numbers));

            PrintRule("nummers tussen 30 en 60");
            PrintArray(NumbersOperations.GetNumbersBetween30And60Including(numbers));

            PrintRule("Oneven nummers");
            PrintArray(NumbersOperations.GetOddNumbers(numbers));

            PrintRule("nummers deelbaar door 3 en 5");
            PrintArray(NumbersOperations.GetMultiplesOf3And5(numbers));

            PrintRule("dubbele van de nummers");
            PrintArray(NumbersOperations.GetDoubles(numbers));

            PrintRule("de helft van alle oneven nummers");
            PrintArray(NumbersOperations.GetHalfOfOddNumbers(numbers));

            PrintRule("aantal getallen deelbaar door 5");
            AnsiConsole.WriteLine(NumbersOperations.CountMultiplesOf5(numbers));

            PrintRule("Het laatste nummer met een kwadraat kleiner dan 2000");
            AnsiConsole.WriteLine(NumbersOperations.GetLastNumberWithSquareSmallerThan2000(numbers));

            PrintRule("Som van alle getallen deelbaar door 5 of 6");
            AnsiConsole.WriteLine(NumbersOperations.GetSumOfNumbersDividebleBy5Or6(numbers));

            PrintArray(NumbersOperations.GetAllOddNumbersSortedDescending(numbers));

        }

        private static void PrintRule(string title)
        {
            AnsiConsole.Write(new Rule(title));
        }

        static int[] GetRandomArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            Random random = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(100);
            }

            return array;
        }

        static void PrintArray<T>(IEnumerable<T> e)
        {
            if (e != null)
            {
                AnsiConsole.WriteLine(String.Join(",", e));
            }
            else
            {
                AnsiConsole.WriteLine();
            }
        }
    }


}
