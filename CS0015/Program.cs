using System;

namespace CS0015
{

    class TestGeneric
    {

        public X geneMethod<X>(X a)
        {
            return a;
        }

        public void swap<T>(ref T a, ref T b)
        {
            var t = a;
            a = b;
            b = t;
        }
    }

    class GenericMro<T>
    {
        private T bien;

        public GenericMro(T value)
        {
            bien = value;
        }

        public T TestMethod(T pr)
        {
            Console.WriteLine(pr);
            return bien;
        }

        public T thuoctinh { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestGeneric generic = new TestGeneric();
            int a = 20;
            int b = 100;
            generic.swap<int>(ref a, ref b);

            Console.WriteLine($"a is {a} : b is {b}");

            Console.WriteLine(generic.geneMethod<int>(b));

            GenericMro<double> myClass = new GenericMro<double>(123.123);
            myClass.TestMethod(123); // in ra 123
        }
    }
}