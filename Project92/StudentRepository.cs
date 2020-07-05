using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project92
{
    class StudentRepository
    {
        
        private Student[] students =
        {
            new Student("Gr1", "Alex", "Rand", DateTime.Now),
            new Student("Gr1", "Mark", "Math", DateTime.Now)};

        public Student[] findAll()
        {
            return students;
        }

        public int getLength()
        {
            return students.Length;
        }

    }

}
