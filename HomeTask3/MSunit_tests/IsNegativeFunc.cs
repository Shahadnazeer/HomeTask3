using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace HomeTask3.MSunit_tests
{

    [TestClass]
    public class IsNegativeFunc
    {
        public Calculator calculatorFunc;
        public TestContext TestContext { get; set; }
        [ClassInitialize]
        public static void ClassInit(TestContext x)
        {
            Console.WriteLine("Preconditions for test class");
        }

        [TestInitialize]
        public void TestInit()
        {
            Console.WriteLine("Preconditions for test");
            calculatorFunc = new Calculator();
        }

        [TestMethod]
        public void isNegTest()
        {
            var expected = true;
            var actual = calculatorFunc.isNegative(-1);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void isNegStringTest()
        {
            var expected = true;
            var xnew = Convert.ToDouble("-1");
            var actual = calculatorFunc.isNegative(xnew);      
            Assert.AreEqual(actual, expected);
        }

        [TestCleanup]
        public void TestClean()
        {
            Console.WriteLine("Post conditions for test");
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            Console.WriteLine("Post conditions for test class");
        }
    }

}
