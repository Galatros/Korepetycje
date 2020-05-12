using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Books
    {
        public IDictionary<string, string> BooksDictionary = new Dictionary<string, string>
            {
                { "Ogniem i Mieczem", "PomiarMet" },
                { "Potop", "Fitness" },
                { "Pan Wołodyjowski", "ElektroMetal, Fitness" }
            };
    }
}
