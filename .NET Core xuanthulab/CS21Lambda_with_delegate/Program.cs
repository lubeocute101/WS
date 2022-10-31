using System;
using System.Linq;

namespace CS21Lambda_with_delegate
{
    class Program
    {
        /*
        Lambda - Anonymous function
        1)
        (int a, int b) => 
        */
        static void Main(String[] args)
        {
            Console.Clear();
            Func<int, int, int> tinhtoan;
            tinhtoan = (a, b) => a + b;
            Action<int, int, Func<int, int, int>> ac;
            ac = (a, b, callback) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"a + b = {callback?.Invoke(a, b)}");
                Console.ResetColor();
            };

            // int res = (int) tinhtoan?.Invoke(3, 4);
            ac(3, 4, (int a, int b) => a + b);
        }
    }
}
