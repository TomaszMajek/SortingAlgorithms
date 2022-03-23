using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        private int n;
        private int[] array;
        public int[] solution;

        public BubbleSort(int[] array)
        {
            n = array.Length;
            this.array = array;
            solution = Sorted();
        }

        private int[] Sorted()
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
    }
}
