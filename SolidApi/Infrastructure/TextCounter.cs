using Microsoft.Extensions.DependencyInjection;
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
        private readonly ITextProvider wordsProvider;

        public TextCounter(ITextProvider textProvider)
        {
            this.wordsProvider = textProvider;
        }

        /*
         * zrobic words provider ktory zwroci podzielona slowa
         * wyodrebnic dzielenie slow do innego interfejsu i napisac tescik -> IWordsSpliter ITextPr
         * napisac test do wordsProvidera
         */

        public async Task<IDictionary<string, int>> CountWordsInTextAsync(string url)
        {
            var text = await wordsProvider.GetTextAsync(url).ConfigureAwait(false);

            char[] delimiterChars = { ' ', ',', '.', ':', '\t','!','?','\r','\n','-','/','"','1','2','3','4','5','6','7','8','9','0','\'','\\','(',')','„','”'};
            var dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord = new Dictionary<string, int>();
            string [] wordsInString =text.Split(delimiterChars);
            foreach(var word in wordsInString)
            {
                if (word != null && word!="")
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
            }

            return dictionaryOfWordAsKeyAndNumberOfOccursOfTheWord;

        }

        
    }
}
