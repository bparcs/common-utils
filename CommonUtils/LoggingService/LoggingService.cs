using CommonUtils.LoggingService.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtils.LoggingService
{
    public class LoggingService : ILoggingService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggingService()
        {

        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Information(string message)
        {
            logger.Info(message);
        }

        public void Warning(string message)
        {
            logger.Warn(message);
        }
    }
}
