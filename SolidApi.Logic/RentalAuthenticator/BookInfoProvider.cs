using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.Database;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class BookInfoProvider : IBookInfoProvider
    {
        private readonly IBookRepository bookRepository;
        public BookInfoProvider(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public string GetBooksInfo(string name)
        {

            var book = bookRepository.GetBookForNameAsync(name).Result;
            var comapny = book.Company.Name;
            return comapny;
        }
    }
}
