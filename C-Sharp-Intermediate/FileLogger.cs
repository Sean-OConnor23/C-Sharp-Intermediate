using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            //If not run by Common Language Runtime (CLR) we need to dispose 
            //DRY = Don't Repeat Yourself
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(messageType + ":" + message);
                streamWriter.Dispose();
            }
        }
    }
}
