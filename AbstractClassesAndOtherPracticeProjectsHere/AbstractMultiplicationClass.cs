namespace AbstractClassesAndOtherPracticeProjectsHere
{
    public abstract class AbstractMultiplicationClass
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        // For abstract methods implementation must be given in inherited classes
        // Abstract Methods must be under abstract classes
        public abstract int Mul(int number1, int number2);

    }
}