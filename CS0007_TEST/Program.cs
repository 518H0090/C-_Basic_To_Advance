using System;
using CS0007_Utils;


namespace CS0007_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20042;
            var kq = THUtils.NumberToText(a);

            Console.WriteLine(kq);
        }
    }
}