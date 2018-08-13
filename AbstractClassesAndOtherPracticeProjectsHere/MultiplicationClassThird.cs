namespace AbstractClassesAndOtherPracticeProjectsHere
{
    internal class MultiplicationClassThird : MultiplicationClassSecond
    {
        public override int Mul(int number1, int number2)
        {
            firstClassPublicObject = 10;
            firstClassProtectedObject = 12;
            firstClassProtectedObject2 = 20;
            return 3 * number2 * number1;
        }
    }
}