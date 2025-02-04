using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Mutation_Testing
{
//Robinjit kaur
namespace Mutation_Testing
    {
        public class Triangle
        {
            public static string ValidTriangle(int a, int b, int c) =>
                (a + b > c && a + c > b && b + c > a)
                    ? (a == b || b == c || a == c ? "The triangle is valid and isosceles." : "The triangle is valid.")
                    : "The triangle is NOT valid.";
        }
    }

    namespace Mutation_Testing
    {
        [TestFixture]
        public class TriangleTests
        {
            [TestCase(70, 70, 40, "The triangle is valid and isosceles.")]
            [TestCase(10, 5, 3, "The triangle is NOT valid.")]
            public void Test_TriangleValidity(int a, int b, int c, string expected)
            {
                Assert.That(Triangle.ValidTriangle(a, b, c), Is.EqualTo(expected));
            }
        }
    }
}

