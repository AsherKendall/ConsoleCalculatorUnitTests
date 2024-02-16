using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace ConsoleCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 3, 4)]
        [DataRow(100, 50, 150)]
        [DataRow(1.5, 2.2, 3.7)]
        public void AddTest(double x, double y, double expected)
        {
            var Calc = new Calculator(x, y);


            var result = Calc.Add();

            Assert.IsNotNull(Calc);
            Assert.AreEqual(expected, result);
            StringAssert.Contains(result.ToString(), expected.ToString());



            var result2 = Calculator.Add(x, y);
            Assert.IsNotNull(result2);
            Assert.AreEqual(expected, result2);
            StringAssert.Contains(result2.ToString(), expected.ToString());
        }

        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(1, 3, -2)]
        [DataRow(100, 50, 50)]
        public void SubtractTest(double x, double y, double expected)
        {
            var Calc = new Calculator(x, y);


            var result = Calc.Subtract();

            Assert.IsNotNull(Calc);
            Assert.AreEqual(expected, result);
            StringAssert.Contains(result.ToString(), expected.ToString());



            var result2 = Calculator.Subtract(x, y);
            Assert.IsNotNull(result2);
            Assert.AreEqual(expected, result2);
            StringAssert.Contains(result2.ToString(), expected.ToString());
        }


        [TestMethod()]
        public void MultiplyTest()
        {
            var Calc = new Calculator(2, 2);


            var result = Calc.Multiply();

            Assert.IsNotNull(Calc);
            Assert.AreEqual(4, result);
            StringAssert.Contains(result.ToString(), "4");



            var result2 = Calculator.Multiply(2, 2);
            Assert.IsNotNull(result2);
            Assert.AreEqual(4, result2);
            StringAssert.Contains(result2.ToString(), "4");
        }

        [TestMethod()]
        public void DivideTest()
        {
            var Calc = new Calculator(4, 2);


            var result = Calc.Divide();

            Assert.IsNotNull(Calc);
            Assert.AreEqual(2, result);
            StringAssert.Contains(result.ToString(), "2");



            var result2 = Calculator.Divide(4, 2);
            Assert.IsNotNull(result2);
            Assert.AreEqual(2, result2);
            StringAssert.Contains(result2.ToString(), "2");
        }

        [TestMethod()]
        public void DivideByZeroTests()
        {
            var Calc = new Calculator(1, 0);

            var result = Calc.Divide();

            Assert.IsNotNull(Calc);
            Assert.IsNull(result);

            var result2 = Calculator.Divide(1, 0);
            Assert.IsNull(result2);
        }

    }
}