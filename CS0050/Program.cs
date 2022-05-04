using System;
using System.Collections.Generic;
using System.Net;

namespace CS0050
{
    public class MyHttpClientHandler : HttpClientHandler
    {
        public MyHttpClientHandler(CookieContainer cookie_container)
        {

            CookieContainer = cookie_container;     // Thay thế CookieContainer mặc định
            AllowAutoRedirect = false;                // không cho tự động Redirect
            AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            UseCookies = true;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                                     CancellationToken cancellationToken)
        {
            Console.WriteLine("Bất đầu kết nối " + request.RequestUri.ToString());
            // Thực hiện truy vấn đến Server
            var response = await base.SendAsync(request, cancellationToken);
            Console.WriteLine("Hoàn thành tải dữ liệu");
            return response;
        }
    }

    public class ChangeUri : DelegatingHandler
    {
        public ChangeUri(HttpMessageHandler innerHandler) : base(innerHandler) { }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                                                               CancellationToken cancellationToken)
        {
            var host = request.RequestUri.Host.ToLower();
            Console.WriteLine($"Check in  ChangeUri - {host}");
            if (host.Contains("google.com"))
            {
                // Đổi địa chỉ truy cập từ google.com sang github
                request.RequestUri = new Uri("https://github.com/");
            }
            // Chuyển truy vấn cho base (thi hành InnerHandler)
            return base.SendAsync(request, cancellationToken);
        }
    }

    class Program
    {

        static async Task Main(string[] args)
        {
            var url = "https://postman-echo.com/post";

            var Cookies = new CookieContainer();

            using var socketHttp = new SocketsHttpHandler();
            socketHttp.AllowAutoRedirect = true;
            socketHttp.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            socketHttp.UseCookies = true;
            socketHttp.CookieContainer = Cookies;


            using var httpClient = new HttpClient(socketHttp);

            var httpRequestMessage = new HttpRequestMessage();

            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri(url);
            httpRequestMessage.Headers.Add("User-Agent", "Mozilla/5.0");

            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            parameters.Add(new KeyValuePair<string, string>("Key2", "Value2"));
            parameters.Add(new KeyValuePair<string, string>("Key3", "Value3"));

            httpRequestMessage.Content = new FormUrlEncodedContent(parameters);

            var response = await httpClient.SendAsync(httpRequestMessage);

            Cookies.GetCookies(new Uri(url)).ToList().ForEach(
                c =>
                {
                    Console.WriteLine($"{c.Name} : {c.Value}");
                }
            );

            var html = await response.Content.ReadAsStringAsync();

            Console.WriteLine(html);
        }
    }
}