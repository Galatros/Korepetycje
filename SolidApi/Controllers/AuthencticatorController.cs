using Microsoft.AspNetCore.Mvc;
using SolidApi.Infrastructure.Logger;
using SolidApi.Interfaces;
using System.Threading.Tasks;

namespace SolidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthencticatorController : ControllerBase
    {
        private readonly IUserAuthenticator userAuthenticator;
        private IMyLogger logger;

        public AuthencticatorController(IUserAuthenticator userAuthenticator, IMyLoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateMyLogger<TextController>();
            this.userAuthenticator = userAuthenticator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = userAuthenticator.AuthenticateUser("Jan Kowalski", "book", "Pan Wołodyjowski");
            if (result)
                return Ok();
            else
                return BadRequest();
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