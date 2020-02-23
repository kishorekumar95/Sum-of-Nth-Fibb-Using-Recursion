using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci_Test
{
    [TestClass]
    public class FibonacciGenerator_Test
    {
        [TestMethod]
        public void TestMethod1()
        {//1,1,2,3,5,8,13,21,34
            int expected = 33;
            int input = 7;
            //Act
            int actual = Fibonacci.FibonacciGenerator.SumOfFibNumbers(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
