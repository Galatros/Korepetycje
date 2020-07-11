using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class MovieInfoProvider : IMovieInfoProvider
    {
        private readonly IUserRepository userRepository;

        public MovieInfoProvider(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string GetMoviesInfo(string name)
        {
            var movie = userRepository.GetMovieForNameAsync(name).Result;
            var comapny = movie.Company.Name;
            return comapny;
        }
    }
}
