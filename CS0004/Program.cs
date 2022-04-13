using System;
using System.Text;

namespace CS0004
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }

                Console.WriteLine($"Số chia hết cho 3 {i}");
            }

            int j = 0;
            while (true)
            {
                Console.WriteLine("Number {0}", ++j);

                if (j == 10)
                {
                    break;
                }
            }
        }
    }
}
