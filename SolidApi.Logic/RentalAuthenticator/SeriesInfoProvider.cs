using SolidApi.Repository.Database;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class SeriesInfoProvider : ISeriesInfoProvider
    {
        private readonly ISeriesRepository seriesRepository;

        public SeriesInfoProvider(ISeriesRepository seriesRepository)
        {
            this.seriesRepository = seriesRepository;
        }

        public string GetSeriesInfo(string name)
        {
            var movie = seriesRepository.GetSeriesForNameAsync(name).Result;
            var comapny = movie.Company.Name;
            return comapny;
        }
    }
}
