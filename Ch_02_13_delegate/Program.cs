using System;

namespace Ch_02_13_delegate
{
    class Program
    {
        const int numX = 2;
        const int numY = 6;

        delegate int Calc(int x, int y);
        private static void doCalc_1(Calc calc)
        {
            Console.WriteLine(calc(numX, numY));
        }

        private static void doCalc_2(Func<int, int, int> calc)
        {
            Console.WriteLine(calc(numX, numY));
        }

        static void Main(string[] args)
        {
            doCalc_1((x, y) => x + y / 2);
            doCalc_2((x, y) => x + y / 2);
        }
    }
}
