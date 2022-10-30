using System;
using System.Text;

namespace CS12_StructEnum
{
    class Program
    {
        enum HOCLUC
        {
            Kem = 10,
            TrungBinh = 123,
            Kha = 333,
            Gioi = 223
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();

            HOCLUC hocluc;
            hocluc = HOCLUC.Kha;
            int so = (int)hocluc;
            System.Console.WriteLine(so);
            switch (hocluc)
            {
                case HOCLUC.Kem:
                    System.Console.WriteLine("Hoc luc kem");
                    break;
                case HOCLUC.Kha:
                    System.Console.WriteLine("Hoc luc kha!");
                    break;
            }
        }
    }
}
