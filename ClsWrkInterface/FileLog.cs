using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInterface
{
    class FileLog : ILog
    {
        public string Log()
        {
            return "I want to log my data into FileLog";
        }
    }
}
