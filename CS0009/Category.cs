using System;

namespace CategoryProgram
{
    class Category
    {

        private string category;

        public string CategoryValue
        {
            set => category = value;
            get => category;
        }

        public Category(string category)
        {
            this.category = category;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Create Father Construc");
            Console.ResetColor();
        }


    }
}