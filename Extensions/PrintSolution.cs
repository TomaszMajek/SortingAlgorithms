using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Extensions
{
    internal class PrintSolution
    {
        public PrintSolution(int[] array)
        {
            foreach (var item in array)
                Console.Write("{0} ", item);
        }
    }
}
