using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CS0046
{
    interface IClassB
    {
        public void ActionB();
    }
    interface IClassC
    {
        public void ActionC();
    }

    class ClassC : IClassC
    {
        public ClassC() => Console.WriteLine("ClassC is created");
        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB : IClassB
    {
        IClassC c_dependency;
        public ClassB(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }


    class ClassA
    {
        IClassB b_dependency;
        public ClassA(IClassB classb)
        {
            b_dependency = classb;
            Console.WriteLine("ClassA is created");
        }
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

    class MyServiceOptions
    {
        public string data1 { set; get; }
        public int data2 { set; get; }
    }

    class MySerivce
    {
        public string data1 { set; get; }
        public int data2 { set; get; }

        public MySerivce(IOptions<MyServiceOptions> _options)
        {
            var options = _options.Value;
            data1 = options.data1;
            data2 = options.data2;
        }

        public void Info()
        {
            Console.WriteLine($" {data1} : {data2} ");
        }
    }

    class TestScope
    {
        public string data1 { set; get; }
        public int data2 { set; get; }
    }

    class Program
    {
        public static IClassB CreateB(IServiceProvider provider)
        {
            var b2 = new ClassB2(
                       provider.GetService<IClassC>(),
                       "Hello World"
                   );
            return b2;
        }

        static void Main(string[] args)
        {
            // DI Container
            var service = new ServiceCollection();

            // Add Service
            service.AddSingleton<ClassA, ClassA>();

            // 1
            // service.AddSingleton<IClassB, ClassB2>(
            //     (provider) =>
            //     {
            //         var b2 = new ClassB2(
            //             provider.GetService<IClassC>(),
            //             "Hello World"
            //         );
            //         return b2;
            //     }
            // );

            // 2
            service.AddSingleton<IClassB>(CreateB);

            service.AddSingleton<IClassC, ClassC>();

            service.AddSingleton<MySerivce>();

            service.Configure<MyServiceOptions>(
                (options) =>
                {
                    options.data1 = "Value 1";
                    options.data2 = 20;
                }
            );

            service.AddScoped<TestScope>();

            // provider 
            var provider = service.BuildServiceProvider();

            ClassA a = provider.GetService<ClassA>();
            a.ActionA();

            MySerivce mySerivce = provider.GetService<MySerivce>();
            mySerivce.Info();

            for (int i = 0; i < 5; i++)
            {
                var getScope = provider.GetService<TestScope>();
                Console.WriteLine(getScope.GetHashCode());
            }

            using (var newScope = provider.CreateScope())
            {
                var provider1 = newScope.ServiceProvider;
                for (int i = 0; i < 5; i++)
                {
                    var getScopeNew = provider1.GetService<TestScope>();
                    Console.WriteLine(getScopeNew.GetHashCode());
                }
            }
        }
    }
}