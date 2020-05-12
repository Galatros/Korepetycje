using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.DataBaseFiles;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class UserInfoProvider : IUserInfoProvider
    {
        public string GetUserInfo(string name)
        {
            var users = new Users();
            var result = users.UsersDictionary[name];
            return result;
        }
    }
}
