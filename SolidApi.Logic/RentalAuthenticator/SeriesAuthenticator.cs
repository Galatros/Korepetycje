using SolidApi.Logic.RentalAuthenticator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidApi.Logic.RentalAuthenticator
{
    public class SeriesAuthenticator : IArtAuthenticator
    {
        private readonly IUserInfoProvider userInfoProvider;
        private readonly ISeriesInfoProvider seriesInfoProvider;

        public SeriesAuthenticator(IUserInfoProvider userInfoProvider, ISeriesInfoProvider seriesInfoProvider)
        {
            this.userInfoProvider = userInfoProvider;
            this.seriesInfoProvider = seriesInfoProvider;
        }

        public string Type => "series";

        public bool Authenticate(string user, string name)
        {
            var seriesInfo = seriesInfoProvider.GetSeriesInfo(name);
            var userInfo = userInfoProvider.GetUserCompany(user);
            if (!string.IsNullOrWhiteSpace(seriesInfo) && !string.IsNullOrWhiteSpace(userInfo))
            {
                if (seriesInfo.Contains(userInfo))
                    return true;

            }
            return false;
        }
    }
}
