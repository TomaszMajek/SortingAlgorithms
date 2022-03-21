using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        int n;
        int[] array;

        public BubbleSort(int[] array)
        {
            n = array.Length;
            this.array = array;
            Sorted();
        }

        public Array Sorted()
        {
            int temp;

            for(int j = 0; j < n; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            return array;
        }

        public void PrintSortedArray()
        {
            foreach (var item in array)
                Console.Write("{0} ", item);
        }
    }
}
