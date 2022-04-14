using System;

namespace CS0012
{

    public struct Product
    {
        public string name;
        public decimal price;


        public override string ToString() => $"{name} : {price}$";

    }

    public struct Product2
    {


        public Product2(string _name)
        {
            name = _name;  // đồng nghĩa khởi tạo thuộc tính Name
            price = 100;
            Description = "Mô tả về sản phẩm {name}";
        }

        public string name;   // trường tên sản phẩm
        public decimal price; // trường giá sản phẩm

        // Phương thức sinh ra chuỗi thông tin
        public override string ToString() => $"{name} : {price}$";

        // Thuộc tính Name
        public string Name { set => name = value; get => name; }
        // Thuộc tính Description
        public string Description { set; get; }


    }

    enum ColorText
    {
        Red = 10,
        Yellow = 20,
        Green = 30,
        Black = 40
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product;
            product.name = "Iphone";
            product.price = 200000;

            Console.WriteLine(product.name);
            Console.WriteLine(product.price);

            // gán struct, là sao chép giá trị chứ không tham chiếu như lớp
            Product product2 = product;

            Console.WriteLine(product.ToString());
            Console.WriteLine(product2.ToString());

            Product2 product3 = new Product2("Ipad");

            Console.WriteLine(product3.ToString());

            ColorText colorText = ColorText.Red;
            int colorValue = (int)ColorText.Red;
            ColorText colorGetThroughNum = (ColorText)30;
            Console.WriteLine(colorText);
            Console.WriteLine(colorValue);
            Console.WriteLine(colorGetThroughNum);
        }
    }
}