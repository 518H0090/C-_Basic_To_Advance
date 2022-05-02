using System;

namespace CS0038_add_package
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 242424.24242424;
            var kq = CS0038_lib.ConvertMoneyToText.NumberToText(a);
            Console.WriteLine(kq);
        }
    }
}