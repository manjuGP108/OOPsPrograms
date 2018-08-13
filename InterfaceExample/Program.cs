namespace InterfaceExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sixthClass = new ClassSixth();
            var numberOfStudents = sixthClass.NumberOfStudents();
            var numberOfTeachers = sixthClass.NumberOfTeachers();
            float ratio = sixthClass.StudentTeacherRatio();

            var seventhClass = new ClassSeventh();
            var numberOfStudentSseventh = seventhClass.NumberOfStudents();
            var numberOfTeachersSeventh = seventhClass.NumberOfTeachers();
            float ratioSeventh = seventhClass.StudentTeacherRatio();
        }
    }
}