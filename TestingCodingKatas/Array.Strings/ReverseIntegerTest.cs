using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas
{
    public class ReverseIntegerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingSimpleNumber()
        {
            var reverse = new ReverseInteger();
            Assert.AreEqual(321, reverse.Reverse(123),"Testing 123");
        }
        
        [Test(Description="Negative Number")]
        public void TestingNegativesNumber()
        {
            var reverse = new ReverseInteger();
            Assert.AreEqual(-321, reverse.Reverse(-123),"Testing 123");
        }
        
        [Test]
        public void TestingMaxNumber()
        {
            var reverse = new ReverseInteger();
            Assert.AreEqual( 0, reverse.Reverse(-2147483648),"Testing int.MaxValue");
        }

    }
}