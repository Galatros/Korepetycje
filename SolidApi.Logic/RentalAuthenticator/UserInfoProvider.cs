using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.Database;
using SolidApi.Repository.DataBaseFiles;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class UserInfoProvider : IUserInfoProvider
    {
        private readonly IUserRepository userRepository;

        public UserInfoProvider(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public string GetUserCompany(string name)
        {
            //var t1 = new Task(() => Task.Delay(500));
            //var t2 = new Task(() => Task.Delay(500));
            //var t3 = new Task(() => Task.Delay(500));

            //await Task.WhenAll(t1, t2, t3);

            //var concurent = new ConcurrentDictionary<string, int>();
            //concurent.tr

            var user = userRepository.GetUserForNameAsync(name).Result;
            var comapny = user.Company.Name;
            return comapny;
            //var users = new Users();
            //var result = users.UsersDictionary[name];
            //return result;
        }
    }
}
