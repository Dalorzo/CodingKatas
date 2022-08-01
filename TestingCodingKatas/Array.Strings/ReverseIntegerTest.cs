using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas
{
    public class LexicographicOrderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingHelloLeetCode()
        {
            var lexi = new LexicographicOrder();
            Assert.AreEqual(true, lexi.IsAlienSorted(new string[]{"hello","leetcode"},"hlabcdefgijkmnopqrstuvwxyz"));
        }
        
        [Test]
        public void TestingWordWorldRow()
        {
            var lexi = new LexicographicOrder();
            Assert.AreEqual(false, lexi.IsAlienSorted(new string[]{"word","world","row"},"worldabcefghijkmnpqstuvxyz"));
        }
        
        [Test]
        public void TestingWordWordRow()
        {
            var lexi = new LexicographicOrder();
            Assert.AreEqual(true, lexi.IsAlienSorted(new string[]{"word","word","row"},"worldabcefghijkmnpqstuvxyz"));
        }
        
        [Test]
        public void TestingWordLength()
        {
            var lexi = new LexicographicOrder();
            Assert.AreEqual(false, lexi.IsAlienSorted(new string[]{"apple","app"},"abcdefghijklmnopqrstuvwxyz"));
        }
        
        [Test]
        public void TestingWordEqual()
        {
            var lexi = new LexicographicOrder();
            Assert.AreEqual(true, lexi.IsAlienSorted(new string[]{"apple","apple"},"abcdefghijklmnopqrstuvwxyz"));
        }
        
        [Test]
        public void TestingLongArray()
        {
            var lexi = new LexicographicOrder();
            Assert.AreEqual(false, lexi.IsAlienSorted(new string[]{"fxasxpc","dfbdrifhp","nwzgs","cmwqriv","ebulyfyve","miracx","sxckdwzv","dtijzluhts","wwbmnge","qmjwymmyox"}
                ,"zkgwaverfimqxbnctdplsjyohu"));
        }
    }
}