using NUnit.Framework;
using StudentManagementApp;

namespace PrimeNumberTest
{
    public class PrimeNunitTest
    {
        private PrimeNumber p;

        [SetUp]
        public void Setup()
        {
            p = new PrimeNumber();
        }


        [Test]
        public void TestPrimeNumber()
        {
            Assert.AreEqual(true, p.IsPrime(2));
            Assert.AreEqual(true, p.IsPrime(5));
            Assert.AreEqual(true, p.IsPrime(17));
            Assert.AreEqual(true, p.IsPrime(23));
            Assert.AreEqual(true, p.IsPrime(29));
            Assert.AreEqual(true, p.IsPrime(89));
            Assert.AreEqual(true, p.IsPrime(83));

        }

        [Test]
        public void TestNonPrimeNumber()
        {
            Assert.AreEqual(false, p.IsPrime(1));
            Assert.AreEqual(false, p.IsPrime(4));
            Assert.AreEqual(false, p.IsPrime(18));

        }

        [Test]
        public void TestEdgeCases()
        {
            Assert.AreEqual(false, p.IsPrime(0));
            Assert.AreEqual(false, p.IsPrime(-5));
        }
    }
}