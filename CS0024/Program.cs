using System;

namespace CS0024
{
    public class DataTooLongMessage : Exception
    {
        const string errorMessage = "Text is too long";

        public DataTooLongMessage() : base(errorMessage)
        {

        }
    }


    class Program
    {
        public static void UserInput(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongMessage();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }

        public static double Thuong(double x, double y)
        {
            if (y == 0)
            {
                // Khởi tạo ngoại lệ, tham số là thông báo lỗi
                Exception myexception = new Exception("Số chia không được bằng 0");

                // phát sinh ngoại lệ, code phía sau throw không được thực thi
                throw myexception;
            }
            return x / y;
        }

        static void Main(string[] args)
        {
            try
            {
                UserInput("Đây là một chuỗi rất dài ...");
            }
            catch (DataTooLongMessage e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception otherExeption)
            {
                Console.WriteLine(otherExeption.Message);
            }

            try
            {
                int[] mynumbers = new int[] { 1, 2, 3 };
                // int i = mynumbers[10];
                double x = 10;
                double y = 0;
                double z = Thuong(x, y);
                Console.WriteLine("Value {0}", z);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error" + e.Message);
                Console.WriteLine("Error" + e.StackTrace);
                Console.WriteLine("Error" + e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
                Console.WriteLine("Error" + e.StackTrace);
                Console.WriteLine("Error" + e.Source);
            }
            finally
            {
                Console.WriteLine("Thi hành");
            }
        }
    }
}