using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public interface IHttpClientWrapper
    {
        Task<string> GetAsync(string url);
    }
}