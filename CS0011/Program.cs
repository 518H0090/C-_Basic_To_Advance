using System;
using System.Text;

namespace CS0011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string InputHello = "Hello World";

            Console.WriteLine(InputHello[2]);

            string TestWord = @"Ký tự \ 
            
            
            đã xuất hiện";

            Console.WriteLine(TestWord);

            Console.WriteLine($"{"VòngLặp",10} {"Chẵn/Lẻ",-5}");
            for (int i = 8; i < 15; i++)
            {
                string chanle = (i % 2 == 0) ? "Chẵn" : "Lẻ";
                Console.WriteLine($"{i,10} {chanle,-5}");
            }

            string stringA = "Xin chào,";
            string stringB = "các bạn!";

            string s = String.Concat(stringA, stringB);

            var b = stringA.Insert(8, " tất cả");

            Console.WriteLine(s);
            Console.WriteLine(b);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Xin chào");
            stringBuilder.Append("\t Trung Hiếu");

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}