using SolidApi.Logic.Logger.Interfaces;
using System;

namespace SolidApi.Logic.Logger
{
    public class FileLogger : IMyLogger
    {
        public void Log(string text)
        {
            Console.WriteLine("Hello FileLogger" + text);
        }
    }
}
