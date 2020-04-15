using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public interface ITextProvider
    {
        Task<string> GetTextAsync(string urlToWebPage);
    }
}