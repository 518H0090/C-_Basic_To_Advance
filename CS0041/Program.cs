using System;

namespace CS0041
{
    // tạo attribute
    // Phạm vi truy cập
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    class MotaAttribute : Attribute
    {
        public string ThongTinChiTiet { set; get; }
        public MotaAttribute(string _ThongTinChiTiet)
        {
            ThongTinChiTiet = _ThongTinChiTiet;
        }
    }

    [Mota("Lop chứa thông tin user")]
    class User
    {
        [Mota("Tên người dùng")]
        public string Name { set; get; }
        [Mota("tuổi")]
        public int Age { set; get; }
        [Mota("sdt")]
        public string PhoneNumber { set; get; }
        [Mota("Email dùng")]
        public string Email { set; get; }

        // Đánh dấu đã lỗi thời
        [Obsolete("Phương thức đã lỗi thời cần thay thế ")]
        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Attribute
            // ObsoleteAttribute đánh dấu đã lỗi thời
            User user = new User()
            {
                Name = "haha",
                Age = 20,
                PhoneNumber = "2520082",
                Email = "hoichua@gmail.com"
            };

            user.PrintInfo();

            var propertyGet = user.GetType().GetProperties();
            foreach (var property in propertyGet)
            {
                foreach (var item in property.GetCustomAttributes(false))
                {
                    MotaAttribute mota = item as MotaAttribute;
                    if (mota != null)
                    {
                        var Name = property.Name;
                        var valueGet = property.GetValue(user);

                        Console.WriteLine($"{Name} : {valueGet} : {mota.ThongTinChiTiet}");
                    }
                }
            }
        }
    }
}