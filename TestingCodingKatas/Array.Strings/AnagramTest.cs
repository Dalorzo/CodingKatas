using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class AnagramTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingSimpleAnagram()
        {
            var ana = new Anagram();
            Assert.AreEqual(true, ana.IsAnagram("anagram","nagaram"));
        }
        [Test]
        public void TestingSimpleFalseAnagram()
        {
            var ana = new Anagram();
            Assert.AreEqual(false, ana.IsAnagram("rat","car"));
        }
        
        [Test]
        public void TestingDifferentLengths()
        {
            var ana = new Anagram();
            Assert.AreEqual(false, ana.IsAnagram("rat","rats"));
        }
        
        [Test]
        public void TestingTrapinAnagram()
        {
            var ana = new Anagram();
            Assert.AreEqual(true, ana.IsAnagram("aa","bb"));
        }
    }
}