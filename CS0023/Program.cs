using System;

namespace CS0023
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4, "Hello");
            Vector v2 = new Vector(5, 6, "World");
            v1.showXY();
            v2.showXY();

            Vector v3 = v1 + v2;
            v3.showXY();

            IndexerExam indexerExam = new IndexerExam();
            Console.WriteLine(indexerExam[0] + " " + indexerExam[1]);      // đọc obj.ho và obj.ten
            indexerExam[0] = "Đinh";                               // gán obj.ho
            indexerExam[1] = "Quang Hưng";                         // gán obj.name
            Console.WriteLine(indexerExam[0] + " " + indexerExam[1]);      // đọc obj.ho và obj.ten


            IndexerExamString indexerExamString = new IndexerExamString();
            Console.WriteLine(indexerExamString["h1"] + " " + indexerExamString["h2"]);
            indexerExamString["h1"] = "Funny";
            indexerExamString["h2"] = "Sad";
            Console.WriteLine(indexerExamString["h1"] + " " + indexerExamString["h2"]);

        }
    }

    class Vector
    {
        double x;
        double y;

        readonly string name;

        public Vector(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void showXY()
        {
            Console.WriteLine("Show X {0}", x);
            Console.WriteLine("Show Y {0}", y);
            Console.WriteLine("Show name {0}", name);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.name + v2.name);
        }
    }

    class IndexerExam
    {
        string firstName = "Trung";
        string lastName = "Hieu";

        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return firstName;
                    case 1:
                        return lastName;
                    default:
                        throw new Exception("Chỉ số không tồn tại");
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        firstName = value;
                        break;
                    case 1:
                        lastName = value;
                        break;
                    default:
                        throw new Exception("Chỉ số không tồn tại");
                }
            }
        }
    }

    class IndexerExamString
    {
        string value1 = "Hehe";
        string value2 = "haha";

        public string this[string index]
        {
            set
            {
                switch (index)
                {
                    case "h1":
                        value1 = value;
                        break;
                    case "h2":
                        value2 = value;
                        break;
                    default:
                        throw new Exception("Error");
                }
            }

            get
            {
                switch (index)
                {
                    case "h1":
                        return value1;
                    case "h2":
                        return value2;
                    default:
                        throw new Exception("Error");
                }
            }
        }
    }
}