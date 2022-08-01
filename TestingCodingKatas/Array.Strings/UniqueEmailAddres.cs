using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestUniqueEmailAddressOneDuplicate()
        {
            var uniqueEmails = new UniqueEmailAddress();
            var emails = new string[]
            {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            Assert.AreEqual(2, uniqueEmails.NumUniqueEmails(emails)," 1 Duplicate Result 2 emails", emails );
        }
        
        [Test]
        public void TestUniqueEmailAddressAllUnique()
        {
            var uniqueEmails = new UniqueEmailAddress();
            var emails = new string[]
                {"a@leetcode.com","b@leetcode.com","c@leetcode.com"};
            Assert.AreEqual(3, uniqueEmails.NumUniqueEmails(emails)," All unique, 3 emails", emails );
        }
    }
}