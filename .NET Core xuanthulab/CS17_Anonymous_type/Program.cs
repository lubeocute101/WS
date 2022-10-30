using System;
using System.Linq;
using System.Text;

namespace CS17_Anonymous_type
{
    class Sinhvien
    {
        public string HoTen { get; set; }

        public int NamSinh { get; set; }

        public string NoiSinh { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();

            List<Sinhvien> cacsinhvien =
                new List<Sinhvien> {
                    new Sinhvien()
                    { HoTen = "Nam", NamSinh = 2000, NoiSinh = "Binh Duong" },
                    new Sinhvien()
                    { HoTen = "Dan", NamSinh = 2002, NoiSinh = "Nam Dinh" },
                    new Sinhvien()
                    { HoTen = "Long", NamSinh = 2001, NoiSinh = "Vinh Phuc" }
                };
            var ketqua =
                from sv in cacsinhvien
                where sv.NamSinh <= 2001
                select new { Ten = sv.HoTen, NS = sv.NoiSinh };
            foreach (var item in ketqua)
            {
                System.Console.WriteLine(item.Ten + " - " + item.NS);
            }
        }
    }
}
