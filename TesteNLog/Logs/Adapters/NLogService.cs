using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNLog.Logs.Adapters
{
    class NLogService : IWriter
    {
        public void WriteInFile(string message, string path = null)
        {
          
            NLog.Logger Logger = NLog.LogManager.GetLogger("logfile");
            Logger.Error("GetStudent: " + message);
        }
    }
}
