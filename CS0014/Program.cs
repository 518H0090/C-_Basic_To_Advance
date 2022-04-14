using System;
using TestNameSpace;

namespace CS0014
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Hello World");
            product.consoleNameOutD(product.Name);
        }
    }
}