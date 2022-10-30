using System;
using System.Linq;
using System.Text;

namespace CS18_null_nullable
{
    interface IHinhHoc{
        public double TinhChuVi();
        public double TinhDienTich();
    }
    class HinhChuNhat : IHinhHoc
    {
        public HinhChuNhat(double a, double b){
            this.a = a;
            this.b = b;
        }
        public double a { get; set; }
        public double b { get; set; }

        public double TinhChuVi() => 2*(a+b);

        public double TinhDienTich() => a*b;
    }
    class HinhTron : IHinhHoc
    {
        public double r { get; set; }
        public HinhTron(double _r) => r = _r;

        public double TinhChuVi() => 2 * r * Math.PI;

        public double TinhDienTich() => Math.PI * r * r;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Clear();
            IHinhHoc h = new HinhTron(1);
            System.Console.WriteLine($"Dien tich {h.TinhDienTich()}, Chu vi = {h.TinhChuVi()}");
        }
    }
}
