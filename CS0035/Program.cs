using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CS0035
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

            // thêm dữ liệu vào
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

            // Truy vấn linq cơ bản
            var query = from p in products
                        where p.Price > 400
                        select p;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");

            // Api mở rộng từ Enumerable và Sysm.linq

            // Select
            var kqSelect = products.Select(
                (p) =>
                {
                    return p.Name;
                });

            foreach (var item in kqSelect)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            // Where
            var kqWhere = products.Where(
                (p) =>
                {
                    return p.Name.Contains("tr");
                }
            );

            foreach (var item in kqWhere)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            // SelectMany
            var kqSelectMany = products.SelectMany(
                (p) =>
                {
                    return p.Colors;
                }
            );

            foreach (var item in kqSelectMany)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            // Min,Max,Sum,Average
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(Numbers.Min());
            Console.WriteLine(Numbers.Max());
            Console.WriteLine(Numbers.Sum());
            Console.WriteLine(Numbers.Average());

            // Số chẵn lớn nhất
            Console.WriteLine(Numbers.Where(p => p % 2 == 0).Max());

            // Min kết hợp
            Console.WriteLine(products.Min(p => p.Price));

            Console.WriteLine("----------------");
            // Join
            var kqJoin = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
            {
                return new
                {
                    Ten = p.Name,
                    ThuongHieu = p.Brand,
                };
            });

            foreach (var item in kqJoin)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            // Group Join
            var kqGroupJoin = brands.GroupJoin(products, b => b.ID, p => p.Brand,

                (brands, products) =>
                {
                    return new
                    {
                        Thuonghieu = brands.Name,
                        product = products
                    };
                }
            );

            foreach (var item in kqGroupJoin)
            {
                Console.WriteLine(item.Thuonghieu);
                foreach (var valueItem in item.product)
                {
                    Console.WriteLine(valueItem);
                }
            }

            Console.WriteLine("----------------");
            // Take lấy những thằng đầu tiên dựa vào n truyền vào
            products.Take(3).ToList().ForEach(
                p => Console.WriteLine(p)
            );

            Console.WriteLine("----------------");
            // Skip bỏ qua những phần tử đầu tiên dựa vào n truyền vào
            products.Skip(3).ToList().ForEach(
                p => Console.WriteLine(p)
            );

            Console.WriteLine("----------------");
            // Order
            products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("----------------");
            // OrderDesencding
            products.OrderByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("----------------");

            // Reverse
            Numbers.Reverse().ToList().ForEach(n => Console.WriteLine(n));

            Console.WriteLine("----------------");
            // Group By
            var kqGroupBy = products.GroupBy(p => p.Brand);
            // nhóm theo key
            foreach (var item in kqGroupBy)
            {
                Console.WriteLine(item.Key);
                foreach (var itemValue in item)
                {
                    Console.WriteLine(itemValue);
                }
            }
            Console.WriteLine("----------------");
            // Distinct loại bỏ phần tử trùng lặp
            products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(value => Console.WriteLine(value));

            Console.WriteLine("----------------");
            // Single or SingleDefault nhiều hơn 1 thì báo lỗi
            var kqSingle = products.SingleOrDefault(p => p.Price == 600);
            Console.WriteLine(kqSingle);

            Console.WriteLine("----------------");
            // Any kiểm tra xem có sản phẩm thỏa điều kiện thì true
            var productFind = products.Any(p => p.Price == 600);
            Console.WriteLine(productFind);

            Console.WriteLine("----------------");
            // All kiểm tra yêu cầu tất cả phần tử phải thõa mản điều kiện logic thì true còn lại false
            var productFindAll = products.All(p => p.Price == 600);
            Console.WriteLine(productFindAll);

            var productFindAllGreaterThan200 = products.All(p => p.Price >= 200);
            Console.WriteLine(productFindAllGreaterThan200);

            Console.WriteLine("----------------");
            // Count
            var pCount = products.Count();
            Console.WriteLine(pCount);

            var pCountGreater300 = products.Count(p => p.Price >= 400);
            Console.WriteLine(pCountGreater300);

            Console.WriteLine("-------------------");
            // Combine API LINQ
            products.Where(p => p.Price >= 300 && p.Price <= 400)
            .OrderByDescending(p => p.Price).Join(brands, p => p.Brand, b => b.ID, (p, b) =>
            {
                return new
                {
                    TenSP = p.Name,
                    TenTH = b.Name,
                    Gia = p.Price
                };
            }).ToList().ForEach(info => Console.WriteLine($"{info.TenSP} : {info.TenTH} : {info.Gia}")
            );
        }
    }
}