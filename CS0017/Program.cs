using System;

namespace CS0017
{
    class Program
    {
        static void Main(string[] args)
        {
            int? kieuint;
            Nullable<int> kieuintYchang;
            kieuint = null;

            kieuint = 10;
            kieuintYchang = 20;

            Console.WriteLine(kieuint.Value);
            Console.WriteLine(kieuintYchang.Value);
        }
    }
}