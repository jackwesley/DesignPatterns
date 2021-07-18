using System;

namespace DesingPatterns.Adapter
{
    //Adaptee class
    public class LogNetMasterService : ILoggerNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"Log Customizado - {message}");
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine($"Log Customizado - {exception.Message}");
        }
    }
}
