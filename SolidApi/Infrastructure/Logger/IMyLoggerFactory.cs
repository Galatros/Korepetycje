namespace SolidApi.Infrastructure.Logger
{
    public interface IMyLoggerFactory
    {
        IMyLogger CreateMyLogger<T>();
    }
}