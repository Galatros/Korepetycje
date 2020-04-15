using System;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    class FileTextProvider : ITextProvider
    {
        // jakas inna implementacja interfejsu - na przyklad z pliku na dysku
        public Task<string> GetTextAsync(string urlToWebPage)
        {
            throw new System.NotImplementedException();
        }
    }

    public class HttpTextProvider : ITextProvider
    {
        private readonly IHttpClientWrapper httpClient;
        private readonly IWordsSplitter wordsSplitter;

        public HttpTextProvider(IHttpClientWrapper httpClient, IWordsSplitter wordsSplitter)
        {
            this.httpClient = httpClient;
            this.wordsSplitter = wordsSplitter;
        }

        public async Task<string> GetTextAsync(string urlToWebPage)
        {
            var response = await httpClient.GetAsync(urlToWebPage).ConfigureAwait(false);
            return wordsSplitter.SplitWords(text);
        }
    }
}

