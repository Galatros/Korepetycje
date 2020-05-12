using SolidApi.Logic.RentalAuthenticator.Interfaces;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class UserAuthenticator : IUserAuthenticator
    {
        private readonly IMyFactory myFactory;
        public UserAuthenticator(IMyFactory myFactory)
        {
            this.myFactory = myFactory;
        }

        public bool AuthenticateUser(string user, string type, string name)
        {
            var artAuthenticator = myFactory.CreateArtAuthenticator(type);
            var result = artAuthenticator.Authenticate(user, name);
            return result;
        }
    }
}
