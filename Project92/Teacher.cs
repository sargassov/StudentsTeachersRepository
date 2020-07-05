using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    public class Teacher : AbstractPerson
    {
        public int WorkExperience { get; set; }
        public string Experience { get; set; }
        public Teacher(
            int workExperience,
            string name,
            string second_name,
            DateTime BirthDate) : base()
        {
            WorkExperience = workExperience;
            Name = name;
            SecondName = second_name;
        }

    }
}
