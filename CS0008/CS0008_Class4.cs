using System;

namespace CS0008_Class4
{
    public class Student
    {



        public string Name
        {
            set; get;
        }

        public string studentId { set; get; }

        // Constructor
        public Student(string name, string id)
        {
            Name = name;
            studentId = id;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Khởi tạo phương thức với {Name} và {studentId} ");
        }

        // Destroy method
        ~Student()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hủy bỏ Student");
            Console.ResetColor();
        }
    }
}