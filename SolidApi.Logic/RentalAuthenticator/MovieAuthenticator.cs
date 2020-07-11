using SolidApi.Logic.RentalAuthenticator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class MovieAuthenticator : IArtAuthenticator
    {
        private readonly IUserInfoProvider userInfoProvider;
        private readonly IMovieInfoProvider movieInfoProvider;

        public MovieAuthenticator(IUserInfoProvider userInfoProvider, IMovieInfoProvider movieInfoProvider)
        {
            this.userInfoProvider = userInfoProvider;
            this.movieInfoProvider = movieInfoProvider;
        }

        public string Type => "movie";

        public bool Authenticate(string user, string name)
        {
            var movieInfo = movieInfoProvider.GetMoviesInfo(name);
            var userInfo = userInfoProvider.GetUserCompany(user);
            if (!string.IsNullOrWhiteSpace(movieInfo) && !string.IsNullOrWhiteSpace(userInfo))
            {
                if (movieInfo.Contains(userInfo))
                    return true;

            }
            return false;
        }
    }
}
