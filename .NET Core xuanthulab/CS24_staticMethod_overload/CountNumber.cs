namespace CS24_staticMethod_overload
{
    class CountNumber
    {
        public static int number = 0;

        public static void Info()
        {
            System.Console.WriteLine("So lan truy cap: " + number);
        }

        public void Count()
        {
            CountNumber.number++;
        }
    }
}
