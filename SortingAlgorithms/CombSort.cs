using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    internal class CombSort
    {
        private int n;
        private int[] array;
        public int[] solution;

        public CombSort(int[] array)
        {
            n = array.Length;
            this.array = array;
            solution = Sorted();
        }

        private int[] Sorted()
        {
            int gap = array.Length;
            int temp;
            bool swap = true;

            while (gap > 1 || swap)
            {
                gap = (gap * 10) / 13;
                swap = false;

                for (int i = 0; i < array.Length - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        swap = true;
                        temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                    }
                }
            }

            return array;
        }
    }
}
