using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtils.LoggingService.Interfaces
{
    public interface ILoggingService
    {
        void Information(string message);
        void Debug(string message);
        void Warning(string message);
        void Error(string message);
    }
}
