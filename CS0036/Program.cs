using System;
using System.Linq;
using System.Collections.Generic;

namespace CS0036
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // cá màu
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }

    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var brands = new List<Brand>()
            {
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

            // basic Linq
            var basicLinq = from p in products
                            select p.Name;

            // same result
            basicLinq.ToList().ForEach(p => Console.WriteLine(p));
            foreach (var item in basicLinq)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------------");

            // where in linq
            var kq = from p in products
                     where p.Price == 400
                     select new
                     {
                         Name = p.Name,
                         Price = p.Price
                     };

            kq.ToList().ForEach(p => Console.WriteLine(p));

            Console.WriteLine("--------------------------------------------");
            // Many from
            var kq2 = from p in products
                      from color in p.Colors
                      where p.Price <= 500 && color == "Xanh"
                      orderby p.Price descending
                      select new
                      {
                          Name = p.Name,
                          Price = p.Price,
                          ColorInHere = string.Join(",", p.Colors)
                      }
                     ;

            kq2.ToList().ForEach(p => Console.WriteLine(p));

            // Group by
            Console.WriteLine("--------------------------------------------");
            var kq3 = from p in products
                      group p by p.Price into temp
                      orderby temp.Key
                      select temp;

            kq3.ToList().ForEach(group =>
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            });

            Console.WriteLine("------------------------");
            // Let variable
            var kq4 = from p in products
                      group p by p.Price into gr
                      orderby gr.Key
                      let countValue = "Number of count" + gr.Count()
                      select new
                      {
                          Price = gr.Key,
                          AllProduct = gr.ToList(),
                          Quantity = countValue
                      };

            kq4.ToList().ForEach(i =>
            {
                Console.WriteLine(i.Price);
                Console.WriteLine(i.Quantity);
                i.AllProduct.ForEach(j => Console.WriteLine(j));
            });


            Console.WriteLine("--------------------");
            // Join
            var kq5 = from p in products
                      join b in brands
                      on p.Brand equals b.ID into temp
                      from brand in temp.DefaultIfEmpty()
                      select new
                      {
                          Ten = p.Name,
                          Gia = p.Price,
                          ThuongHieu = (brand != null) ? brand.Name : "Null"
                      };

            kq5.ToList().ForEach(value =>
                {
                    Console.WriteLine($"{value.Ten,10} : {value.Gia,15} : {value.ThuongHieu,5}");
                });
        }
    }
}