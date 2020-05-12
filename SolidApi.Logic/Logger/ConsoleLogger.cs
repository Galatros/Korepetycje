using SolidApi.Logic.Logger.Interfaces;
using System;

namespace SolidApi.Logic.Logger
{
    public class ConsoleLogger : IMyLogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
