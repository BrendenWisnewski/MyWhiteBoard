using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewPrime;

namespace NewPrimesTest
{
    [TestClass]
    public class PrimesTests
    {
        [TestMethod]
        public void TestPrimes17()
        {
            Assert.AreEqual(true, Prime.IsPrime(17));
        }
        [TestMethod]
        public void TestPrimes8()
        {
            Assert.AreEqual(false, Prime.IsPrime(8));
        }
        [TestMethod]
        public void TestPrimes4()
        {
            Assert.AreEqual(false, Prime.IsPrime(4));
        }
        [TestMethod]
        public void TestPrimesSum6()
        {
            Assert.AreEqual(10, Prime.IsPrimeSum(6));
        }
        [TestMethod]
        public void TestPrimesSum8()
        {
            Assert.AreEqual(17, Prime.IsPrimeSum(8));
        }

    }
}
