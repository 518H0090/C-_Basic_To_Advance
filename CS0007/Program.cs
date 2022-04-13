using System;
using CS0007_Utils;

namespace CS0007
{
    class Program
    {
        static void Main(string[] args)
        {
            // dotnet add D:\CS0007\CS0007.csproj reference D:\CS0007_Utils\CS0007_Utils.csproj
            double a = 252525252;
            var kq = THUtils.NumberToText(a);

            Console.WriteLine(kq);

            THUtils.Hello();
        }
    }
}