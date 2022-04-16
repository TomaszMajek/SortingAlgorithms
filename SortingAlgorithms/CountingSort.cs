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
            int[] temp = new int[max + 1];
            solution = new int[n];

            for (int i = 0; i < n; i++)
                temp[array[i]]++;

            for (int j = 1; j <= max; j++)
                temp[j] += temp[j - 1];

            for (int k = n - 1; k >= 0; k--)
            {
                solution[temp[array[k]] - 1] = array[k];
                temp[array[k]]--;
            }

            return solution;
        }
    }
}
