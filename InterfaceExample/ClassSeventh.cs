namespace InterfaceExample
{
    internal class ClassSeventh
    {
        public int studentCount = 80;
        public int teacherCount = 4;

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