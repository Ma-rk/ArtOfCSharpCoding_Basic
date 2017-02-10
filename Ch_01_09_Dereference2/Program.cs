using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch_01_09_Dereference2
{
    class SimpleSum
    {
        public Func<int> GetSum;

        public SimpleSum(int max)
        {
            IEnumerable<int> ary = Enumerable.Range(0, max); // Keypoint!!!
            GetSum = () =>
              {
                  return ary.Sum();
              };
        }
    }

    class Program
    {
        private const int numOfLoop = 100000;
        private const int numOfSum = 10000;
        static void Main(string[] args)
        {
            var list = new List<SimpleSum>();
            for (int i = 0; i < numOfLoop; i++)
            {
                if (i % 5000 == 0)
                    Console.WriteLine("Looping {0} of {1}...", i, numOfLoop);

                list.Add(new SimpleSum(numOfSum));
            }
        }
    }
}
