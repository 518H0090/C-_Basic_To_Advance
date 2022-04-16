using System;
using EventHandTest;

namespace CS0021
{
    class Program
    {

        class Publisher
        {
            public delegate void NotifyNews(object data);

            public event NotifyNews event_news;

            public void Send()
            {
                this.event_news?.Invoke("Đã gửi đi");
            }
        }

        class SubscriberA
        {
            public void Sub(Publisher p)
            {
                p.event_news += EventFromPublisher;
            }

            public void EventFromPublisher(object A)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine($"Data Message A : {A}");
            }
        }

        class SubscriberB
        {
            public void Sub(Publisher p)
            {
                p.event_news += EventFromPublisher;
            }

            public void EventFromPublisher(object B)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine($"Data Message B : {B}");
            }
        }

        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            SubscriberA sA = new SubscriberA();
            SubscriberB sB = new SubscriberB();

            sA.Sub(p);
            sB.Sub(p);

            p.Send();

            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            ClassC classC = new ClassC();

            classB.Sub(classA);
            classC.Sub(classA);

            classA.Send();
        }
    }
}