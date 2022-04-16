using System;
using System.Linq;
using System.Collections.Generic;
using ExnString;

namespace CS0022
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "giá trị 1 2 3 4 5 6";
            s.PrintNewString();

            "Xin chào nhé".PrintNewString(ConsoleColor.Blue);
        }
    }
}