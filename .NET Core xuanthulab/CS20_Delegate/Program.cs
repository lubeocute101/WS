using System;
using System.Linq;
using System.Text;

namespace CS20_Delegate
{
    public delegate void ShowLog(string message);

    class Program
    {
        public delegate void showLog(string message);

        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine (s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine (s);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();

            // ShowLog log = Info;
            // log += Warning;
            // log += Warning;
            // log += Warning;
            // log += Info;
            // log += (Message) => System.Console.WriteLine($"{Message}");
            // log?.Invoke("===>[{i}]<===");
            ShowLog s1 =
                (x) =>
                {
                    System.Console.WriteLine($"----{x}----");
                };
            ShowLog s2 = Warning;
            ShowLog s3 = Info;
            ShowLog all = s1 + s2 + s3 + s1;
            all?.Invoke("LCH");
            DelegateName bien1;
            bien1 = (x1, x2) => x1 > x2;
            System.Console.WriteLine(bien1.Invoke(1, 2));
            Func<int, int, bool> bien2 = (x1, x2) => x1 < x2;
            System.Console.WriteLine(bien2.Invoke(1, 2));
            Func<int, int, int> tinhtong = (x1, x2) => x1 + x2;
            System.Console.WriteLine(tinhtong(2, 3));
            Action<int, int> ac1 =
                (x1, x2) => System.Console.WriteLine(x1 + x2);
            ac1.Invoke(3, 5);

            sum(5, 5, (x, y) => x + y);
            TestTinhTong();
        }

        // sử dụng Delegate làm tham số
        // static void TinhTong(int a, int b, Action callback = null)
        // {
        //     int c = a + b;
        //     // Gọi callback
        //     callback(c.ToString());
        // }
        // public static void TestTinhTong()
        // {
        //     TinhTong(5, 6, (x) => Console.WriteLine($"Tổng hai số là: {x}"));
        //     TinhTong(1, 3, Logs.Info);
        // }
        static void sum(int a, int b, Func<int, int, int> callback)
        {
            System.Console.WriteLine(callback(a, b));
        }

        static void TinhTong(int a, int b, Action<int, int> callback)
        {
            int c = a + b;

            // Gọi callback
            callback (a, b);
        }

        public static void TestTinhTong()
        {
            TinhTong(5,
            6,
            (x, y) => Console.WriteLine($"Tổng hai số là: {(x + y).ToString()}"));
        }

        public delegate bool DelegateName(int a, int b);
    }
}
