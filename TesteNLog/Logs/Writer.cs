using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNLog.Logs
{
    public class Writer
    {
        private IWriter writer;

        public Writer()
        {
            this.writer = new Adapters.NLogService();
        }

        public void WriteInFile(string message, string path = null)
        {
            this.writer.WriteInFile(message, path);
        }
    }
}
