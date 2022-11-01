using System;
using System.Linq;
using System.Text;

namespace CS22_EventHandler
{
    public delegate void SuKienNhapSo(int x);

    /*
        publisher -> class - phat su kien
        subriber -> class - nhan su kien
    */
    //publisher
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            UserInput userinput = new UserInput();
            TinhCan tinhcan = new TinhCan();
            tinhcan.Sub (userinput); // tham chiếu delegate tới method sqrt

            //Nhập và Invoke method
            userinput.Input();
        }
    }
}
