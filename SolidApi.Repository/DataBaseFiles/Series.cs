using System.Collections.Generic;

namespace SolidApi.Repository.DataBaseFiles
{
    public class Series
    {
        private Dictionary<string, string> series;

        public Series()
        {
            series = new Dictionary<string, string>();
            series.Add("Pan Wołodyjowski", "Fitness");
            series.Add("Botoks", "PomiarMet");

        }
    }
}
