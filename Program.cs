using System;
//Robinjit kaur
namespace Isosceles_Triangle
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            if ((firstAngle + secondAngle + thirdAngle) != 180)
            {
                return "The triangle is NOT valid.";
            }

            if (firstAngle == secondAngle || firstAngle == thirdAngle || secondAngle == thirdAngle)
            {
                return "The triangle is valid and isosceles.";
            }

            return "The triangle is valid but not isosceles.";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int firstangle = 60;
            int secondangle = 60;
            int thirdangle = 60;

            string result = Triangle.ValidTriangle(firstangle, secondangle, thirdangle);
            Console.WriteLine(result);
        }
    }
}