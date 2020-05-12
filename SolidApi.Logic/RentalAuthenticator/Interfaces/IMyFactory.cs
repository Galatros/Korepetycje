namespace SolidApi.Logic.RentalAuthenticator.Interfaces
{
    public interface IMyFactory
    {
        IArtAuthenticator CreateArtAuthenticator(string artType);
    }
}