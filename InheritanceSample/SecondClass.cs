namespace InheritanceSample
{
    internal class SecondClass : FirstClass
    {
        private int SecondClassInt1;
        public int SecondClassInt2;

        public int Add(int number1, int number2)
        {
            return (number1 + number2) * 2;
        }

        public int Sub(int number1, int number2)
        {
            return (number1 - number2) * 2;
        }

        public override int AddExtraInFirstClass(int number1, int number2)
        {
            return (number1 + number2) * 20;
        }
    }
}