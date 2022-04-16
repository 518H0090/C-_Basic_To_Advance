
namespace EventHandTest
{

    class MyEventArgs : EventArgs
    {
        private string data;

        public MyEventArgs(string data)
        {
            this.data = data;
        }

        public string Data { get => this.data; }
    }

    class ClassA
    {
        public event EventHandler<MyEventArgs> event_news;

        public void Send()
        {
            this.event_news?.Invoke(this, new MyEventArgs("Đã gửi đi từ A"));
        }
    }

    class ClassB
    {
        public void Sub(ClassA A)
        {
            A.event_news += ReceiverFromPubliser;
        }

        public void ReceiverFromPubliser(object sender, MyEventArgs e)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"B Receive Message from A : {e.Data}");
        }
    }

    class ClassC
    {
        public void Sub(ClassA A)
        {
            A.event_news += ReceiverFromPubliser;
        }

        public void ReceiverFromPubliser(object sender, MyEventArgs e)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"C Receive Message from A : {e.Data}");
        }
    }
}