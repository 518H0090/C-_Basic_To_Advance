using System;
using System.Collections.Generic;

namespace CS0028
{

    class Product
    {
        public int ID { set; get; }
        public double Price { set; get; }
        public string Name { set; get; }

        public Product(int id, double price, string name)
        {
            ID = id;
            Price = price;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Default
            var numbers = new List<int>();
            var products = new List<Product>();

            // With value
            List<int> numberValue = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var productValue = new List<Product>() { new Product(1, 2000, "haha"), new Product(2, 30000, "hoho") };

            // Add value
            numbers.Add(2);
            numbers.Add(10);
            numbers.Add(3);
            numbers.Add(7);

            // Add Range
            var arrayInt = new int[] { 10, 3, 9, 22, 6 };
            numbers.AddRange(arrayInt);

            // Insert Value
            numbers.Insert(3, 5);

            // Insert Range
            int[] arrayAdd = { 3, 9, 8, 7 };
            numbers.InsertRange(2, arrayAdd);

            // Read value
            Console.WriteLine(numbers[3]);

            // get value in list
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // remove
            numbers.RemoveAt(3);
            numbers.RemoveRange(2, 6);
            numbers.Remove(7);
            Console.WriteLine("---------------------------------------------");

            numbers.Sort(
                (n1, n2) =>
                {
                    if (n1 > n2)
                    {
                        return 1;
                    }
                    else if (n1 < n2)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            );

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}