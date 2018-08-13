using AbstractClassesAndOtherPracticeProjectsHere;

namespace InheritanceSample
{
    internal class ToCheckProtectedInternalConcept : MultiplicationClassFirst
    {
        public void ExampleMethod()
        {
            // Since this is a class with different name space so in order to create a object to a class which is present
            // in other name space we need to import that name space as above using AbstractClassesAndOtherPracticeProjectsHere;
            // If you are working with the same name space then this is not required.
            var F1 = new MultiplicationClassFirst();
            F1.firstClassPublicObject = 15;
            // Protected internal of another name space is not accesible here,F1.firstClassProtectedInternalObject = 16;
        }
    }
}