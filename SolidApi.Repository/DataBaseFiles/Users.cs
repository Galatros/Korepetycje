using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Users
    {
        public Dictionary<string, string> users;

        public Users()
        {
            users = new Dictionary<string, string>
            {
                { "Jan Kowalski", "PomiarMet" },
                { "Jan Banaś", "PomiarMet" },
                { "Sylwester Stalon", "Fitness" },
                { "Imię Naziwsko", "ElektroMetal" },
                { "Jakub Bednarek", "ElektroMetal" }
            };
        }
    }
}
