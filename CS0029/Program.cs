using System;
using System.Collections;
using System.Collections.Generic;

namespace CS0029
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new SortedList<string, string>();
            products.Add("Iphone 6", "Iphone - 6 ");
            products.Add("Iphone 7", "Iphone - 7 ");
            products.Add("Iphone 8", "Iphone - 8 ");
            products.Add("Iphone 9", "Iphone - 9 ");
            products.Add("Iphone 10", "Iphone - 10 ");

            products["Iphone11"] = "Iphone - 11";
            products["Iphone12"] = "Iphone - 12";

            foreach (KeyValuePair<string, string> p in products)
            {
                Console.WriteLine(p.Key + "  " + p.Value);
            }

            Console.WriteLine("--------------------");

            foreach (var p in products)
            {
                Console.WriteLine(p.Key + "  " + p.Value);
            }

            Console.WriteLine("--------------------");

            string product10 = "Iphone11";
            Console.WriteLine($"{product10} : {products[product10]}");

            Console.WriteLine("--------------------");

            foreach (var key in products.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in products.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("--------------------");

        }
    }
}