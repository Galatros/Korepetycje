using SolidApi.Interfaces;

namespace SolidApi.Classes
{
    public interface IMyFactory
    {
        IArtAuthenticator CreateArtAuthenticator(string artType);
    }
}