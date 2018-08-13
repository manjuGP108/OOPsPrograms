using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class FourthClass
    {
        public int Factrorial(int number1)
        {
            int fact = 1;
            if (number1 >= 1)
            {
                return fact = number1 * Factrorial(number1 - 1);
            }
            return fact;
        }
    }
}
