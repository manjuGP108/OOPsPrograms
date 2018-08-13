using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndOtherPracticeProjectsHere
{
    class MultiplicationClassSecond : MultiplicationClassFirst
    {
        public override int Mul(int number1, int number2)
        {
            firstClassPublicObject = 10;
            firstClassProtectedObject = 12;
            firstClassInternalObject = 15;
            firstClassProtectedInternalObject = 13;
            return 2 * (number1 * number2);
        }

        public new int Sub(int number1, int number2)
        {
            return 2 * (number1 - number2);
        }
    }
}
