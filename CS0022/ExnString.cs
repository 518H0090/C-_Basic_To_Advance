namespace ExnString
{
    public static class ExtenForString
    {
        public static void PrintNewString(this string s, ConsoleColor color = ConsoleColor.Red)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ConsoleColor lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = lastColor;
        }
    }

}