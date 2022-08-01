using CodingKatas.Trees;
using NUnit.Framework;

namespace TestingCodingKatas.Trees
{
    public class TreeDepthTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingDepth2()
        {
            var root = new TreeNode(2, new TreeNode(1),new TreeNode(3));
            var depth = new TreeDepth();
            var result =depth.MaxDepth(root);
            Assert.AreEqual(2 ,result, "Testing simple");
        }
        
        [Test]
        public void TestingDepth3()
        {
            var root = new TreeNode(2, 
                new TreeNode(1, 
                    new TreeNode(3)));
            var depth = new TreeDepth();
            var result =depth.MaxDepth(root);
            Assert.AreEqual(3 ,result, "Testing simple");
        }
        
        
        [Test]
        public void TestingDepthWhile()
        {
            var root = new TreeNode(0,
                new TreeNode(1, 
                    new TreeNode(3, 
                        new TreeNode(5), null),
                    new TreeNode(4,null, 
                        new TreeNode(6))),
                    new TreeNode(2,
                        new TreeNode(7), 
                        new TreeNode(8)));
            var depth = new TreeDepth();
            var result =depth.MaxDepth(root);
            Assert.AreEqual(4 ,result, "Testing simple");
        }
        
        
    }
}