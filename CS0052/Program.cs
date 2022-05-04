using System;
using System.Net.Http.Headers;

namespace CS0052
{
    class Program
    {
        static async Task<string> GetWebContent(string url)
        {
            using var httpClient = new HttpClient();
            try
            {
                httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
                var response = await httpClient.GetAsync(url);
                var htmlValue = await response.Content.ReadAsStringAsync();
                await ShowHeaders(response.Headers);

                return htmlValue;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi xay ra la : {e.Message}");
                return "Loi";
            }
        }

        public static async Task ShowHeaders(HttpHeaders headers)
        {
            Console.WriteLine("Cac header");
            foreach (var header in headers)
            {
                foreach (var value in header.Value)
                {
                    Console.WriteLine(value);
                }
            }
        }

        static async Task Main(string[] args)
        {
            string url1 = "https://xuanthulab.net/networking-su-dung-httpclient-trong-c-tao-cac-truy-van-http.html";
            await GetWebContent(url1);
        }
    }
}