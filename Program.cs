using SortingAlgorithms.Extensions;
using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generateNumbers = new GenerateNumbers();
            var calculatedMedian = new CalculateMedianAverage(generateNumbers.generatedArray);


            // Bubble Sort
            //var bubbleSort = new BubbleSort(generateNumbers.generatedArray);
            //new PrintSolution(bubbleSort.solution);

            // Quick Sort
            var quickSort = new QuickSort(generateNumbers.generatedArray);
            new PrintSolution(quickSort.solution);



            Console.ReadKey();
        }
    }
}
