using System;

namespace BasicPrograms
    // We can acess both static and non-static (methods and variables) inside a non-static block.
    // Since static block executes before the allocation of memory to objects so we will be unaware of
    // values of non static variables and methods. So we can access only static(methods and variables) inside a static block.
{
    internal class StaticAndNonStatic
    {
        public static int staticVariable_A;
        public static int staticVariable_B = 10;
        public static int staticVariable_C;
        public int non_Static_variable;

        private static void Main(string[] args)
        {
            var a = 1;
            var b = 20;
            Console.WriteLine(a);
            Console.WriteLine(staticVariable_A);
            Console.WriteLine(b);
            Console.WriteLine(staticVariable_B);
            Console.WriteLine(staticVariable_C);
            // cannot access non static variables in static block.
            // Console.WriteLine(non_Static_variable);

            var sum = Add(a, b);
            var sum1 = Add(a, b);
            // Cannot access non static methods inside a static block.
            // cananot access non-static variables and non-static methods inside a static block.
            // int sum3 = Add1(a, b);
            var staticObject = new StaticAndNonStatic();
            // We can not access the static members and static methods from objects of the class.
            // Static variables and methods are common to all the objects of the class so we can't using indivisual objects
            // We can directly access static variables and methods by ClassName with dot operator.
            var sum2 = staticObject.Add1(a, b);
        }

        public static int Add(int a, int b)
        {
            var sum = a + b;
            return sum;
        }

        public int Add1(int a, int b)
        {
            staticVariable_A = 10;
            staticVariable_B = 20;
            staticVariable_C = 30;
            non_Static_variable = 40;
            // Can access both static as well as non-static (variables and methods) in non-static block.
            var test = Add(a, b);
            var test1 = Add12(staticVariable_A, staticVariable_B, non_Static_variable);
            var sum = a + b;
            return sum;
        }

        public int Add12(int a, int b, int c)
        {
            var sum = a + b + c;
            return sum;
        }
    }

    public class SecondClass
    {
        public static int AddSecondClass(int a, int b)
        {
            var sum = a + b;
            return sum;
        }

        public int Add1SecondClass(int a, int b)
        {
            var sum = a + b;
            return sum;
        }
    }
}