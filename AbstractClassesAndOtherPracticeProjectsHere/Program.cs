namespace AbstractClassesAndOtherPracticeProjectsHere
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int FirstProgramInt;
            // we can not create object for abstract classes.
            var F1 = new MultiplicationClassFirst();
            F1.firstClassPublicObject = 12;
            var F1Sum = F1.Add(1, 2);
            var F1Mul = F1.Mul(1, 2);
            var F1Sub = F1.Sub(1, 2);

            var F2 = new MultiplicationClassSecond();
            F2.firstClassPublicObject = 15;
            var F2Sum = F2.Add(1, 2);
            var F2Mul = F2.Mul(1, 2);
            var F2Sub = F2.Sub(1, 2);

            var F3 = new MultiplicationClassThird();
            F3.firstClassPublicObject = 15;
            var F3Sum = F3.Add(1, 2);
            var F3Mul = F3.Mul(1, 2);
            var F3Sub = F3.Sub(1, 2);
        }
    }
}