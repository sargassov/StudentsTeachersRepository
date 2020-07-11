using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    interface CommandInterface
    {
        string GetMenuRow();
        string GetHelp();
        bool CanRun(string userCommand);
        string Run(string userCommand, ref bool isExit);
    }
}