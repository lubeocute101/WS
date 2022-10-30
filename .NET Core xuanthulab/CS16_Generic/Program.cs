using System;
using System.Text;

namespace CS16_Generic
{
    class Product<T>
    {
        T ID;

        public void SetID(T _ID)
        {
            this.ID = _ID;
        }

        public void PrintInf()
        {
            System.Console.WriteLine($"ID = {this.ID}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();
            Stack<int>stack;
            Queue<int>q;
        }
    }
}
