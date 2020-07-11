using SolidApi.Logic.RentalAuthenticator.Interfaces;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class BookAuthenticator : IArtAuthenticator
    {
        private readonly IUserInfoProvider userInfoProvider;
        private readonly IBookInfoProvider bookInfoProvider;

        public BookAuthenticator(IUserInfoProvider userInfoProvider, IBookInfoProvider bookInfoProvider)
        {
            this.bookInfoProvider = bookInfoProvider;
            this.userInfoProvider = userInfoProvider;
        }

        public string Type => "book";

        public bool Authenticate(string user, string name)
        {
            var bookInfo = bookInfoProvider.GetBooksInfo(name);
            var userInfo = userInfoProvider.GetUserCompany(user);
            if (!string.IsNullOrWhiteSpace(bookInfo) && !string.IsNullOrWhiteSpace(userInfo))
            {
                if (bookInfo.Contains(userInfo))
                    return true;

            }
            return false;

        }
    }
}
