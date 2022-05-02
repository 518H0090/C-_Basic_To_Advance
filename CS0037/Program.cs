using System;

namespace CS0037
{
    class Program
    {

        static void DoSomeThing(int second, string message, ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{message,10} ... Start");
                Console.ResetColor();
            }


            for (int i = 1; i <= second; i++)
            {

                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{message,10} : {i,2}");
                    Console.ResetColor();
                }
                Thread.Sleep(1000);
            }

            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{message,10} ... End");
                Console.ResetColor();
            }
        }

        static async Task Task2()
        {
            Task t2 = new Task(
                           () =>
                           {
                               DoSomeThing(10, "T2", ConsoleColor.Magenta);
                           }
                       );
            t2.Start();
            await t2;
            Console.WriteLine("Finish for T2");
        }

        static async Task Task3()
        {
            Task t3 = new Task(
                          (object ob) =>
                          {
                              string valueString = (string)ob;
                              DoSomeThing(4, valueString, ConsoleColor.Blue);
                          }
                      , "T3");
            t3.Start();
            await t3;
            Console.WriteLine("Finish for T3");
        }

        static async Task Main(string[] args)
        {
            // Tạo Task
            // Kiểu Action
            Task t2 = Task2();
            Task t3 = Task3();


            // t2.Start();
            // t3.Start();


            DoSomeThing(2, "T1", ConsoleColor.Red);

            await t2;
            await t3;
            Console.WriteLine("Finish");

            // Task trả về
            // Kiểu Func

            Task<string> t4 = new Task<string>(
                () =>
                {
                    DoSomeThing(10, "T4", ConsoleColor.Green);
                    return "Return from t4";
                }
            );

            Task<string> t5 = new Task<string>(
                (object ob) =>
                {
                    string valueString = (string)ob;
                    DoSomeThing(4, valueString, ConsoleColor.Yellow);
                    return $"Return from {valueString}";
                }
            , "T5");

            t4.Start();
            t5.Start();

            await t4;
            await t5;

            var resultT4 = t4.Result;
            var resultT5 = t5.Result;

            Console.WriteLine($" {resultT4} : {resultT5} ");
        }
    }
}