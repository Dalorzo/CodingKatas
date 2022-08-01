using System.Collections.Generic;
using CodingKatas.Array.Strings;
using NUnit.Framework;

namespace TestingCodingKatas.Array.Strings
{
    public class TransactionValidatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSimpleTransaction()
        {
            var transValidator = new TransactionValidator();
            var output = new List<string>(new string[] { "alice,50,1200,mtv" });
            Assert.AreEqual(output, transValidator.InvalidTransactions( new string[]{"alice,20,800,mtv","alice,50,1200,mtv"} ),"Invalid simple Alice", output  );
        }
        
        [Test]
        public void TestTwoEqualTransaction()
        {
            var transValidator = new TransactionValidator();
            var output = new List<string>(new string[] {"alice,20,800,mtv","alice,50,800,beijin" });
            Assert.AreEqual(output, transValidator.InvalidTransactions( new string[]{"alice,20,800,mtv", "alice,50,800,beijin"} ),"Invalid different cities Alice", output  );
        }
        
        [Test]
        public void TestLongValidTransactions()
        {
            var transValidator = new TransactionValidator();
            var output = new List<string>(new string[]{});
            Assert.AreEqual(output, transValidator.InvalidTransactions( new string[]{"alice,20,800,beijin", 
                "jane,10,800,mtv",
                "luisa,70,800,beijin", 
                "bod,50,800,mtv",
                "jon,20,800,mtv", 
                "peter,50,800,mtv"} ),"0 Invalid", output  );
        }
        
        [Test]
        public void TestAllInvalidTransactions()
        {
            var transValidator = new TransactionValidator();
            var output = new List<string>(new string[]{"alice,20,800,mtv","alice,51,100,frankfurt","alice,50,100,mtv"});
            Assert.AreEqual(output, transValidator.InvalidTransactions( new string[]{"alice,20,800,mtv","alice,50,100,mtv","alice,51,100,frankfurt"} ),"All Invalid", output  );
        }
        
        [Test]
        public void TestTwoEqualInvalidTransaction()
        {
            var transValidator = new TransactionValidator();
            var output = new List<string>(new string[] { "alice,50,1200,mtv","alice,50,1200,mtv" });
            Assert.AreEqual(output, transValidator.InvalidTransactions( new string[]{"alice,50,1200,mtv","alice,50,1200,mtv"} ),"Invalid two equal Alice transactions", output  );
        }

    }
}