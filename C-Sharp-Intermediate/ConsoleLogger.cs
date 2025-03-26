using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            var output = message;
        }

        public void LogInfo(string message)
        {
            var output = message;
        }
    }
}
