using SolidApi.Interfaces;
using SolidApi.Repository.DataBaseFiles;

namespace SolidApi.Classes
{
    public class BookInfoProvider : IBookInfoProvider
    {
        public string GetBooksInfo(string name)
        {
            var listofbooks = new Books();
            var result = listofbooks.BooksDictionary[name];
            return result;
        }
    }
}
