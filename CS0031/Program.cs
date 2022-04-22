using System;
using System.Collections;
using System.Collections.Generic;

namespace CS0031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // LinkedList
            LinkedList<string> StringList = new LinkedList<string>();

            StringList.AddFirst("Hello 3");
            StringList.AddLast("Hello 2");
            StringList.AddFirst("Hello 1");
            StringList.AddFirst("Hello 5");

            Console.WriteLine("Từ đầu tới cuối");
            LinkedListNode<string> nodeFirst = StringList.First;

            while (nodeFirst != null)
            {
                Console.WriteLine(nodeFirst.Value);
                nodeFirst = nodeFirst.Next;
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Từ cuối tới đầu");
            LinkedListNode<string> nodeLast = StringList.Last;
            while (nodeLast != null)
            {
                Console.WriteLine(nodeLast.Value);
                nodeLast = nodeLast.Previous;
            }
            Console.WriteLine("--------------------------------------");

        }
    }
}