using System;
using System.Net;
using System.Net.Http.Headers;

namespace CS0048
{
    class Program
    {

        static void ShowHeader(HttpResponseHeaders headers)
        {
            Console.WriteLine("cac header");
            foreach (var header in headers)
            {
                Console.WriteLine($"{header.Key} : {header.Value}");
            }
        }

        static async Task<string> GetWebContent(string url)
        {
            //  HttpClient
            using var httpClient = new HttpClient();
            try
            {
                // Add header
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
                // Respone
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                // Header
                ShowHeader(httpResponseMessage.Headers);
                string html = await httpResponseMessage.Content.ReadAsStringAsync();
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Có lỗi : {e.Message}");
                return "loi";
            }

        }

        static async Task<byte[]> DownLoadData(string url)
        {
            //  HttpClient
            using var httpClient = new HttpClient();
            try
            {
                // Add header
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
                // Respone
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                // Header
                ShowHeader(httpResponseMessage.Headers);
                byte[] html = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Có lỗi : {e.Message}");
                return null;
            }

        }

        static async Task DownloadStreams(string url, string fileName)
        {
            HttpClient httpClient = new HttpClient();
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                using var stream = await httpResponseMessage.Content.ReadAsStreamAsync();

                using var StreamWrite = File.OpenWrite(fileName);

                int SIZEBUFFER = 500;
                var buffer = new byte[SIZEBUFFER];



                bool endRead = false;

                do
                {
                    int numBytes = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                    if (numBytes == 0)
                    {
                        endRead = true;
                    }
                    else
                    {
                        await StreamWrite.WriteAsync(buffer, 0, numBytes);
                    }
                } while (!endRead);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Loi {e.Message}");
            }
        }


        static async Task Main(string[] args)
        {
            // var url = "https://xuanthulab.net/networking-su-dung-httpclient-trong-c-tao-cac-truy-van-http.html";
            // var task = await GetWebContent(url);

            // Console.WriteLine(task);

            // var url2 = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";
            // var bytes = await DownLoadData(url2);

            // string fileName = "1.png";
            // using var stream = new FileStream(path: fileName, mode: FileMode.Create, access: FileAccess.Write, share: FileShare.None);

            // stream.Write(bytes, 0, bytes.Length);

            await DownloadStreams("https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png", "2.png");


        }
    }
}