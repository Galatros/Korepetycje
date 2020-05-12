using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Movies
    {
        private Dictionary<string, string> movies;

        public Movies()
        {
            movies = new Dictionary<string, string>();
            movies.Add("Ogniem i Mieczem", "Fitness");
            movies.Add("Pan Wołodyjowski", "PomiarMet");
        }
    }
}
