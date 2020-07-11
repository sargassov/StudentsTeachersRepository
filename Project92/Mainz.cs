using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



namespace Project92
{
    
    class Mainz
    {
        static void Main(string[] args)
        {
            StudentRepository studentrepository =
                new StudentRepository();
            Console.WriteLine("Students are:" + "\n");
            for(short x = 0; x < studentrepository.getLength(); x++)
            {
                Console.WriteLine((x + 1) + ". " +
                    studentrepository.findAll()[x].GroupName +
                    " " + studentrepository.findAll()[x].Name +
                    " " + studentrepository.findAll()[x].SecondName);
            }
            TeacherRepository teacherrepository =
                new TeacherRepository();
            Console.WriteLine("Teachers are:" + "\n");
            for (short x = 0; x < studentrepository.getLength(); x++)
            {
                Console.WriteLine((x + 1) + ". " +
                    teacherrepository.findAll()[x].Name +
                    " " + teacherrepository.findAll()[x].SecondName + 
                    " have " + teacherrepository.findAll()[x].WorkExperience + 
                    " years of work experience.");
            }

            ArrayList persons = new ArrayList();

               persons.Add(
                   new Student("gr1", "Ivan", "Ivanov", DateTime.Now)
                );
                persons.Add(
                    new Teacher(12, "Semen", "Semenov", DateTime.Now)
                );

            ArrayList commands = new ArrayList();
            commands.Add(new ExitCommand());
            commands.Add(new GetTeacherListCommand(persons));
            commands.Add(new GetStudentListCommand(persons));

            /**
             * 1. Классы для студентов и преподавателей
             * 2. Репозитории для хранения списков
             * 3. Программа которая выполняет 3 действия:
             *  - вывод меню
             *  - вывод списка преподавателей
             *  - вывод списка студентов
             *  - выход
             * 4. Паттерн команда
             * 
             * */

            // AbstractPerson
            // Student
            //  - group
            // Teacher
            //  - classroom
            bool isExit = false;
            string userCommand;
            do
            {
                WriteLine("");
                WriteLine("Меню:");
                foreach (CommandInterface command in commands)
                {
                    WriteLine(command.GetMenuRow());
                }

                userCommand = ReadLine();

                foreach (CommandInterface command in commands)
                {
                    if (command.CanRun(userCommand))
                    {
                        WriteLine(command.Run(userCommand, ref isExit));
                    }
                }

            } while (!isExit);
        }
    }
}
