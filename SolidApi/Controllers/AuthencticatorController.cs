using Microsoft.AspNetCore.Mvc;
using SolidApi.Logic.Logger.Interfaces;
using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.Database;
using System.Threading.Tasks;

namespace SolidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthencticatorController : ControllerBase
    {
        private readonly IUserAuthenticator userAuthenticator;
        private readonly IUserRepository userRepository;
        private IMyLogger logger;

        public AuthencticatorController(IUserAuthenticator userAuthenticator, IMyLoggerFactory loggerFactory, IUserRepository userRepository)
        {
            this.logger = loggerFactory.CreateMyLogger<TextController>();
            this.userAuthenticator = userAuthenticator;
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //todo do testow na szybko
            var companies = await userRepository.GetUserCompaniesAsync(2).ConfigureAwait(false);

            var result = userAuthenticator.AuthenticateUser("Jan Kowalski", "series", "Botoks");
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