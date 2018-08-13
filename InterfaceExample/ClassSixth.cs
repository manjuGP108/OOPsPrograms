using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class ClassSixth: ICollege
    {
        public int studentCount = 60;
        public int teacherCount = 5;
        public int NumberOfStudents()
        {
            return studentCount;
        }

        public int NumberOfTeachers()
        {
            return teacherCount;
        }

        public int StudentTeacherRatio()
        {
            return (studentCount / teacherCount);
        }
    }
}
