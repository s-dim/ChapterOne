using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChapterOne.Tests
{
    [TestClass]
    public class FrankTests
    {
        [TestMethod]
        public void Multiplication_TwiceMultiplication_Equals()
        {
            Money five = Money.franc(5);            
            Assert.AreEqual(Money.franc(10), five.times(2));            
            Assert.AreEqual(Money.franc(15), five.times(3));
        }

        [TestMethod]
        public void Equals_Test_True()
        {
            Money first = Money.franc(5);
            Money second = Money.franc(5);
            Money third = Money.franc(6);            


            Assert.AreEqual(first, second);
            Assert.AreNotEqual(first, third);            
            Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));

        }
    }
}
