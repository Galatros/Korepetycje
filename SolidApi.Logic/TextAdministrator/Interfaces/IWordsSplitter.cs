using System.Collections.Generic;

namespace SolidApi.Logic.TextAdministrator.Interfaces
{
    public interface IWordsSplitter
    {
        IEnumerable<string> SplitWordsInString(string text);
    }
}
