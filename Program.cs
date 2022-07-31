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
            // * for Counting sort we use collection of numbers with repetitions
            // * we need repetitions to see proper algorithm characterictic
            //var countingSort = new CountingSort(generateNumbersWithRepetitions.array);
            //new PrintSolution(countingSort.solution);

            // * Exchange Sort *
            // * sorts similar to Bubble sort but in descending way
            //var exchangeSort = new ExchangeSort(generateNumbers.generatedArray);
            //new PrintSolution(exchangeSort.solution);

            var heapSort = new HeapSort(generateNumbers.generatedArray);
            new PrintSolution(heapSort.solution);

            Console.ReadKey();
        }
    }
}
