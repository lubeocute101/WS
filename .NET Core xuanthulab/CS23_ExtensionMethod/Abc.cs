namespace CS23_ExtensionMethod
{
    static class Abc
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine (s);
        }
    }
}
