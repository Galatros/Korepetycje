namespace SolidApi.Logic.RentalAuthenticator.Interfaces
{
    public interface IUserAuthenticator
    {
        bool AuthenticateUser(string user, string type, string name);
    }
}
