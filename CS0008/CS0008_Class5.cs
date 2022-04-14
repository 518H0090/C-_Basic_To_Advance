using System;

namespace CS0008_Class5
{
    public class DestoryByDispobale : IDisposable
    {

        public string Name { set; get; } = "Default";

        public DestoryByDispobale(string name)
        {
            Name = name;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tạo");
            Console.ResetColor();
        }

        public void Dispose()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hủy bỏ");
            Console.ResetColor();
        }
    }
}