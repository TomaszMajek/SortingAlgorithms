using System;
using System.Linq;

namespace SortingAlgorithms
{
    // generate without repetitions
    internal class GenerateNumbers
    {
        public int[] generatedArray = Enumerable.Range(0, 100).ToArray();

        public GenerateNumbers()
        {
            Shuffle(new Random());
        }

        private void Shuffle(Random random)
        {
            int n = generatedArray.Length;
            while(n > 1)
            {
                int j = random.Next(n--);
                var temp = generatedArray[n];
                generatedArray[n] = generatedArray[j];
                generatedArray[j] = temp;
            }
        }

    }
}
