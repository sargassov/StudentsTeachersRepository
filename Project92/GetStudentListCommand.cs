using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    class GetStudentListCommand : CommandInterface
    {
        private readonly ArrayList persons;

        public GetStudentListCommand(ArrayList persons)
        {
            this.persons = persons;
        }
        public bool CanRun(string userCommand)
        {
            return userCommand == "2";
        }

        public string GetHelp()
        {
            throw new NotImplementedException();
        }

        public string GetMenuRow()
        {
            return "2. Вывод списка студентов";
        }

        public string Run(string userCommand, ref bool isExit)
        {
            StringBuilder builder = new StringBuilder();
            foreach (AbstractPerson person in persons)
            {
                if (person is Student)
                {
                    builder.AppendLine($"{person.Name} {person.SecondName}");
                }
            }

            return builder.ToString();
        }
    }
}