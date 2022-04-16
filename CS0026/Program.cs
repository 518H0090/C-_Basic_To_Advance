using System;
using System.IO;

namespace CS0026
{

    class Program
    {

        static void ListFileDirectory(string path)
        {
            String[] files = System.IO.Directory.GetFiles(path);
            String[] directories = System.IO.Directory.GetDirectories(path);
            // Lấy tất cả file ra
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            // Đệ quy lấy thư mục sau đó thực hiện lấy file trong thư mục con
            foreach (var directory in directories)
            {
                Console.WriteLine($"Directory is {directory}");
                ListFileDirectory(directory);
            }
        }

        static void Main(string[] args)
        {
            DriveInfo db = new DriveInfo(@"C:\");
            Console.WriteLine("  Volume label: {0}", db.VolumeLabel);
            Console.WriteLine("  File system: {0}", db.DriveFormat);
            Console.WriteLine("  Available space to current user:{0, 15} bytes", db.AvailableFreeSpace);
            Console.WriteLine("  Total available space:          {0, 15} bytes", db.TotalFreeSpace);
            Console.WriteLine("  Total size of drive:            {0, 15} bytes ", db.TotalSize);

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine("  Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);
                    Console.WriteLine("  Total available space:          {0, 15} bytes", d.TotalFreeSpace);
                    Console.WriteLine("  Total size of drive:            {0, 15} bytes ", d.TotalSize);
                }
            }

            string path = "obj";
            if (Directory.Exists(path))
            {
                ListFileDirectory(path);
            }

            Console.WriteLine(Path.DirectorySeparatorChar);

            var pathFile = Path.Combine("Dir1", "Dir2", "TenFile.text");
            pathFile = Path.ChangeExtension(pathFile, "md");
            Console.WriteLine(pathFile);
            Console.WriteLine(Path.GetDirectoryName(pathFile));
            Console.WriteLine(Path.GetExtension(pathFile));
            Console.WriteLine(Path.GetFileName(pathFile));
            Console.WriteLine(Path.GetFullPath(pathFile));

            var pathRandom = Path.GetRandomFileName();
            Console.WriteLine(pathRandom);
            Console.WriteLine(Path.GetFullPath(pathRandom));

            var pathTemp = Path.GetTempFileName();
            Console.WriteLine(pathTemp);

            string directorySave = "FileInHere";

            string FileName = "Thunghiem.txt";
            string contentInFile = "Huỳnh Trần Trung Hiếu Cố Lên";
            dynamic pathToFile;

            if (Directory.Exists(directorySave))
            {
                pathToFile = Path.Combine(directorySave, FileName);
                File.AppendAllText(pathToFile, contentInFile);
            }
            else
            {
                Directory.CreateDirectory(directorySave);
                pathToFile = Path.Combine(directorySave, FileName);
                File.WriteAllText(pathToFile, contentInFile);

            }

            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine(pathToFile);
            string contentGet = File.ReadAllText(pathToFile);
            Console.WriteLine(contentGet);

            // đổi tên file
            // File.Move(pathToFile, Path.Combine(directorySave, "Thanhcong.txt"));
            // copy nội dung file và tạo ra file mới
            // File.Move(Path.Combine(directorySave, "Thanhcong.txt"), Path.Combine(directorySave, "Thanhcong2.txt"));
        }
    }
}