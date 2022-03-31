using System;
using System.Linq;

namespace SortingAlgorithms.Extensions
{
    internal class CalculateMedianAverage
    {
        public float median;
        public float average;
        public int roundedArrayCenter;
        private int arrayLength;
        private int[] array;

        public CalculateMedianAverage(int[] array)
        {
            this.arrayLength = array.Length;
            this.array = array;
            Array.Sort(this.array);

            // calculate average
            average = array.Sum() / arrayLength;

            // calculate median
            if (arrayLength % 2 == 0)
            {
                median = (this.array[(arrayLength / 2) - 1] + this.array[arrayLength / 2]) / 2;
            }
            else if (arrayLength % 2 == 1)
            {
                median = this.array[arrayLength / 2];
            }
        }
    }
}
