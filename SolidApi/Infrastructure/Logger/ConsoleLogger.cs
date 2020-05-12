using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidApi.Infrastructure.Logger
{
    public class ConsoleLogger : IMyLogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
