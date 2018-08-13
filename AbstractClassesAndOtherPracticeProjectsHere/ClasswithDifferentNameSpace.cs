using AbstractClassesAndOtherPracticeProjectsHere;

namespace ClasswithDifferentNameSpaceExample
{
    internal class ClasswithDifferentNameSpace
    {
        public void ExampleMethod()
        {
            // Since this is a class with different name space so in order to create a object to a class which is present
            // in other name space we need to import that name space as above using AbstractClassesAndOtherPracticeProjectsHere;
            // If you are working with the same name space then this is not required.
            MultiplicationClassFirst F1 = new MultiplicationClassFirst();
            F1.Add(1, 2);
            F1.firstClassPublicObject = 10;
            F1.firstClassInternalObject = 12;
            F1.firstClassProtectedInternalObject = 16;
        }
    }
}