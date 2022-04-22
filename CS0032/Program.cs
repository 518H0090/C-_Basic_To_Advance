using System;
using System.Collections;
using System.Collections.Generic;

namespace CS0032
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            // Lớp Dictionary<Tkey,TValue> khá giống SortedList, Dictionary được thiết kế với mục đích tăng hiệu quả với tập dữ liệu lớn, phức tạp.
            Console.WriteLine("Dictionary");

            Dictionary<string, int> dictionValue = new Dictionary<string, int>()
            {
                ["number3"] = 3,
                ["number4"] = 4
            };

            dictionValue.Add("Number6", 6);
            dictionValue["number7"] = 7;

            foreach (var item in dictionValue)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            // SortedDictionary

            Console.WriteLine("Sorted Dictionary");
            /*
            Lớp SortedDictionary<Tkey,TValue> sử dụng, khai báo và khởi tạo ... giống như lớp Dictionary<Tkey,TValue>.

            Chỉ cần lưu ý, nếu dùng SortedDictionary thì các các phần tử được lưu và sắp xếp theo key, thích hợp khi tăng tốc chèn, xóa, tìm kiếm theo key.
            */
            SortedDictionary<string, string> sortedDiction = new SortedDictionary<string, string>();
            for (int i = 0; i < 10; i++)
            {
                sortedDiction.Add("Key" + i, "Value" + (i + 1));
            }

            foreach (var item in sortedDiction)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            // HashSet
            HashSet<int> hashSet1 = new HashSet<int>(){
                1,2,3,4,5,6,7,8,9,10
            };

            Console.WriteLine($"phần tử trong HashSet {hashSet1.Count}");

            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }

            HashSet<int> hashSet2 = new HashSet<int>();
            hashSet2.Add(3);
            hashSet2.Add(4);
            hashSet2.Add(5);
            hashSet2.Add(7);
            hashSet2.Add(6);
            hashSet2.Add(10);
            hashSet2.Add(20);
            hashSet2.Add(30);

            Console.WriteLine($"phần tử trong HashSet {hashSet2.Count}");

            foreach (var item in hashSet2)
            {
                Console.WriteLine(item);
            }
            // Union
            Console.WriteLine("Union");
            hashSet1.UnionWith(hashSet2);

            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }

            // Intersec
            Console.WriteLine("Intersec");
            hashSet1.IntersectWith(hashSet2);

            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }

            // Except
            Console.WriteLine("Except");
            hashSet1.ExceptWith(hashSet2);

            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }
        }
    }
}