using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    class ExitCommand : CommandInterface
    {
        public bool CanRun(string userCommand)
        {
            return
                userCommand == "0" ||
                userCommand.ToLower() == "выход" ||
                userCommand.ToLower() == "exit"
                ;
        }

        public string GetHelp()
        {
            return "Выход из программы";
        }

        public string GetMenuRow()
        {
            return "0. Выход";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            isExit = true;
            return "До новых встреч!";
        }
    }
}