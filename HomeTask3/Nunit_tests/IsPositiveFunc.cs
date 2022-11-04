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
    public class IsPositiveFunc
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

        [TestMethod]
        public void isPosTest()
        {
            var expected = true;
            var actual = calculatorFunc.isPositive(1);
            NUnit.Framework.Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void isPosStringTest()
        {
            var expected = true;
            var xnew = Convert.ToDouble("1");
            var actual = calculatorFunc.isPositive(xnew);
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
