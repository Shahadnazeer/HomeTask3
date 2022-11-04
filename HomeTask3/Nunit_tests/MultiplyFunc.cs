using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeTask3.Nunit_tests
{

    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class MultiplyFunc
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

        [TestCase(2, 2, 4)]
        [TestCase(5, 5, 25)]
        [TestCase(10, 0, 0)]
        public void MultiplyTest(double x, double y, double e)
        {
            double expected = e;
            double actual = calculatorFunc.Multiply(x, y);
            NUnit.Framework.Assert.AreEqual(actual, expected);
        }

        [TestCase("2", "1", "2")]
        public void MultiplyStringTest(string x, string y, string e)
        {
            double xnew = Convert.ToDouble(x);
            double ynew = Convert.ToDouble(y);
            double enew = Convert.ToDouble(e);
            double actual = calculatorFunc.Multiply(xnew, ynew);
            double expected = enew;
            NUnit.Framework.Assert.AreEqual(actual, expected);
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
