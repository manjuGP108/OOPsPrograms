namespace AbstractClassesAndOtherPracticeProjectsHere
{
    public class MultiplicationClassFirst : AbstractMultiplicationClass
    {
        // Internal is accessible through out this project(assembly) AbstractClassesAndOtherPracticeProjectsHere in all the classes
        // but it is not accessible in the other(assembly) project InheritanceSample project of same solution
        internal int firstClassInternalObject = 12;

        protected internal int firstClassProtectedInternalObject = 12;

        // Private accessible only in this class file. 
        private int firstClassPrivateObject = 10;

        // accessible in this class as well as its derived classes.
        protected int firstClassProtectedObject = 10;

        protected int firstClassProtectedObject2 = 10;

        // public accessible anywhere in the solution. Create a object to this class and 
        //access this public variable and also available in its derived class
        public int firstClassPublicObject = 10;

        // For abstract methods implementation must be given in inherited classes 
        public override int Mul(int number1, int number2)
        {
            firstClassProtectedObject = 12;
            return 2 * number1 * number2;
        }

        public new int Add(int number1, int number2)
        {
            return 2 * (number1 + number2);
        }
    }
}