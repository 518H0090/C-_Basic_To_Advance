// ôn tập type
using System;

namespace CS0040
{
    class User
    {
        public string userName { set; get; }
        public string passWord { set; get; }
        public long phoneNumber { set; get; }

        public string Address { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                userName = "chaymetwa",
                passWord = "00992",
                phoneNumber = 252525252,
                Address = "TPHCM"
            };

            Type t1 = user.GetType();
            Console.WriteLine(t1.FullName);

            var propertyNeed = t1.GetProperties();

            foreach (var item in propertyNeed)
            {
                var NameProperty = item.Name;
                Console.WriteLine($"Name Property: {NameProperty}");

                // Lấy dữ liệu property từ user
                var ValueProperty = item.GetValue(user);
                Console.WriteLine($"Value Property: {ValueProperty}");
            }
        }
    }
}