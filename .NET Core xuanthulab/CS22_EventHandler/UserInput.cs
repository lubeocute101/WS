using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS22_EventHandler
{


    public class UserInput
    {
        // public event SuKienNhap sukiennhap;

        // C# cung cấp 1 thứ chuyên để khai báo sự kiện
        // ~ dekegate void KIEU(Object? sender, EventArgs args)
        public event EventHandler sukiennhapso;
        public void Input()
        {
            int cnt = 1;
            while (true)
            {
                if (cnt % 2 == 1) Console.ForegroundColor = ConsoleColor.Yellow;
                if (cnt % 2 == 0) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("N = ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Cam on ban da su dung chuong trinh");
                    break;
                }
                sukiennhapso?.Invoke(this, new Dulieunhap(n));
                Console.ResetColor();
                cnt++;
            }
        }
    }
}
