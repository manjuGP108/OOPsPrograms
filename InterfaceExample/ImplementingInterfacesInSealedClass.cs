namespace InterfaceExample
{
    internal sealed class ImplementingInterfacesInSealedClass : ICollege
    {
        public int studentCount = 90;
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
            return studentCount / teacherCount;
        }
    }
}