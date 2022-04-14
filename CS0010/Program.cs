using System;
using ReferenceValueIn;

namespace CS0010
{
    class Program
    {

        static void UpperCaseStudent(Student student)
        {
            student.Name = student.Name.ToUpper();
        }

        // Lưu ý nếu chỉ set int và return a thì nó chỉ là a ta phải gán a = giá trị tăng ví dụ a = a + 10
        static void DoubleNumberValue(ref int a)
        {
            a = a * a;
        }

        static void AssignToAHundred(out int b)
        {
            b = 100;
        }

        static void Main(string[] args)
        {
            // Ví dụ Student A và Student B đều tham chiếu đến với một đối tượng là Student
            // Student A hoặc B thay đổi thì đều tác động đối tượng student
            Student studentA = new Student("Hello Student A");
            Console.WriteLine(studentA.Name);

            Student studentB;
            studentB = studentA;

            studentB.Name = "Hello Student B";

            Console.WriteLine(studentA.Name);
            // ----------------------------
            Student studentC = new Student("hello student c");
            UpperCaseStudent(studentC);
            Console.WriteLine(studentC.Name);

            // use ref
            int a = 20;
            DoubleNumberValue(ref a);
            Console.WriteLine(a);

            // user out
            int b;
            AssignToAHundred(out b);
            Console.WriteLine(b);

        }
    }
}