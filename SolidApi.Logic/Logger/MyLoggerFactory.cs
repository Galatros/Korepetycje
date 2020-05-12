using SolidApi.Logic.Logger.Interfaces;
using System.Collections.Generic;

namespace SolidApi.Logic.Logger
{
    public class MyLoggerFactory : IMyLoggerFactory
    {
        private readonly IEnumerable<IMyLogger> myLoggers;

        public MyLoggerFactory(IEnumerable<IMyLogger> myLoggers)
        {
            this.myLoggers = myLoggers;
        }

        public IMyLogger CreateMyLogger<T>()
        {
            var myLogger = new MyLogger<T>(myLoggers);
            return myLogger;
        }
    }
}
