using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    internal class ExchangeSort
    {
        private int n;
        private int[] array;
        public int[] solution;

        public ExchangeSort(int[] array)
        {
            n = array.Length;
            this.array = array;
            solution = Sorted();
        }

        private int[] Sorted()
        {
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = array[i];

                for (int j = 0 + i; j < n; j++)
                {
                    if (temp < array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }


            return array;
        }
    }
}
