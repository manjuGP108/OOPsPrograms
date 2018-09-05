using System;

namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var variable_value = 10;
            const int simalarToFinalKeywordInJava = 100;
            var zeroValue = 0;
            try
            {
                var a = variable_value / zeroValue;
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                zeroValue = 100;
            }
        }
    }
}

// Note:
//You can write return statement in finally block.
// Sealed keywords can only be used for Classes and methods in derived classes.
//Methods cannot be “sealed” directly. Methods of only derived class can be made sealed with keyword sealed and override.