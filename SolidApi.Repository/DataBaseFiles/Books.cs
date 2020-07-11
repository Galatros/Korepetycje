using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Books
    {
        //3 spoosby dodania danych do DB

       // 1. Dodajemy przez SQL Server Object Explorer - noob
       // 2. Dodajemy przez zapytania SQL w SMSS: insert into xxx () - intermediate
       // 3. W xxxRepository metoda Addxxx(xxx obj) - programista
        public IDictionary<string, string> BooksDictionary = new Dictionary<string, string>
            {
                { "Ogniem i Mieczem", "PomiarMet" },
                { "Potop", "Fitness" },
                { "Pan Wołodyjowski", "ElektroMetal, Fitness" }
            };
    }
}
