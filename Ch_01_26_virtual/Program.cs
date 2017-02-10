using System;

namespace Ch_01_26_virtual
{
    class Product
    {
        private Func<int, int> exp;

        public int CalcPrc(int basePrc)
        {
            return this.exp(basePrc);
        }

        public Product(Func<int, int> exp)
        {
            this.exp = exp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product((n) => n * 8 / 10);
            Console.WriteLine(p.CalcPrc(100));
        }
    }
}
