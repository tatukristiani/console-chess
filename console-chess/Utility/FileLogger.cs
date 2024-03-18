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
        private static readonly string DirectoryLaptop = "C:\\Users\\tatuk\\OneDrive\\Desktop\\CodingDir\\";
        private static readonly string DirectoryPC = "C:\\Users\\Tatu\\Desktop\\Coding\\ConsoleChessLogs\\";
        private static Logger Logger = new LoggerConfiguration().WriteTo.File($"{DirectoryLaptop}logs.txt", rollingInterval: RollingInterval.Day).CreateLogger();

        public static void Log(string message)
        {
            Logger.Information($"\n{message}\n");
        }
    }


}
