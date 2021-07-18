using System;


namespace DesingPatterns.Adapter
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}
