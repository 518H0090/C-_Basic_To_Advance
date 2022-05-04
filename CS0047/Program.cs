using System;
using System.Net;
using System.Net.NetworkInformation;

namespace CS0047
{
    class Program
    {
        static void Main(string[] args)
        {
            // string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
            // var uri = new Uri(url);
            // var uritype = typeof(Uri);
            // uritype.GetProperties().ToList().ForEach(property =>
            // {
            //     Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
            // });
            // Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");


            // var hostName = Dns.GetHostName();
            // Console.WriteLine(hostName);

            var url = "https://xuanthulab.net";
            Uri uri = new Uri(url);
            Console.WriteLine(uri.Host);

            var ipHost = Dns.GetHostEntry(uri.Host);

            Console.WriteLine(ipHost.HostName);
            ipHost.AddressList.ToList().ForEach(
                ip => Console.WriteLine(ip)
            );

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