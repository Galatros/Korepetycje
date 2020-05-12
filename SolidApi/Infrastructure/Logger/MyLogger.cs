using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure.Logger
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
