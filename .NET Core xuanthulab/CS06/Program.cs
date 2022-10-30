using System;
using System.Text;

namespace CS06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            L1:
            System.Console.WriteLine("Hãy chọn lệnh: ");
            System.Console.WriteLine("1)  Tính tổng");
            System.Console.WriteLine("2) Tính hiệu");
            System.Console.WriteLine("3) Tính tích");
            System.Console.WriteLine("4) Tính thương");
            char c = Console.ReadKey().KeyChar;
            System.Console.WriteLine();
            switch (c)
            {
                case '1':
                    System.Console.WriteLine("a + b = {0}", a + b);
                    break;
                case '2':
                    System.Console.WriteLine("a - b = {0}", a - b);
                    break;
                case '3':
                    System.Console.WriteLine("a * b = {0}", a * b);
                    break;
                case '4':
                    System.Console.WriteLine("a / b = {0}", a / b);
                    break;
                default:
                    System.Console.WriteLine("Hãy chọn lệnh khác!");
                    goto L1;
                    break;
            }
        }
    }
}
