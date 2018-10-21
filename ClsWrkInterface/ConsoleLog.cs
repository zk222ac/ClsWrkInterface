using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInterface
{
    class ConsoleLog : ILog
    {
        public string Log()
        {
            return "I want log my data in console file";
        }
    }
}
