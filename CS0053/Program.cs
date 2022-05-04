using System;

namespace CS0053
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            using var stream = await response.Content.ReadAsStreamAsync();

            string fileName = "2.png";

            using var fileStream = new FileStream(path: fileName, mode: FileMode.OpenOrCreate);

            int SIZEBUFFER = 500;
            byte[] buffer = new byte[SIZEBUFFER];
            bool endFalse = false;

            do
            {
                int numberRead = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                if (numberRead == 0)
                {
                    endFalse = true;
                }
                else
                {
                    await fileStream.WriteAsync(buffer, 0, numberRead);
                }
            } while (!endFalse);
        }
    }
}