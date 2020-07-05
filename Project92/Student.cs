using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    public class Student : AbstractPerson
    {
        public string GroupName { get; set; }
        public Student(
            string groupName,
            string name,
            string second_name,
            DateTime BirthDate) : base()
        {
            GroupName = groupName;
            Name = name;
            SecondName = second_name;
        }
        
    }
}
