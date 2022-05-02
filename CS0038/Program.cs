using System;
using CS0038_lib;
using Newtonsoft.Json;

namespace CS0038
{
    class Product
    {
        public string Name { set; get; }
        public DateTime Expiry { set; get; }
        public string[] Sizes { set; get; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }

            Console.WriteLine(json);

            // dotnet add D:\C#_visualcode\C-_Basic_To_Advance\CS0038\CS0038.csproj reference D:\C#_visualcode\C-_Basic_To_Advance\CS0038_lib\CS0038_lib.csproj
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double a = 41412421412412;
            var kq = ConvertMoneyToText.NumberToText(a);

            Console.WriteLine(kq);
        }
    }
}