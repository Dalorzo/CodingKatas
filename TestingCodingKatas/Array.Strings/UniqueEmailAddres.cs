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
        public void TestUniqueEmailAddressSimpleOne()
        {
            var uniqueEmails = new UniqueEmailAddress();
            var emails = new string[]
            {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            Assert.AreEqual(2, uniqueEmails.NumUniqueEmails(emails)," 2 Equeal emails", emails );
        }
    }
}