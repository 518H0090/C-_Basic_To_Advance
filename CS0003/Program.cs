using System;
using System.Text;

namespace HelloName
{

    class Program
    {

        static void Main(string[] args)
        {

            // Goto thì đi với Label: label tùy ta đạt
            /*
            ví dụ
            L1:
             Console.Writeline("L1");


            goto L1;

             */

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Hello NameSpace");
            int i = 20;
            int j = 30;
            var c = i >= j;

            Console.WriteLine($"Boolean : {!c}");

            Console.WriteLine("IFFFFFFFFFF");

            int year = 1999;

            if (year >= 2000)
            {
                Console.WriteLine($"Year True is : {year}");
            }
            else
            {
                Console.WriteLine($"Year False Because you declare year is : {year}");
            }

            Console.WriteLine("Toán tử ba ngôi");

            int age = 18;

            string msg = (age >= 18) ? "Đủ điều kiện quay tay" : "Không đủ điều kiện quay tay";
            Console.WriteLine($"{msg}");

            var a = 2;
            var b = 3.5;
            var d = 2;

            var max = a > b ? a > d ? a : d : b > d ? b : d;

            Console.WriteLine("Max {0}", max);


            Console.WriteLine(@"For Switch
            
            Case");
            int number = 5;

            switch (number)
            {
                case 1:
                    Console.WriteLine($"Number 1 is {number}");
                    break;
                case 2:
                    Console.WriteLine($"Number 2 is {number}");
                    break;
                case 3:
                    Console.WriteLine($"Number 3 is {number}");
                    break;
                case 4:
                    Console.WriteLine($"Number 4  is {number}");
                    break;
                default:
                    Console.WriteLine($"{number} is not in case");
                    goto case 1;
                    break;
            }

            Console.WriteLine(@"For If Else


            Case");


            if (number == 1)
            {

                Console.WriteLine($"Number 1 is {number}");
            }
            else if (number == 2)
            {
                Console.WriteLine($"Number  2 is {number}");
            }
            else if (number == 3)
            {
                Console.WriteLine($"Number 3  is {number}");
            }
            else if (number == 4)
            {
                Console.WriteLine($"Number  4 is {number}");
            }
            else
            {
                Console.WriteLine($"{number} is not in case");
            }
        }
    }
}