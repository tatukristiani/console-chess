using Serilog.Core;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    public static class FileLogger
    {
        private static Logger Logger = new LoggerConfiguration().WriteTo.File("C:\\Users\\Tatu\\Desktop\\Coding\\ConsoleChessLogs\\logs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

        public static void Log(string message)
        {
            Logger.Information($"\n{message}\n");
        }
    }


}
