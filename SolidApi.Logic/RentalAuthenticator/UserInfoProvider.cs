using SolidApi.Interfaces;
using SolidApi.Repository.DataBaseFiles;

namespace SolidApi.Classes
{
    public class UserInfoProvider : IUserInfoProvider
    {
        public string GetUserInfo(string name)
        {
            var users = new Users();
            var result = users.users[name];
            return result;
        }
    }
}
