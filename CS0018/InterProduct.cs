using System;

namespace InTerProduct
{
    interface IProduct
    {
        public void showPrice();
    }

    interface IOrder
    {
        public void OrderAction(int numberProduct);
    }


    abstract class ProductEx
    {
        protected int quantity;
        public abstract void getQuantity(int quantity);
    }

    class ProductAbIn : ProductEx, IProduct, IOrder
    {

        public ProductAbIn()
        {
            quantity = 50;
        }

        public override void getQuantity(int quantity)
        {
            Console.WriteLine($"Quantity good : {quantity}");
        }

        public void OrderAction(int numberProduct)
        {
            Console.WriteLine($"Quantity good : {numberProduct}");
        }

        public void showPrice()
        {
            Console.WriteLine($"Quantity good : {this.quantity * 20000}");
        }
    }
}