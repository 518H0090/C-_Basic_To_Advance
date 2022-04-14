using System;
using System.Linq;


namespace CS0016
{
    class Program
    {

        class Student
        {
            public string fullName { set; get; }
            public int birthYear { set; get; }
            public string locationBirth { set; get; }
        }

        static void Main(string[] args)
        {
            var sanpham = new
            {
                name = "Iphone 8",
                price = 20000,
                Namsx = 2000
            };

            Console.WriteLine(sanpham.name);
            Console.WriteLine(sanpham.price);
            Console.WriteLine(sanpham.Namsx);

            // ------------------------------------

            List<Student> students = new List<Student>() {
                new Student() {fullName = "Sinh vien 1", birthYear = 2000, locationBirth ="TPHCM"},
                new Student() {fullName = "Sinh vien 2", birthYear = 2001, locationBirth ="TPHCM1"},
                new Student() {fullName = "Sinh vien 3", birthYear = 2002, locationBirth ="TPHCM2"},
                new Student() {fullName = "Sinh vien 4", birthYear = 2003, locationBirth ="TPHCM3"},
                new Student() {fullName = "Sinh vien 5", birthYear = 2004, locationBirth ="TPHCM4"},
                new Student() {fullName = "Sinh vien 6", birthYear = 2005, locationBirth ="TPHCM5"},
                new Student() {fullName = "Sinh vien 7", birthYear = 2006, locationBirth ="TPHCM6"},
            };


            var dulieu = from kq in students
                         where kq.birthYear >= 2002
                         select new
                         {
                             fullname = kq.fullName,
                             birthYear = kq.birthYear,
                             locationBirth = kq.locationBirth
                         };

            foreach (var sv in dulieu)
            {
                Console.WriteLine($"{sv.fullname} : {sv.birthYear} : {sv.locationBirth} ");
            }
        }
    }
}