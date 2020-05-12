using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Movies
    {
        public IDictionary<string, string> MoviesDictionary = new Dictionary<string, string>
            {
                { "Ogniem i Mieczem", "Fitness" },
                { "Pan Wołodyjowski", "PomiarMet" }
            };
       
    }
}
