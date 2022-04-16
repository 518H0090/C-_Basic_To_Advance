using System;

namespace CS0020
{
    class Program
    {

        public delegate int CaculLate(int a, int b);
        static void Main(string[] args)
        {
            CaculLate caculLate = (int a, int b) => a + b;

            int kq = caculLate.Invoke(5, 1);
            Console.WriteLine(kq);

            Func<int, int, int> calculateTwoNumber = (a, b) => a + b;

            Action<int> getCalculate = (result) => Console.WriteLine(result);

            getCalculate(caculLate(5, 6));
        }
    }
}