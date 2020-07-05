using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    class TeacherRepository
    {
        private Teacher[] teachers =
       {
            new Teacher(12, "Phill", "Soprano", DateTime.Now),
            new Teacher(10, "Al", "Capone", DateTime.Now)};

        public Teacher[] findAll()
        {
            return teachers;
        }

        public int getLength()
        {
            return teachers.Length;
        }
    }
}
