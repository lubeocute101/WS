namespace CS22_EventHandler
{
    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso = TinhBinhPhuong;
        }

        public void TinhBinhPhuong(int n)
        {
            System.Console.WriteLine($"Binh phuong cua {n} la: {n * n}");
        }
    }
}
