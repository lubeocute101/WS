namespace CS22_EventHandler
{
    class UserInput
    {
        public SuKienNhapSo sukiennhapso { set; get; }

        public void Warning()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Info()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void Input()
        {
            int cnt = 0;
            while (true)
            {
                if (cnt % 2 == 0)
                    Warning();
                else
                    Info();
                System.Console.Write("Enter the number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == -1)
                {
                    Console.Clear();
                    System.Console.WriteLine("tks for watching!");
                    break;
                }
                sukiennhapso?.Invoke(n);
                Console.ResetColor();
                cnt += 1;
            }
        }
    }
}
