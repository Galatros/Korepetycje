using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure.Logger
{
    public class FileLogger : IMyLogger
    {
        public void Log(string text)
        {
            Console.WriteLine("Hello FileLogger" + text);
        }
    }
}
