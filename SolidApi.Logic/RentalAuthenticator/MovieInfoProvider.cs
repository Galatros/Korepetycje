using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Repository.Database;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class MovieInfoProvider : IMovieInfoProvider
    {
        private readonly IMovieRepository movieRepository;

        public MovieInfoProvider(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public string GetMoviesInfo(string name)
        {
            var movie = movieRepository.GetMovieForNameAsync(name).Result;
            var comapny = movie.Company.Name;
            return comapny;
        }
    }
}
