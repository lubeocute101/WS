using System;
using System.Linq;
using System.Text;

namespace CS18_null_nullable
{
    class ABC
    {
        public void XinChao() => System.Console.WriteLine("Xin chao C#");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            int? age;
            age = null;
            age = 100;
            if (age.HasValue)
            {
                int _age = age.Value;
                System.Console.WriteLine(_age);
            }
            else{
                System.Console.WriteLine("NULL");
            }
        }
    }
}
