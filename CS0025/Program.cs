using System;

namespace CS0025
{
    class TestIdispo : IDisposable
    {
        public bool resource = true;

        public void Dispose()
        {
            Console.WriteLine("Ra ngoai using");
            resource = false;
        }
    }

    public class WriteData : IDisposable
    {

        // trường lưu trạng thái Dispose
        private bool m_Disposed = false;

        private StreamWriter stream;

        public WriteData(string filename)
        {
            stream = new StreamWriter(filename, true);
        }

        // Phương thức triển khai từ giao diện
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Nếu disposing = true -> Được thi hành do gọi trực tiếp (do Dispose gọi)
        // tài nguyên managed, unmanaged được giải phóng
        // nếu disposing = fale -> Được thi hành bởi phương thức hủy, chỉ cần giải phóng
        // các toàn nguyên unmanaged.
        protected virtual void Dispose(bool disposing)
        {
            if (!m_Disposed)
            {
                if (disposing)
                {
                    // các đối tượng có Dispose gọi ở đây
                    stream.Dispose();
                }

                // giải phóng các tài nguyên không quản lý được cửa lớp (unmanaged)

                m_Disposed = true;
            }
        }

        ~WriteData()
        {
            Dispose(false);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var A = new TestIdispo())
            {
                Console.WriteLine(A.resource);
            }

            using (WriteData writeData1 = new WriteData("filename.txt"))
            {
                // do something
            }

            WriteData writeData2 = new WriteData("filename.txt");
            //do something
            writeData2.Dispose();
        }
    }
}