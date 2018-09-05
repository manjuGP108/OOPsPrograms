using System;
using AbstractClassesAndOtherPracticeProjectsHere;

namespace InheritanceSample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // We have same methods same method definition in parent classes and child classes. Since we have created
            // the object of child class so methods of child class will be called and not the methods of the parent class.
            var T3 = new ThirdClass();
            var T3Sum = T3.Add(1, 2);
            var T3Sub = T3.Sub(2, 1);
            var T3Mul = T3.Mul(1, 2);

            FirstClass T1 = new ThirdClass();
            // Even though we have instantiated a ThirdClass to object of First class by variable T1
            //we can only access the methods of First class, Inorder to access the methods of ThirdClass
            // we should declare as vertual in parent class(FirstClass) and override in ThirdClass(Dynamic Polymorphism)
            // we should declare as vertual in parent class(FirstClass) and override in ThirdClass(Dynamic Polymorphism)
            Console.WriteLine(T1);
            var T31Sum = T1.Add(1, 2);
            var T31Sub = T1.Sub(2, 1);
            var T31Mul = T1.Mul(1, 2);
            var T31Add = T1.AddExtraInFirstClass(1, 2);

            var F1 = new MultiplicationClassFirst();
            F1.firstClassPublicObject = 10;
        }
    }
}