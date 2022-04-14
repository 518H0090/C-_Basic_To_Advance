using System;

namespace ProductProgram
{
    class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public Product()
        {
            this.name = "Default";
            this.price = 2525252.882m;
        }

        public string Name
        {
            set => name = value;
            get => name;
        }




    }
}