using Serilog.Core;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    /// <summary>
    /// Utility class for loggin steps to file
    /// </summary>
    public static class FileLogger
    {
        private static readonly string LogDir = GetLogsFolder();
        private static Logger Logger = new LoggerConfiguration().WriteTo.File(Path.Combine(LogDir, "logs.txt"), rollingInterval: RollingInterval.Day).CreateLogger();

        /// <summary>
        /// Method which will log the param message to file.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Log(string message)
        {
            Logger.Information($"\n{message}\n");
        }

        /// <summary>
        /// Used to return the Logs folder inside the project
        /// </summary>
        /// <returns></returns>
        public static string GetLogsFolder()
        {
            return Path.Combine(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName).Parent.FullName, "Logs");
        }
    }


}
