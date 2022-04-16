using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Extensions
{
    internal class GenerateNumbersWithRepetitions
    {
        public int[] array = new int[100];

        public GenerateNumbersWithRepetitions()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                // make sure there are repetitions (80)
                array[i] = random.Next(80);
            }
        }
    }
}
