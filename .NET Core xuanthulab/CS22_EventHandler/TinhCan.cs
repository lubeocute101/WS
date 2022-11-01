namespace CS22_EventHandler
{
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso = Can;
        }

        public void Can(int n)
        {
            System.Console.WriteLine($"Can bac hai cua {n} la: {Math.Sqrt(n)}");
        }
    }
}
