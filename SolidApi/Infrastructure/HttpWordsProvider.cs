﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public class HttpWordsProvider : IWordsProvider
    {
        private readonly ITextProvider textProvider;
        private readonly IWordsSplitter wordsSplitter;

        public HttpWordsProvider(ITextProvider textProvider, IWordsSplitter wordsSplitter)
        {
            this.textProvider = textProvider;
            this.wordsSplitter = wordsSplitter;

        }

        public async Task<string[]> GetWordsAsync(string urltoWebPage)
        {
            var textFromWebPage = await textProvider.GetTextAsync(urltoWebPage).ConfigureAwait(false);
            var wordsInTextFromWebPage = wordsSplitter.SplitWordsInString(textFromWebPage);
            return wordsInTextFromWebPage;

        }



    }
}