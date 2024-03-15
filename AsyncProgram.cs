using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ncit_hari
{
    internal class AsyncProgram
    {
        public async Task<int> GetUrlContentLengthAsync(string url)
        {
            Console.WriteLine($"Connecting to {url} and fetching the contents..");
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(url);
            DoIndependentWork();
            string contents = await getStringTask;
            Console.WriteLine("Fetching completed !");
            return contents?.Length ?? 0; // Check if contents is not null before accessing its properties
        }

        void DoIndependentWork()
        {
            Console.WriteLine("Working..");
            Console.WriteLine("Completed.");
        }

        static async Task Main(string[] args)
        {
            AsyncProgram ap = new AsyncProgram();
            int result = await ap.GetUrlContentLengthAsync("https://cdcsit.edu.np/");
            Console.WriteLine("Length of the contents : {0}", result);
        }
    }
}
