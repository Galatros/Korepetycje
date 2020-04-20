﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public class TextCounter//a
    {
        private readonly IWordsProvider wordsProvider;

        public TextCounter(IWordsProvider wordsProvider)
        {
            this.wordsProvider = wordsProvider;
        }

        /*
         * zrobic words provider ktory zwroci podzielona slowa
         * wyodrebnic dzielenie slow do innego interfejsu i napisac tescik -> IWordsSpliter ITextPr
         * napisac test do wordsProvidera
         */

        public async Task<IDictionary<string, int>> CountWordsInTextAsync(string url)
        {
            var wordsInString = await wordsProvider.GetWordsAsync(url).ConfigureAwait(false);
            var dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord = new Dictionary<string, int>();

            foreach (var word in wordsInString)
            {
                if (dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord.ContainsKey(word))
                {
                    dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord[word] = dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord[word] + 1;
                }
                else
                {
                    dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord[word] = 1;
                }
            }
            return dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord;

        }


    }
}
