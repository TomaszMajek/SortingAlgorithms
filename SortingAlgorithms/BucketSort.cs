using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    internal class BucketSort
    {
        // we need to divide whole array[] into smaller chunks (buckets)
        // unsorted array (0/99) into
        // 0...9   | 0 bucket
        // 10...19 | 1 bucket
        // .......
        // 90...99 | 9 bucket

        private int n;
        private int m;
        private int[] array;
        public int[] solution;

        public BucketSort(int[] array)
        {
            n = array.Length;
            this.array = array;
            solution = Sorted();
        }

        private int[] Sorted()
        {
            List<int> bucketsList = new List<int>();

            for (int i = 0; i < m; i++)
            {
                n = m * array[i];
                bucketsList[n] = array[i];
            }

            return array;
        }


    }
}
