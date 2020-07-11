using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    class GetTeacherListCommand : CommandInterface
    {
        private readonly ArrayList persons;

        public GetTeacherListCommand(ArrayList persons)
        {
            this.persons = persons;
        }
        public bool CanRun(string userCommand)
        {
            return userCommand == "1";
        }

        public string GetHelp()
        {
            throw new NotImplementedException();
        }

        public string GetMenuRow()
        {
            return "1. Вывод списка преподавателей";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            StringBuilder builder = new StringBuilder();
            foreach (AbstractPerson person in persons)
            {
                if (person is Teacher)
                {
                    builder.AppendLine($"{person.Name} {person.SecondName}");
                }
            }

            return builder.ToString();
        }
    }
}