using System;

namespace CategoryProgram
{
    class CategoryMobile : Category
    {
        private string description;

        public string Description
        {
            set => description = value;
            get => description;
        }

        public CategoryMobile(string category, string description) : base(category)
        {
            this.description = description;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Create Child Construct");
            Console.ResetColor();
        }


    }
}