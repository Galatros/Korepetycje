using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure
{
    public interface IWordsProvider
    {
       Task<IEnumerable<string>> GetWordsAsync(string urlToWebPage);
    }
}
