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
        public Hashtable CountWordsInString(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t','!','?','\r','\n','-','/','"','1','2','3','4','5','6','7','8','9','0','\'','\\','(',')','„','”'};
            Hashtable hashtableOfWordAsKeyAndNumberOfOccursOfTheWord = new Hashtable();
            string [] wordsInString =text.Split(delimiterChars);
            foreach(string word in wordsInString)
            {
                if (word != null && word!="")
                {
                    if (hashtableOfWordAsKeyAndNumberOfOccursOfTheWord.ContainsKey(word))
                    {
                        hashtableOfWordAsKeyAndNumberOfOccursOfTheWord[word] = (int)hashtableOfWordAsKeyAndNumberOfOccursOfTheWord[word] + 1;
                    }
                    else
                    {
                        hashtableOfWordAsKeyAndNumberOfOccursOfTheWord[word] = 1;
                    }
                }
            }

            return hashtableOfWordAsKeyAndNumberOfOccursOfTheWord;

        }

        public async Task<string> GetDataFromWebPage(string urlToWebPage)
        {
            using (HttpClient client = new HttpClient())
            {
                try {
                    HttpResponseMessage response = await client.GetAsync(urlToWebPage);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                } 
                catch (HttpRequestException e)
                {
                    Console.WriteLine("bład {0}",e.Message);
                    return "blad";
                }
            

            }
        }
    }
}
