using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChapterOne.Tests
{
    [TestClass]
    public class DollarTests
    {
        [TestMethod]
        public void Multiplication_TwiceMultiplication_Equals()
        {
            Money five = Money.dollar (5);            
            Assert.AreEqual(Money.dollar(10), five.times(2));            
            Assert.AreEqual(Money.dollar(15), five.times(3));
        }

        [TestMethod]
        public void Equals_Test_True()
        {
            Money first = Money.dollar(5);
            Money second = Money.dollar(5);
            Money third = Money.dollar(6);

            Assert.AreEqual(first, second);
            Assert.AreNotEqual(first, third);

        }
    }
}
