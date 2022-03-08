using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnCSharp;

public class LearnAsync
{
    static async Task<int> GetPageLengthAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            Task<string> fetchTextTask = client.GetStringAsync(url);
            int length = (await fetchTextTask).Length;
            return length;
        }
    }

    public static void PrintPageLength()
    {
        Task<int> lengthTask = GetPageLengthAsync("http://csharpindepth.com");
        Console.WriteLine(lengthTask.Result);
    }
}