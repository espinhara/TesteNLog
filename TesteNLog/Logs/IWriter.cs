using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNLog.Logs
{
    interface IWriter
    {
        void WriteInFile(string message, string path = null);

    }
}
