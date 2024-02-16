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
        }
    }
}