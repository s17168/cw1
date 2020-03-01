using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //args[0] = "https://www.amazon.com";
            Console.WriteLine("arg 0 = " + args[0]);

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);

            Console.WriteLine(response);
        }
    }
}
