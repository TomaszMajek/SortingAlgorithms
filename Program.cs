using SortingAlgorithms.Extensions;
using SortingAlgorithms.SortingAlgorithms;
using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generateNumbers = new GenerateNumbers();
            var generateNumbersWithRepetitions = new GenerateNumbersWithRepetitions();

            // * Counting Sort *
            // for Counting sort we use collection of numbers with repetitions
            // we need repetitions to see proper algorithm characterictic
            //var countingSort = new CountingSort(generateNumbersWithRepetitions.array);
            //new PrintSolution(countingSort.solution);




            Console.ReadKey();
        }
    }
}
