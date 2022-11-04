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
    public class IsNegativeFunc
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

        [Test]
        public void isNegTest()
        {
            var expected = true;
            var actual = calculatorFunc.isNegative(-1);
            NUnit.Framework.Assert.AreEqual(actual, expected);
        }

        [Test]
        public void isNegStringTest()
        {
            var expected = true;
            var xnew = Convert.ToDouble("-1");
            var actual = calculatorFunc.isNegative(xnew);
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
