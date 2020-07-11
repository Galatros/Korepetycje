using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.Database;
using SolidApi.Repository.DataBaseFiles;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class BookInfoProvider : IBookInfoProvider
    {
        private readonly IUserRepository userRepository;
        public BookInfoProvider(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string GetBooksInfo(string name)
        {
            //var listofbooks = new Books();
            //var result = listofbooks.BooksDictionary[name];
            //return result;
            var book = userRepository.GetBookForNameAsync(name).Result;
            var comapny = book.Company.Name;
            return comapny;
        }
    }
}
