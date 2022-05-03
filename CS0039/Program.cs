using System;
using System.Reflection;

namespace CS0039
{
    class User
    {
        public string Name { set; get; }
        public int age { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Type t1 = typeof(int);
            Console.WriteLine(t1);
            var t = a.GetType();
            Console.WriteLine(t.FullName);

            int[] aR = { 1, 2, 3, 4, 5 };
            Type t2 = aR.GetType();
            Console.WriteLine(t2.FullName);

            t2.GetProperties().ToList().ForEach(
                (aB) =>
                {
                    Console.WriteLine(aB.Name);
                }
            );

            t2.GetFields().ToList().ForEach(
                           (FieldInfo aB) =>
                           {
                               Console.WriteLine(aB.Name);
                           }
                       );

            t2.GetMethods().ToList().ForEach(
                (aB) =>
                {
                    Console.WriteLine(aB.Name);
                }
            );

            User user = new User() { Name = "OK haha", age = 20, PhoneNumber = "202022", Email = "nhox@gmail.com" };
            Console.WriteLine("------------------");

            var propertyGet = user.GetType().GetProperties();
            foreach (var item in propertyGet)
            {
                string Name = item.Name;
                var ValueGet = item.GetValue(user);
                Console.WriteLine($"{Name} : {ValueGet}");
            }
        }
    }
}