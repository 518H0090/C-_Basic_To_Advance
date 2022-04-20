using System;
using System.Text;

namespace CS0027
{

    class Product
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public double Price { set; get; }

        public void Save(Stream stream)
        {
            // int = 4byte
            var byte_id = BitConverter.GetBytes(ID);
            stream.Write(byte_id, 0, 4);

            // double = 8 byte
            var byte_price = BitConverter.GetBytes(Price);
            stream.Write(byte_price, 0, 8);

            // string tùy byte
            var byte_name = Encoding.UTF8.GetBytes(Name);
            var byte_length = BitConverter.GetBytes(byte_name.Length);

            stream.Write(byte_length, 0, 4);
            stream.Write(byte_name, 0, byte_name.Length);

        }

        public void Restore(Stream stream)
        {
            var byte_id = new byte[4];
            stream.Read(byte_id, 0, 4);
            ID = BitConverter.ToInt32(byte_id, 0);

            var byte_price = new byte[8];
            stream.Read(byte_price, 0, 8);
            Price = BitConverter.ToDouble(byte_price, 0);

            var byte_length = new byte[4];
            stream.Read(byte_length, 0, 4);
            int length = BitConverter.ToInt32(byte_length, 0);

            var byte_name = new byte[length];
            stream.Read(byte_name, 0, length);
            Name = Encoding.UTF8.GetString(byte_name, 0, length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "trunghieu.dat";
            using var fileStream = new FileStream(path: fileName, mode: FileMode.OpenOrCreate);

            // Product productForSave = new Product()
            // {
            //     ID = 10,
            //     Name = "Iphone Plus",
            //     Price = 200833.282
            // };

            // productForSave.Save(fileStream);

            Product productForSave = new Product();
            productForSave.Restore(fileStream);

            Console.WriteLine($"{productForSave.ID} : {productForSave.Name} : {productForSave.Price}");
        }
    }
}