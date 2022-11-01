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
        static void Test(int a, int b, Func<int, int, int> callback)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System
                .Console
                .WriteLine($"a + b = {a} + {b} = {callback?.Invoke(a, b)}");
            Console.ResetColor();
        }

        static void Main(String[] args)
        {
            Console.Clear();

            // Func<int, int, int> tinhtoan;
            // tinhtoan = (a, b) => a + b;
            // Action<int, int, Func<int, int, int>> ac;
            // ac = (a, b, callback) =>
            // {
            //     Console.ForegroundColor = ConsoleColor.Yellow;
            //     System.Console.WriteLine($"a + b = {callback?.Invoke(a, b)}");
            //     Console.ResetColor();
            // };
            // Test(3, 4, (int a, int b) => a + b);
            int[] mang = { 1, 2, 3, 4, 5, 6, 9, 16 };
            var res =
                mang
                    .Select((int x) =>
                    {
                        return Math.Sqrt(x);
                    });
            foreach (var item in res)
            {
                System.Console.WriteLine (item);
            }
            System.Console.WriteLine("Old number: ");
            mang
                .ToList()
                .ForEach((int e) =>
                {
                    if (e % 2 == 0) System.Console.WriteLine(e);
                });
            System.Console.WriteLine("Cac so chia het cho 4: ");
            var cacSoChiaHetCho4 =
                mang
                    .Where((x) =>
                    {
                        return x % 4 == 0;
                    });
            foreach (var item in cacSoChiaHetCho4)
            {
                System.Console.WriteLine (item);
            }
        }
    }
}
