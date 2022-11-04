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
    public class SineFunc
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

        [TestCase(90, 0.89399666360055785)]

        public void SineTest(double x, double e)
        {
            double expected = e;
            double actual = calculatorFunc.Sin(x);
            Assert.AreEqual(actual, expected);
        }

        [TestCase("90", "0.89399666360055785")]
        public void SineStringTest(string x, string e)
        {
            double xnew = Convert.ToDouble(x);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Sin(xnew);
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
