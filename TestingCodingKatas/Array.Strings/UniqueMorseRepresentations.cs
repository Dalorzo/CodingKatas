using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class UniqueMorseRepresentations
    {
        [Test]
        public void TestOneWord()
        {
            var morseTranslator = new TextToMorseCodeTranslator();
            var words = new string[]
                {"demo"};
            Assert.AreEqual(1, morseTranslator.UniqueMorseRepresentations(words)," 1 One", words );
        }
        
        [Test]
        public void TestTwoWord()
        {
            var morseTranslator = new TextToMorseCodeTranslator();
            var words = new string[]
                {"cab", "and"};
            Assert.AreEqual(2, morseTranslator.UniqueMorseRepresentations(words)," 2 Words", words );
        }
        
        [Test]
        public void TestFourWordsResult2()
        {
            var morseTranslator = new TextToMorseCodeTranslator();
            var words = new string[]
                {"gin","zen","gig","msg"};
            Assert.AreEqual(2, morseTranslator.UniqueMorseRepresentations(words)," 2 Words", words );
        }
    }
}