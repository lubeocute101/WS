using System;
using System.Text;
using System.Linq;
namespace CS22_EventHandler
{
    public delegate void SuKienNhap(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Khi người dùng ấn ctrl + c chúng ta có thể bắt sự kiện này
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.Clear();
                Console.WriteLine("Thoat ung dung");
            };


            // publisher
            UserInput userinput = new UserInput();


            // Có thể gán = 1 lambda phải phù hợp với delegate
            userinput.sukiennhapso += (sender, e) =>
            {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                int x = dulieunhap.data;
                Console.WriteLine($"Ban vua nhap so {x}");
            };


            // Subcriber
            Tinhcan tinhcan = new Tinhcan();
            tinhcan.Sub(userinput);
            BinhPhuong binhPhuong = new BinhPhuong();
            binhPhuong.Sub(userinput);


            userinput.Input();
        }
    }
}