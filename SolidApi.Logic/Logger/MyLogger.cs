using SolidApi.Logic.Logger.Interfaces;
using System.Collections.Generic;

namespace SolidApi.Logic.Logger
{
    public class MyLogger<T> : IMyLogger
    {
        private readonly IEnumerable<IMyLogger> loggers;

        public MyLogger(IEnumerable<IMyLogger> loggers)
        {
            this.loggers = loggers;


            //bardzo zly i brzydki przyklad
            //var list = new List<IMyLogger>();
            //list.Add(new ConsoleLogger());
            //itd.
        }
        public void Log(string text)
        {
            foreach (var logger in loggers)
            {
                logger.Log($"{typeof(T)} : {text}");
            }
        }
    }
}
