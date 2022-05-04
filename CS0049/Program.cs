using System;
using System.Collections.Generic;

namespace CS0049
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var httpClient = new HttpClient();

            var httpMessageRequest = new HttpRequestMessage();

            httpMessageRequest.Method = HttpMethod.Post;
            httpMessageRequest.RequestUri = new Uri("https://postman-echo.com/post");
            httpMessageRequest.Headers.Add("User-Agent", "Mozilla/5.0");


            var parammeters = new List<KeyValuePair<string, string>>();
            parammeters.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            parammeters.Add(new KeyValuePair<string, string>("Key2", "Value2"));
            parammeters.Add(new KeyValuePair<string, string>("Key3", "Value3"));
            parammeters.Add(new KeyValuePair<string, string>("Key4", "Value4"));
            var content = new FormUrlEncodedContent(parammeters);

            httpMessageRequest.Content = content;

            var httpResponeMessage = await httpClient.SendAsync(httpMessageRequest);


            string getString = await httpResponeMessage.Content.ReadAsStringAsync();

            Console.WriteLine(getString);
        }
    }
}