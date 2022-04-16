using ProductInfo;
using System;
using InTerProduct;

namespace CS0018
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Iphone();

            p1.TestProduct();
            p2.TestProduct();

            ExProduct AbProduct = new ExProduct();

            AbProduct.TestProduct();

            ProductAbIn productAbIn = new ProductAbIn();
            productAbIn.OrderAction(30);
            productAbIn.getQuantity(10);
            productAbIn.showPrice();
        }
    }
}