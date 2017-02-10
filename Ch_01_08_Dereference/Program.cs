using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch_01_08_Dereference
{
    class SimpleSum
    {
        private int[] ary;
        private int sum;

        private void Calc()
        {
            sum = ary.Sum();
        }

        public SimpleSum(int max)
        {
            ary = Enumerable.Range(0, max).ToArray();
            Calc();
            ary = null; // This line dereferences the memory.
        }
    }

    class Program
    {
        private const int numOfLoop = 200000;
        private const int numOfSum = 10000;

        static void Main(string[] args)
        {
            var list = new List<SimpleSum>();

            for (int i = 0; i < numOfLoop; i++)
            {
                if (i % 1000 == 0)
                    Console.WriteLine("Looping {0} of {1}...", i, numOfLoop);

                list.Add(new SimpleSum(numOfSum));
            }
        }
    }
}
