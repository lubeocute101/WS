using System;
using System.Text;

namespace CS10_OOP
{
    class Student : IDisposable
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
            System.Console.WriteLine("Khởi tạo sv " + name);
        }

        public Student()
        {
            System.Console.WriteLine("Constructor khong tham so");
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Huỷ bởi dispose: " + Name);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Test()
        {
            using Student sv = new Student("Ten");
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();

            // Vukhi sungluc = new Vukhi();
            // sungluc.name = "Sung luc";
            // sungluc.ThietLapDoSatThuong(5);
            // sungluc.Tancong();
            // Vukhi sungmay = new Vukhi("Súng máy", 15);
            // sungmay.Tancong();
            // for (int i = 0; i < 1e7; i++)
            // {
            Test();
        }
    }
}
