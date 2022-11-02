using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS22_EventHandler
{
    public class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += TinhBinhPhuong;
        }
        // ~ dekegate void KIEU(Object? sender, EventArgs args)
        public void TinhBinhPhuong(Object sender, EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int n = dulieunhap.data;
            Console.WriteLine($"Binh phuong cua {n} la {Math.Sqrt(n * n)}");
        }
    }
}
