using System.Security.Cryptography;

namespace InheritanceSample
{
    internal class FirstClass
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Sub(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Mul(int number1, int number2)
        {
            return number1 * number2;
        }

        public virtual int AddExtraInFirstClass(int number1, int number2)
        {
            return (number1 + number2) * 10;
        }
        SecondClass s1 = new SecondClass();

        public SecondClass S1
        {
            get { return s1; }
            set { s1 = value; }
        }
        
    }
}