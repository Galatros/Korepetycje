using SolidApi.Logic.TextAdministrator.Interfaces;
using System;
using System.Threading.Tasks;

namespace SolidApi.Logic.TextAdministrator
{
    class FileTextProvider : ITextProvider
    {
        // jakas inna implementacja interfejsu - na przyklad z pliku na dysku
        public Task<string> GetTextAsync(string urlToWebPage)
        {
            throw new NotImplementedException();
        }
    }

    public class HttpTextProvider : ITextProvider
    {
        private readonly IHttpClientWrapper httpClient;
        //  private readonly IWordsSplitter wordsSplitter;

        public HttpTextProvider(IHttpClientWrapper httpClient)
        {
            this.httpClient = httpClient;
            //  this.wordsSplitter = wordsSplitter;
        }

        public async Task<string> GetTextAsync(string urlToWebPage)
        {
            var response = await httpClient.GetAsync(urlToWebPage).ConfigureAwait(false);
            //var result = wordsSplitter.SplitWordsInString(response);
            return response;
        }
    }
}

