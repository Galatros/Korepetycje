using System.Threading.Tasks;

namespace SolidApi.Logic.TextAdministrator.Interfaces
{
    public interface IHttpClientWrapper
    {
        Task<string> GetAsync(string url);
    }
}