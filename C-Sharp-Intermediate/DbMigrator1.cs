using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Intermediate
{
    public class DbMigrator1
    {
        private readonly ILogger _logger;

        public DbMigrator1(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            var output = "Migration started at " + DateTime.Now;

            _logger.LogInfo("Temp");


      
        }
    }
}
