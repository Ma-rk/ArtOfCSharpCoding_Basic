using System;
using System.Threading.Tasks;

namespace Ch_01_07_Async_loop
{
    class Program
    {
        private static async Task countDown()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
                await Task.Delay(500);
            }
        }
        static void Main(string[] args)
        {
            var a = countDown();
            var b = countDown();

            Console.WriteLine("Doing...");
            Task.WaitAll(a, b);
            Console.WriteLine("All done.");
        }
    }
}
