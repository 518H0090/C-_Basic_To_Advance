using System;
using System.Net;
using System.Net.NetworkInformation;

namespace CS0051
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uri
            string url = "https://blogtruyen.vn/";

            Uri uri = new Uri(url);

            var typeUri = uri.GetType();

            typeUri.GetProperties().ToList().ForEach(
                typeU => Console.WriteLine($"{typeU.Name} : {typeU.GetValue(uri)}")
            );

            Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");

            // Dns
            var hostNAme = Dns.GetHostName();

            Console.WriteLine(hostNAme);

            string url2 = "https://www.bootstrapcdn.com/";
            var uri2 = new Uri(url2);
            var hostEntry = Dns.GetHostEntry(uri2.Host);
            Console.WriteLine($"Host {uri2.Host} có các IP");
            hostEntry.AddressList.ToList().ForEach(
                ip => Console.WriteLine(ip)
            );

            // Ping
            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn");
            Console.WriteLine(pingReply.Status);

            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime);
                Console.WriteLine(pingReply.Address);
            }
        }
    }
}