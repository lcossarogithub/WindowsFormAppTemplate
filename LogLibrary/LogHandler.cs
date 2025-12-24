using NLog;

namespace LogLibrary
{
    public static class LogHandler
    {

        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Initialize()
        {

        }

        /*            
        The logger will use NLog's default log levels system. The system consists of the following 6 levels:

        Fatal — used for reporting about errors that are forcing shutdown of the application.
        Error — used for logging serious problems occurring during execution of the program.
        Warn  — used for reporting non-critical unusual behaviour.
        Info — used for informative messages highlighting the progress of the application for sysadmins and end users.
        Debug — used for debugging messages with extended information about application processing.
        Trace — the noisiest level, used for tracing the code 
         */

        public static void Trace(string message)
        {
            logger.Trace(message);
        }

        public static void Debug(string message)
        {
            logger.Debug(message);
        }

        public static void Info(string message)
        {
            logger.Info(message);
        }

        public static void Warn(string message)
        {
            logger.Warn(message);
        }

        public static void Error(string message)
        {
            logger.Error(message);
        }

        public static void Fatal(string message)
        {
            logger.Fatal(message);
        }
    }
}
