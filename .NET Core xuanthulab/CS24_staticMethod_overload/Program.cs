using System;
using System.Linq;
using System.Text;

namespace CS24_staticMethod_overload
{
    class Vector
    {
        double x;

        double y;

        public Vector(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void Info()
        {
            System.Console.WriteLine($"X = {x}, y = {y}");
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }

        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;

                        break;
                    default:
                        throw new Exception("Chi so sai!");
                }
            }
            get
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return x;
                    default:
                        throw new Exception("Chi so sai!");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // CountNumber c1 = new CountNumber();
            // CountNumber c2 = new CountNumber();
            // c1.Count();
            // c2.Count();
            // CountNumber.Info();
            //2.read only
            // Student s = new Student("lucute");
            // // s.name = "LCH";
            // System.Console.WriteLine(s.name);
            // 3.overload
            // Vector v1 = new Vector(2, 3);
            // Vector v2 = new Vector(1, 1);
            // v1.Info();
            // v2.Info();
            // Vector res = v1 + v2;
            // res.Info();
            // 4.Indexer
            // v[0] ~ x
            // v[1] ~ y
            Vector v = new Vector(2, 3);
            v[0] = 1;
            v[1] = 2;
            v.Info();
            System.Console.WriteLine(v[3]);
        }
    }
}
