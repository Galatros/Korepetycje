using SolidApi.Logic.TextAdministrator.Interfaces;
using System;
using System.Collections.Generic;

namespace SolidApi.Logic.TextAdministrator
{
    public class WordsSplitter : IWordsSplitter
    {
        public IEnumerable<string> SplitWordsInString(string text)
        {
            var delimiterChars = new[] { ' ', ',', '.', ':', '\t', '!', '?', '\r', '\n', '-', '/', '"', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\'', '\\', '(', ')', '„', '”' };
            var wordsInString = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in wordsInString)
            {
                //logika ze slowem
                yield return word;
            }
        }
    }
}
