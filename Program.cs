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
            //var calculatedMedian = new CalculateMedianAverage(generateNumbers.generatedArray);


            // Comb Sort
            var combSort = new CombSort(generateNumbers.generatedArray);
            new PrintSolution(combSort.solution);


            Console.ReadKey();
        }
    }
}
