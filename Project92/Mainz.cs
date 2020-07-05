using System;
using System.Collections.Generic;
using System.Linq;
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
        }

    }

}
