using System;
using System.Text;
namespace CS11_string
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            StringBuilder thongbao = new StringBuilder();
            thongbao.Append("Xin");
            thongbao.Append(" chao cac ban");
            thongbao.Replace("Xin chao", "XIN CHAO");
            string kq = thongbao.ToString();
            System.Console.WriteLine(thongbao);
        }
    }
}
