using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;

namespace ConsoleCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void AddTest()
        {
            var Calc = new Calculator(1, 1);


            var result = Calc.Add();

            Assert.IsNotNull(Calc);
            Assert.AreEqual(2, result);
            StringAssert.Contains(result.ToString(), "2");



            var result2 = Calculator.Add(1, 1);
            Assert.IsNotNull(result2);
            Assert.AreEqual(2, result2);
            StringAssert.Contains(result2.ToString(), "2");
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var Calc = new Calculator(1, 1);


            var result = Calc.Subtract();

            Assert.IsNotNull(Calc);
            Assert.AreEqual(0, result);
            StringAssert.Contains(result.ToString(), "0");



            var result2 = Calculator.Subtract(1, 1);
            Assert.IsNotNull(result2);
            Assert.AreEqual(0, result2);
            StringAssert.Contains(result2.ToString(), "0");
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
    }
}