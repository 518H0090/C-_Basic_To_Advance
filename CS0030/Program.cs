using System;
using System.Collections;
using System.Collections.Generic;

namespace CS0030
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue
            Queue<string> queueString = new Queue<string>();
            for (int i = 0; i < 10; i++)
            {
                queueString.Enqueue("haha" + (i + 1));
            }

            while (queueString.Count > 0)
            {
                var getString = queueString.Dequeue();
                Console.WriteLine($"get {getString} reset of value : {queueString.Count}");
            }

            Console.WriteLine("-----------------------------------------");

            // Stack
            Stack<string> stackString = new Stack<string>();
            for (int i = 0; i < 10; i++)
            {
                stackString.Push("Hello" + (i + 1));
            }

            for (int i = 0; i < stackString.Count; i++)
            {
                var valueString = stackString.Pop();
                Console.WriteLine($"get {valueString} reset of value : {stackString.Count}");
            }

        }
    }
}