namespace CS22_EventHandler
{
    public class Tinhcan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso += TinhCan;
        }
        // ~ dekegate void KIEU(Object? sender, EventArgs args)
        public void TinhCan(Object sender, EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int n = dulieunhap.data;
            Console.WriteLine($"Can bac hai cua {n} la {Math.Sqrt(n)}");
        }
    }
}
