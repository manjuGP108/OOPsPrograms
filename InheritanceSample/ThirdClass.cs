namespace InheritanceSample
{
    internal class ThirdClass : SecondClass
    {
        public int Add(int number1, int number2)
        {
            return (number1 + number2) * 3;
        }

        public int AddExtra(int number1, int number2)
        {
            return (number1 + number2) * 10;
        }

        public override int AddExtraInFirstClass(int number1, int number2)
        {
            return (number1 + number2) * 30;
        }
    }
}