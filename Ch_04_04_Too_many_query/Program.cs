using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch_04_04_Too_many_query
{
    class Program
    {
        const int max = 50000;

        static void Main(string[] args)
        {
            Query_Ramer();
            Query_Ramer_2();
            Query_Devil();
            Query_Angel();
            Query_Angel_2();
        }

        private static void Query_Ramer()
        {
            var start = DateTime.Now;
            IEnumerable<int> ary = Enumerable.Range(0, max);
            int sum = 0;
            for (int i = 0; i < ary.Count(); i++)
            {
                sum = sum / 2 + ary.ElementAt(i);
            }
            Console.WriteLine(sum);
            Console.WriteLine(DateTime.Now - start);
        }

        private static void Query_Ramer_2()
        {
            var start = DateTime.Now;
            IEnumerable<int> ary = Enumerable.Range(0, max);
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                sum = sum / 2 + ary.ElementAt(i);
            }
            Console.WriteLine(sum);
            Console.WriteLine(DateTime.Now - start);
        }

        private static void Query_Devil()
        {
            var start = DateTime.Now;
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                IEnumerable<int> ary = Enumerable.Range(0, i + 1);
                sum = sum / 2 + ary.ElementAt(i);
            }
            Console.WriteLine(sum);
            Console.WriteLine(DateTime.Now - start);
        }

        private static void Query_Angel()
        {
            var start = DateTime.Now;
            int[] ary = Enumerable.Range(0, max).ToArray();
            int sum = 0;
            for (int i = 0; i < ary.Count(); i++)
            {
                sum = sum / 2 + ary.ElementAt(i);
            }
            Console.WriteLine(sum);
            Console.WriteLine(DateTime.Now - start);
        }

        private static void Query_Angel_2()
        {
            var start = DateTime.Now;
            int[] ary = Enumerable.Range(0, max).ToArray();
            int sum = 0;
            for (int i = 0; i < ary.Count(); i++)
            {
                sum = sum / 2 + ary[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(DateTime.Now - start);
        }
    }
}
