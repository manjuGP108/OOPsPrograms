using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var validateRegex = new Regex(@"^\+91");
            var number = "+919480756256";
            var number2 = "9180756256";
            var check = validateRegex.IsMatch(number);
            var check_2 = validateRegex.IsMatch(number2);

            var validateRegex1 = new Regex(@"^\+\d{12}");
            var check1 = validateRegex1.IsMatch(number);

            var validateRegex2 = new Regex(@"^\+\d{13}");
            var check3 = validateRegex1.IsMatch(number);
        }
    }
}