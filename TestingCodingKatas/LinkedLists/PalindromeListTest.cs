using CodingKatas.LinkedLists;
using NUnit.Framework;

namespace TestingCodingKatas.LinkedLists
{
    public class PalindromeListTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingTruePalindromes01()
        {
            /*
            Input: l1 = [1,2,2,1]
            Output: true
            */
            var l1 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
            var pal = new Palindrome();
            var result = pal.IsPalindrome(l1);
            Assert.AreEqual(true ,result, "Testing simple");
        }
        
        [Test]
        public void TestingFalsePalindromes02()
        {
            /*
            Input: l1 = [1,2,3,1]
            Output: false
            */
            var l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(1))));
            var pal = new Palindrome();
            var result = pal.IsPalindrome(l1);
            Assert.AreEqual(false ,result, "Testing simple");
        }
    }
}