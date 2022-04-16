using System;

namespace CS0019
{
    class Program
    {

        public delegate void Showlog(string message);

        static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", message));
            Console.ResetColor();
        }

        static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", message));
            Console.ResetColor();
        }


        static void Tinhtong(int a, int b, Action<string> callback)
        {
            int c = a + b;
            callback(c.ToString());
        }

        static void Main(string[] args)
        {
            Showlog showlog;
            // showlog = Info;
            // showlog("Hello World");

            // showlog = Warning;
            // showlog.Invoke("Wow");

            // if (showlog != null)
            // {
            //     showlog("Method 1");
            // }

            // showlog?.Invoke("Method 2");
            showlog = null;
            showlog += Info;
            showlog += Warning;



            // gán ano
            showlog += (s) =>
            {
                Console.WriteLine($"Hello World : {s}");
            };

            showlog?.Invoke("Concat delegate");

            Showlog showLog5 = (x) => { Console.WriteLine($"-----{x}-----"); };
            Showlog showLog6 = Warning;
            Showlog showLog7 = Info;

            var all = showLog5 + showLog6 + showLog7;

            all("Xin chào");

            // Func and Action
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Func<int, int, int> var1 = (a, b) => a + b;
            Console.WriteLine(var1.Invoke(5, 20));

            Action<string, string> var2 = null;
            var2 += (a, b) => Console.WriteLine($"Nội dung {a} và {b}");
            var2?.Invoke("Nội dung 1", "Nội dung 2");

            Tinhtong(5, 10, (x) => Console.WriteLine(x));
        }
    }
}