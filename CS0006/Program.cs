using System;
using CS0006;

namespace CS0006
{
    class Program
    {

        internal static void HelloFromMain()
        {
            Console.WriteLine("Hello From Main");
        }

        static int SoLon(int a, int b)
        {
            int max = a > b ? a : b;
            return max;
        }

        static int Tongso(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        static void swaptwoNumber(ref int a, ref int b)
        {
            int i = a;
            a = b;
            b = i;
        }

        static void add100toVariable(out int a)
        {
            a = 100;
        }

        static int giaithuaM(int a)
        {
            if (a == 0)
            {
                return 1;
            }

            Console.WriteLine(a);
            return a * giaithuaM(a - 1);
        }

        static void Main(string[] args)
        {

            // Tham trị
            Vidu.Hello();
            Vidu.Hello();
            Vidu.Hello();
            HelloFromMain();
            HelloFromMain();
            HelloFromMain();

            Console.WriteLine(SoLon(20, 10));

            Console.WriteLine(Vidu.tong(5, 100));

            // truyền tham số với tên
            Console.WriteLine(Tongso(a: 10, b: 20, c: 30));

            //Tham chiếu
            int a = 10;
            int b = 20;

            swaptwoNumber(ref a, ref b);

            Console.WriteLine($"a : {a} and b : {b}");

            int c;

            add100toVariable(out c);

            Console.WriteLine(c);
            // Đệ quy

            int giaithua = giaithuaM(5);
            Console.WriteLine(giaithua);
        }
    }
}