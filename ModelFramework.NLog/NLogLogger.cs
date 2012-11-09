using System;

using ChessOk.ModelFramework.Logging;

using NLog;

namespace ModelFramework.NLog
{
    public class NLogLogger : ILogger
    {
        private readonly Logger _logger;

        public NLogLogger(Logger logger)
        {
            _logger = logger;
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string message, Exception exception)
        {
            _logger.DebugException(message, exception);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string message, Exception exception)
        {
            _logger.InfoException(message, exception);
        }

        public void Warning(string message)
        {
            _logger.Warn(message);
        }

        public void Warning(string message, Exception exception)
        {
            _logger.WarnException(message, exception);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, Exception exception)
        {
            _logger.ErrorException(message, exception);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string message, Exception exception)
        {
            _logger.FatalException(message, exception);
        }
    }
}
