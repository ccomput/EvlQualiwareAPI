using System;
using log4net;
using log4net.Config;

namespace EvlQualiwareAPI.Helpers
{
    public enum LogType
    {
        Debug,
        Error,
        Warning,
        Info,
        Fatal
    }
    public static class Logger
    {
        static Logger()
        {
            XmlConfigurator.Configure();
        }

        public static void Log<T>(LogType logType, string message)
        {
            writeLog<T>(logType, message);
        }

        public static string Log<T>(LogType logType, Exception ex, string message = "")
        {
            message = message + readException(ex);
            writeLog<T>(logType, message);
            if (!string.IsNullOrEmpty(message))
            {
                return message;
            }
            return "Ocorreu um erro inesperado ao executar a operação";
        }

        private static void writeLog<T>(LogType logType, string message)
        {
            var logger = LogManager.GetLogger(typeof(T));

            switch (logType)
            {
                case LogType.Debug:
                    logger.Debug(message);
                    break;
                case LogType.Error:
                    logger.Error(message);
                    break;
                case LogType.Warning:
                    logger.Warn(message);
                    break;
                case LogType.Info:
                    logger.Info(message);
                    break;
                case LogType.Fatal:
                    logger.Fatal(message);
                    break;
            }
        }

        private static string readException(Exception ex)
        {
            var message = "\n" + ex.Message;

            if (ex.InnerException != null)
            {
                message += readException(ex.InnerException);
            }

            return message;
        }
    }
}