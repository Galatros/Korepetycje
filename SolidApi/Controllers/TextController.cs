using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidApi.Infrastructure;

namespace SolidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly TextCounter textCounter;

        public TextController(TextCounter textCounter)
        {
            this.textCounter = textCounter;
        }

        [HttpGet]
        public async Task<Hashtable> Get()
        {
            string resultString = await textCounter.GetDataFromWebPage("https://wolnelektury.pl/media/book/txt/calineczka.txt");
            Hashtable result=textCounter.CountWordsInString(resultString);
            return result;


        }
        [Route("api/bla")]
        [HttpGet]
        public async Task<Hashtable> Get(string word)
        {
            string resultString = await textCounter.GetDataFromWebPage("https://wolnelektury.pl/media/book/txt/calineczka.txt");
            Hashtable result = textCounter.CountWordsInString(resultString);
            Hashtable res = new Hashtable();
            res.Add(word, result[word]);
            return res;

        }
    }
}