namespace SolidApi.Logic.Logger.Interfaces
{
    public interface IMyLoggerFactory
    {
        IMyLogger CreateMyLogger<T>();
    }
}