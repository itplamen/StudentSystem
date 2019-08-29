namespace StudentSystem.Common.Loggers
{
    using System;
    using System.IO;

    using StudentSystem.Common.Contracts;

    public class LoggerFactory : ILoggerFactory
    {
        private const string LOGS_DIRECTORY = @"C:\Logs\";

        public ILogger Create(string file, string directory)
        {
            string dateTime = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string fullDirectoryPath = CreateDirectory($@"{directory}\{dateTime}");

            return new Logger(file, fullDirectoryPath);
        }

        private string CreateDirectory(string directory)
        {
            string fullDirectoryPath = $@"{LOGS_DIRECTORY}\{directory}";

            if (!Directory.Exists(fullDirectoryPath))
            {
                Directory.CreateDirectory(fullDirectoryPath);
            }

            return fullDirectoryPath;
        }
    }
}