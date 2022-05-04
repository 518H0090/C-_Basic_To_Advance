using System;
using System.Collections.Generic;

namespace CS0054
{
    class Program
    {
        static async Task Main(string[] args)
        {

            using var httpClient = new HttpClient();
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri("https://postman-echo.com/post");

            // dùng FormUrlEncodedContent 
            // var parameters = new List<KeyValuePair<string, string>>();
            // parameters.Add(new KeyValuePair<string, string>("Key1", "Value1"));
            // parameters.Add(new KeyValuePair<string, string>("Key2", "Value2"));
            // parameters.Add(new KeyValuePair<string, string>("Key3", "Value3"));

            // var content = new FormUrlEncodedContent(parameters);

            // request.Content = content;

            // dùng StringContent
            // string jsonValue = @"
            //     ""Key1"" : ""Value1"",
            //     ""Key2"" : ""Value2""
            // ";

            // var content = new StringContent(jsonValue);
            // request.Content = content;

            // dùng MultipartFormDataContent
            var content = new MultipartFormDataContent();

            content.Add(new StringContent("Key1"), "Value1");
            Stream fileStream = File.OpenRead("Program.cs");
            content.Add(new StreamContent(fileStream), "fileupload", "abc.xyz");

            request.Content = content;

            var response = await httpClient.SendAsync(request);

            string html = await response.Content.ReadAsStringAsync();

            Console.WriteLine(html);
        }
    }
}