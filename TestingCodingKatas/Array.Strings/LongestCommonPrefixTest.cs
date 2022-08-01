using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class LongestCommonPrefixTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingNoPrefix()
        {
            var ana = new LongestPrefix();
            Assert.AreEqual("", ana.LongestCommonPrefix(new string[]{"dog","racecar","car"}));
        }
        
        [Test]
        public void TestingNoPrefix2()
        {
            var ana = new LongestPrefix();
            Assert.AreEqual("", ana.LongestCommonPrefix(new string[]{"c","acc","ccc"}));
        }
        
        [Test]
        public void TestingTwoLetterPrefix()
        {
            var ana = new LongestPrefix();
            Assert.AreEqual("fl", ana.LongestCommonPrefix(new string[]{"flower","flow","flight"}));
        }
        
        [Test]
        public void TestingTreeLetterPrefix()
        {
            var ana = new LongestPrefix();
            Assert.AreEqual("Car", ana.LongestCommonPrefix(new string[]{"Cardio","Carro","Carga"}));
        }
        
        [Test]
        public void TestingOutOfRange()
        {
            var ana = new LongestPrefix();
            Assert.AreEqual("Car", ana.LongestCommonPrefix(new string[]{"Cardio","Car","Cardumen"}));
        }
        
        [Test]
        public void TestingOutOfRange2()
        {
            var ana = new LongestPrefix();
            Assert.AreEqual("Car", ana.LongestCommonPrefix(new string[]{"Car","Cardio","Cardumen"}));
        }
    }
}