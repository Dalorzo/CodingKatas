using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class ReplacingCharactersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingSimpleReplace()
        {
            var ana = new ReplacingCharacters();
            Assert.AreEqual("S3h", ana.WordParser("Smooth"));
        }
        
        [Test]
        public void TestingInvalidReplace()
        {
            var ana = new ReplacingCharacters();
            Assert.AreEqual("Y1s", ana.WordParser("Yes"));
        }
        
        [Test]
        public void TestingPhraseReplace()
        {
            var ana = new ReplacingCharacters();
            Assert.AreEqual("C6y is t4g-up n1w t4s. I6n is d3g n1w t4s!", ana.WordParser("Creativity is thinking-up new things. Innovation is doing new things!"));
        }
    }
}