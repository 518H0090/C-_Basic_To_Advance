using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string studentName = "Huynh Tran Trung Hieu";
            Console.WriteLine(studentName);

            Console.ResetColor();

            string Ho = "Huynh";
            string Ten = "Tran Trung Hieu";

            Console.WriteLine("Ho : {0} va Ten : {1}", Ho, Ten);

            int a = 20;
            int b = 15;

            Console.WriteLine($"a = {a} va b = {b} tong la = {a + b}");

            // Console.WriteLine("Vui long nhap ten dang nhap vao vao");
            // string userLogin;
            // userLogin = Console.ReadLine();
            // Console.WriteLine($"Ten dang nhap la {userLogin}");

            // Console.WriteLine("Dien ky tu bat ki vao");
            // char keyPress = Console.ReadKey().KeyChar;
            // Console.WriteLine($"ky tu dien vao la {keyPress}");

            // Console.WriteLine("Nhap vao mot so co kieu int");
            // string aGet = Console.ReadLine();
            // int numberA = Int32.Parse(aGet, 0);
            // Console.WriteLine("So da nhap la {0}", numberA);

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var NumberGet = 12;
            var StringNameValue = "Giá trị bất kì ";

            Console.WriteLine($"{StringNameValue} : {NumberGet}");

            const string HANG_SO = "Đây là hằng số không thay đổi được";
            Console.WriteLine("{0}", HANG_SO);

            Console.WriteLine("End");
        }
    }
}