using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    //Adapter class
    public class LogAdapter : ILogger
    {
        private readonly ILoggerNetMaster _logNetMaster;
        public LogAdapter(ILoggerNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }
        public void Log(string message)
        {
            _logNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}
