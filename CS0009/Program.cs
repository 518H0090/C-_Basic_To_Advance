using System;
using ProductProgram;
using CategoryProgram;
using ColorName;

namespace CS0009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helllo CS0009");

            Product product = new Product("Iphone X", 20000m);
            Console.WriteLine(product.Name);

            // --------------------
            CategoryMobile categoryMobile = new CategoryMobile("Mobile", "List of mobile");

            Console.WriteLine(categoryMobile.CategoryValue);
            Console.WriteLine(categoryMobile.Description);

            // ---------------------
            // Lỗi vì private construct
            // CategoryPrivate categoryPrivate = new CategoryPrivate();

            Console.WriteLine(CategoryPrivate.PI);

            // ----------------------------------

            Console.WriteLine(ColorChoice.color_danger);
            Console.WriteLine(ColorChoice.color_success);
            Console.WriteLine(ColorChoice.color_info);
        }
    }
}