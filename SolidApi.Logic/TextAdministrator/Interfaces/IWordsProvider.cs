using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolidApi.Logic.TextAdministrator.Interfaces
{
    public interface IWordsProvider
    {
        Task<IEnumerable<string>> GetWordsAsync(string urlToWebPage);
    }
}
