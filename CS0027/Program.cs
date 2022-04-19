using System;

namespace CS0027
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string direc = "ABS";
            string filename = "ABS.text";
            if (Directory.Exists(direc))
            {
                Console.WriteLine("File đã tồn tại");
            }
            else
            {
                Console.WriteLine("File được tạo");
                Directory.CreateDirectory(direc);
            }
            var path = Path.Combine(direc, filename);
            if (File.Exists(path))
            {
                File.AppendAllText(path, "Đã tồn tại");
            }
            else
            {
                File.WriteAllText(path, "Khởi tạo file");
            }

            Console.WriteLine("Đọc file {0}", File.ReadAllText(path));

        }
    }
}