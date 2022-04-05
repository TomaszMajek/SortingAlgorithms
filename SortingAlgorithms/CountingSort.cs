using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    internal class CountingSort
    {
        private int n;
        private int[] array;
        public int[] solution;

        public CountingSort(int[] array)
        {
            n = array.Length;
            this.array = array;
            solution = Sorted();
        }

        private int[] Sorted()
        {
            int max = array.Max();
            int[] result = new int[max + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                    result[i] += 1;
            }

            return array;
        }
    }
}
