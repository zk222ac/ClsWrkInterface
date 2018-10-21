using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInterface
{
    class PassControlIntoInterface
    {
        private ILog _log;

        // Dependency Injection - we simply imject the interface obj 
        public PassControlIntoInterface(ILog log)
        {
            _log = log;
        }

        public void CalculateLog()
        {
            Console.WriteLine(_log.Log());
        }
    }
}
