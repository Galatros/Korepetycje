using Microsoft.AspNetCore.Mvc;
using SolidApi.Logic.Logger.Interfaces;
using SolidApi.Logic.TextAdministrator;
using System.Threading.Tasks;

namespace SolidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly TextCounter textCounter;
        private IMyLogger logger;
        private const string url = "https://wolnelektury.pl/media/book/txt/calineczka.txt";

        public TextController(TextCounter textCounter, IMyLoggerFactory loggerFactory)
        {
            this.textCounter = textCounter;
            this.logger = loggerFactory.CreateMyLogger<TextController>();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            logger.Log("Hello world!");
            var result = await textCounter.CountWordsInTextAsync(url);
            return Ok(result);
        }

        //[Route("api/bla")]
        //[HttpGet]
        //public async Task<Hashtable> Get(string word)
        //{
        //    string resultString = await textCounter.GetDataFromWebPage("https://wolnelektury.pl/media/book/txt/calineczka.txt");
        //    Hashtable result = textCounter.CountWordsInTextAsync(resultString);
        //    Hashtable res = new Hashtable();
        //    res.Add(word, result[word]);
        //    return res;

        //}
    }
}