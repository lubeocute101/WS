using System;
using System.Text;

namespace CS14_inheritance
{
    class Program
    {
        class Animal
        {
            public int Legs { get; set; }

            public float Weigh { get; set; }

            public void ShowLegs()
            {
                Console.WriteLine($"Legs: {Legs}");
            }
        }

        class Cat : Animal
        {
            public string food; // thuộc tính mới thêm

            public Cat()
            {
                Legs = 4; // Thuộc tính Legs có sẵn - vì nó kế thừa từ Animal
                food = "Mouse";
            }

            public void Eat()
            {
                Console.WriteLine (food);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            Cat c = new Cat();
            c.Eat();
        }
    }
}
