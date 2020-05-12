namespace SolidApi.Interfaces
{
    public interface IUserAuthenticator
    {
        bool AuthenticateUser(string user, string type, string name);
    }
}
