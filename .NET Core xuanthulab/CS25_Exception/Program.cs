using System;
using System.Linq;
using System.Text;

namespace CS25_Exception
{
    class Program
    {
        static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();
            }
            if (age < 18 || age > 100)
            {
                throw new AgeException(age);
            }
            System.Console.WriteLine($"Xin chao {name} ({age})");
        }

        static void Main(string[] args)
        {
            Console.Clear();
            try
            {
                Register("LCH", 10);
            }
            catch (NameEmptyException d)
            {
                System.Console.Write(d.Message + " - " + d.GetType().Name);
            }
            catch (AgeException e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.GetType().Name);
                e.Detail();
            }
        }
    }
}
