using System;
using System.Linq;
using System.Collections.Generic;

namespace CS0034
{
    class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string[] Colors { set; get; }
        public int Brand { set; get; }

        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }

        public override string ToString() => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
    }

    class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("LinQ Part1");

            // Linq
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
                {
                    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
                };


            var kq = from product in products
                     where product.Price == 400
                     select product;

            foreach (var item in kq)
            {
                Console.WriteLine(item.ToString());
            }

            var kq2 = from product in products
                      select new
                      {
                          ten = product.Name.ToUpper(),
                          mausac = string.Join(",", product.Colors)
                      };

            foreach (var item in kq2) { Console.WriteLine(item.ten + " - " + item.mausac); }

            var kq3 = from product in products
                      from color in product.Colors
                      where product.Price < 500
                      where color == "vàng"
                      select product;

            foreach (var item in kq3)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}