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
    public class AddFunc
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

        [TestCase(4, 8, 12)]
        [TestCase(5, 10, 15)]
        public void AddTest(double x, double y, double e)
        {
            double expected = e;
            double actual = calculatorFunc.Add(x, y);
            Assert.AreEqual(actual, expected);
        }

        [TestCase("1", "1", "2")]
        public void AddStringTest(string x, string y, string e)
        {
            double xnew = Convert.ToDouble(x);
            double ynew = Convert.ToDouble(y);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Add(xnew, ynew);
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
