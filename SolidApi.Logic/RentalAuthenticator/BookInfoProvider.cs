using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.DataBaseFiles;

namespace SolidApi.Logic.RentalAuthenticator
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
