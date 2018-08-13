using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface ICollege
    {
        int NumberOfStudents();
        int NumberOfTeachers();
        int StudentTeacherRatio();
    }
}
