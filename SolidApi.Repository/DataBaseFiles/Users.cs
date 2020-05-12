using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Users
    {
        public IDictionary<string, string> UsersDictionary = new Dictionary<string, string>
            {
                { "Jan Kowalski", "PomiarMet" },
                { "Jan Banaś", "PomiarMet" },
                { "Sylwester Stalon", "Fitness" },
                { "Imię Naziwsko", "ElektroMetal" },
                { "Jakub Bednarek", "ElektroMetal" }
            };

    }
}
