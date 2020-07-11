using SolidApi.Logic.TextAdministrator.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SolidApi.Logic.TextAdministrator
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly IHttpClientFactory httpClientFactory;

        public HttpClientWrapper(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetAsync(string url)
        {
            // using (HttpClient client = new HttpClient()) //to jest dobre
            using (HttpClient client = httpClientFactory.CreateClient()) //a to jest lepsze w net core - optymalizacja procka
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("bład {0}", e.Message);
                    return "blad";
                }


            }
        }
    }
}
