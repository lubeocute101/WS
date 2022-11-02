using System;
using System.Linq;
using System.Text;
using MyLib;

namespace CS23_ExtensionMethod
{
    class Program
    {
        //extension method
        static void Main(string[] args)
        {
            Console.Clear();
            string s = "xin chao cac ban!";
            s.Print(ConsoleColor.Red);
            "Test".Print(ConsoleColor.Green);
            double a = 3;
            System.Console.WriteLine(a.BinhPhuong());
            double x = Xyz.Cos(45);
            double y = 45.0.Sin();
            System.Console.WriteLine(x * x + y * y);
        }
    }
}
