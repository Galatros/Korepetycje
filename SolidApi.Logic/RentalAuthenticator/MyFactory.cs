using SolidApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolidApi.Classes
{
    public sealed class MyFactory : IMyFactory
    {//as
        private readonly IEnumerable<IArtAuthenticator> authenticators;

        public MyFactory(IEnumerable<IArtAuthenticator> authenticators)
        {
            this.authenticators = authenticators;
        }

        public IArtAuthenticator CreateArtAuthenticator(string artType)
        {
            var artAuthenticator = authenticators.FirstOrDefault(a => a.Type.ToUpperInvariant() == artType.ToUpperInvariant());
            if( artAuthenticator != null)
            return artAuthenticator;
            else
            {
                throw new NotImplementedException($"Nie ma zarjestrowanego autntykatora dla {artType}");
            }
        }
    }
}
