using System.Collections.Generic;
using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class SubdomainVisitsTests
    {
      
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void Testdiscussleetcodecom()
            {
                var domain = new SubDomainVisitCount();
                var list = new List<string>(new string[]
                    { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" });
                Assert.AreEqual(list,  domain.SubdomainVisits(new string[] { "9001 discuss.leetcode.com" }), "9001 leetcode.com", "9001 discuss.leetcode.com");
            }
            
            [Test]
            public void TestSeveralDomains()
            {
                var domain = new SubDomainVisitCount();
                var list = new List<string>(new string[]
                    { "900 google.mail.com","901 mail.com","951 com","50 yahoo.com","1 intel.mail.com","5 wiki.org","5 org" });
                var input = new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
                Assert.AreEqual(list,  domain.SubdomainVisits(input) , "Testing several messages", input);
            }
    }
}