using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CS0045
{

    interface IClassC
    {
        public void ActionC();
    }

    interface IClassB
    {
        public void ActionB();
    }
    class ClassC : IClassC
    {
        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB : IClassB
    {
        // Phụ thuộc của ClassB là ClassC
        IClassC c_dependency;

        public ClassB(IClassC classc) => c_dependency = classc;
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }

    class ClassA
    {
        // Phụ thuộc của ClassA là ClassB
        IClassB b_dependency;

        public ClassA(IClassB classb) => b_dependency = classb;
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            b_dependency.ActionB();
        }
    }

    class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine("ClassC1 is created");
        public void ActionC()
        {
            Console.WriteLine("Action in C1");
        }
    }

    class ClassB1 : IClassB
    {
        IClassC c_dependency;
        public ClassB1(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB1 is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in B1");
            c_dependency.ActionC();
        }
    }

    class ClassB2 : IClassB
    {
        IClassC c_dependency;
        string message;
        public ClassB2(IClassC classc, string mgs)
        {
            c_dependency = classc;
            message = mgs;
            Console.WriteLine("ClassB2 is created");
        }
        public void ActionB()
        {
            Console.WriteLine(message);
            c_dependency.ActionC();
        }
    }

    public class MyServiceOptions
    {
        public string data { set; get; }
        public int data2 { set; get; }
    }

    public class MyService
    {
        public string data1 { set; get; }
        public int data2 { set; get; }

        public MyService(IOptions<MyServiceOptions> options)
        {
            var _options = options.Value;
            data1 = _options.data;
            data2 = _options.data2;
        }

        public void PrintData1() => Console.WriteLine($"{data1} : {data2}");
    }

    class Program
    {
        // Factory
        public static IClassB CreateB2(IServiceProvider provider)
        {
            var b2 = new ClassB2(
                                    provider.GetService<IClassC>(),
                                    "Thực hiện giá trị"
                                );
            return b2;
        }

        static void Main(string[] args)
        {
            // DI Container
            var services = new ServiceCollection();

            // Đăng ký dịch vụ
            // IClassC triển khai ClassC và ClassC1
            // services.AddSingleton<IClassC, ClassC1>();
            // services.AddTransient<IClassC, ClassC1>();
            // services.AddScoped<IClassC, ClassC1>();

            // Inject Dependency
            services.AddSingleton<ClassA, ClassA>();
            services.AddSingleton<IClassB>(CreateB2);
            services.AddSingleton<IClassC, ClassC>();

            services.AddSingleton<MyService>();
            services.Configure<MyServiceOptions>(
                (MyServiceOptions options) =>
                {
                    options.data = "Hello 1";
                    options.data2 = 25252;
                }
            );

            // Service Provider
            var provider = services.BuildServiceProvider();


            // Lấy ra service
            // var classC = provider.GetServices<IClassC>();

            // for (int i = 0; i < 5; i++)
            // {
            //     IClassC c = provider.GetService<IClassC>();
            //     Console.WriteLine(c.GetHashCode());
            // }

            // using (var scope = provider.CreateScope())
            // {
            //     var provider1 = scope.ServiceProvider;
            //     for (int i = 0; i < 5; i++)
            //     {
            //         IClassC c1 = provider1.GetService<IClassC>();
            //         Console.WriteLine(c1.GetHashCode());
            //     }
            // }

            ClassA a = (ClassA)provider.GetService<ClassA>();
            a.ActionA();

            var myService = provider.GetService<MyService>();
            myService.PrintData1();
        }
    }
}