using System;

namespace CS0005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mảng là một cấu trúc dữ liệu được sử dụng dụng để lưu trữ một tập dữ liệu cùng kiểu
            int[] bienmang;
            bienmang = new int[5];
            string[] mangstring = new string[10];

            // The same
            string[] MobileArray1 = new string[3] { "Iphone", "Android", "WindowPhone" };
            string[] MobileArray2 = new string[] { "Iphone", "Android", "WindowPhone" };
            string[] MobileArray3 = { "Iphone", "Android", "WindowPhone" };

            Console.WriteLine($"Array Value : {MobileArray3[0]} , {MobileArray3[1]} , {MobileArray3[2]}");

            int[] NumberArray = { 2, 5, 1, 20, 30, 50, 14 };

            Console.WriteLine($"Length : {NumberArray.Length}");
            Console.WriteLine($"Rank : {NumberArray.Rank}");
            Console.WriteLine($"Value Index 1 : {NumberArray.GetValue(1)}");
            Console.WriteLine($"Min : {NumberArray.Min()}");
            Console.WriteLine($"Max : {NumberArray.Max()}");
            Console.WriteLine($"Sum : {NumberArray.Sum()}");

            // Duyệt mảng
            Array.ForEach(NumberArray, (int n) =>
            {
                Console.WriteLine(n);
            });

            for (int i = 0; i < NumberArray.Length; i++)
            {
                Console.WriteLine(NumberArray[i]);
            }

            foreach (var i in NumberArray)
            {
                Console.WriteLine(i);
            }


            // Mảng nhiều chiều
            int[,] myvar = new int[3, 4] { { 1, 2, 3, 4 }, { 0, 3, 1, 3 }, { 4, 2, 3, 4 } };

            for (int i = 0; i < myvar.GetLength(0); i++)
            {
                for (int j = 0; j < myvar.GetLength(1); j++)
                {
                    Console.WriteLine("Value " + myvar[i, j]);
                }
            }

            // Mảng trong mảng : https://xuanthulab.net/mang-trong-lap-trinh-c-sharp.html
            // Ví dụ, nếu ký hiệu int[] là kiểu mảng mà các phần tử số nguyên, vậy khi viết int[][] sẽ là kiểu mảng mà các phần tử lại là mảng số nguyên
            int[][] myArray = new int[][] {
                                new int[] {1,2},
                                new int[] {2,5,6},
                                new int[] {2,3},
                                new int[] {2,3,4,5,5}
                               };

            foreach (var arr in myArray)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine("...." + item);
                }
            }
        }
    }
}