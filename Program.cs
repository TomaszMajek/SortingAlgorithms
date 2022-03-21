using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generateNumbers = new GenerateNumbers();

            // sortowanie bąbelkowe
            var bubbleSort = new BubbleSort(generateNumbers.generatedArray);
            bubbleSort.PrintSortedArray();

                        


            Console.ReadKey();
        }
    }
}
