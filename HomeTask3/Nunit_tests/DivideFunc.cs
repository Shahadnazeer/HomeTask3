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
    public class DivideFunc
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

        [TestCase(8, 4, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(10, 10, 1)]
        public void DivideTest(double x, double y, double e)
        {
            double expected = e;
            double actual = calculatorFunc.Divide(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase("2", "1", "2")]
        public void DivideStringTest(string x, string y, string e)
        {
            double xnew = Convert.ToDouble(x);
            double ynew = Convert.ToDouble(y);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Divide(xnew, ynew);
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
