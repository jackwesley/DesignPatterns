using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    public interface ILoggerNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
