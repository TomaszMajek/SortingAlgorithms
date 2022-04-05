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

            // Comb Sort
            var combSort = new CombSort(generateNumbers.generatedArray);
            new PrintSolution(combSort.solution);


            Console.ReadKey();
        }
    }
}
