using System;

namespace ProductInfo
{
    public class Product
    {
        protected double price = 0;

        public virtual void ProductInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Giá sản phẩm {price}");
        }

        public void TestProduct()
        {
            this.ProductInfo();
        }
    }

    public class Iphone : Product
    {
        public Iphone()
        {
            price = 500;
        }

        public override void ProductInfo()
        {
            Console.WriteLine($"Điện thoại Iphone");
            base.ProductInfo();
        }
    }

    public abstract class ProductAbstract
    {
        protected double price = 0;

        public abstract void ProductInfo();


        public void TestProduct()
        {
            this.ProductInfo();
        }
    }

    public class ExProduct : ProductAbstract
    {
        public ExProduct()
        {
            price = 500;
        }

        public override void ProductInfo()
        {
            Console.WriteLine($"Extend with price is : {price}");
        }
    }

}