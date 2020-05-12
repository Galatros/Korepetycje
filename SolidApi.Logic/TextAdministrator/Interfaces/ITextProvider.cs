using System.Threading.Tasks;

namespace SolidApi.Logic.TextAdministrator.Interfaces
{
    public interface ITextProvider
    {
        Task<string> GetTextAsync(string urlToWebPage);
    }
}