using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInterface
{
    interface ILog
    {
        // interface always in public mode
        // interface define the contract - only method declaration  
        // but not real implementation
        string Log();
    }
}
