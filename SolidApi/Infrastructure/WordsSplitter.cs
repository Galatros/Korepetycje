using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public class WordsSplitter : IWordsSplitter
    {
        public string[] SplitWordsInString(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?', '\r', '\n', '-', '/', '"', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\'', '\\', '(', ')', '„', '”' };
            string[] wordsInString = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            return wordsInString;
        }
    }
}
