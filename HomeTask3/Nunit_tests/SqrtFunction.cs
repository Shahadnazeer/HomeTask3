using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator;


namespace HomeTask3.Nunit_tests
{

    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class SqrtFunction
    {

        public Calculator calculatorFunc;

        [OneTimeSetUp]
        public static void ClassInit()
        {
            Console.WriteLine("Preconditions for test class");
        }

        [SetUp]
        public void TestInit()
        {
            Console.WriteLine("Preconditions for test");
            calculatorFunc = new Calculator();
        }

        [TestCase(25, 5)]
        public void SqrtTest(double x, double e)
        {
            double expected = e;
            double actual = calculatorFunc.Sqrt(x);
            Assert.AreEqual(actual, expected);
        }

        [TestCase("25", "5")]
        public void SqrtStringTest(string x, string e)
        {
            double xnew = Convert.ToDouble(x);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Sqrt(xnew);
            double expected = enew;
            Assert.AreEqual(actual, expected);
        }

        [TearDown]
        public static void TestClean()
        {
            Console.WriteLine("Post conditions for test");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Console.WriteLine("Post conditions for test class");
        }
    }

}
