using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://www.pja.edu.pl");

            //Console.WriteLine(response);

            if (response.IsSuccessStatusCode) {
                string html = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(html);

                foreach (var m in matches) {
                    Console.WriteLine(m.ToString());
                }

            }

            
        }
    }
}
