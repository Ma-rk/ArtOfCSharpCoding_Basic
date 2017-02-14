using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch_02_12_resource
{
    class Program
    {
        // before
        //private static double Calc100Avg(int[] ary)
        //{
        //    return ary.Take(100).Average();
        //}

        // improved
        private static double Calc100Avg(IEnumerable<int> ary)
        {
            return ary.Take(100).Average();
        }

        static void Main(string[] args)
        {
            // before
            int[] ary = Enumerable.Range(0, 10000).ToArray();
            Console.WriteLine(Calc100Avg(ary));

            // improved
            IEnumerable<int> ary2 = Enumerable.Range(0, 10000);
            Console.WriteLine(Calc100Avg(ary2));
        }
    }
}
