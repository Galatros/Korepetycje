namespace SolidApi.Interfaces
{
    public interface IArtAuthenticator
    {
        string Type { get; }
        bool Authenticate(string user, string name);
    }
}
