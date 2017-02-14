using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_02_12_resource
{
    class Program
    {
        private static double Calc100Avg(int[] ary)
        {
            return ary.Take(100).Average();
        }

        static void Main(string[] args)
        {
            int[] ary = Enumerable.Range(0, 10000).ToArray();
            Console.WriteLine(Calc100Avg(ary));
        }
    }
}
