using System.Threading;

namespace TestingCodingKatas.Trees
{
    public class TreeDepth
    {
        private int maxDepth;
        
        public int MaxDepth(TreeNode root) {
            ReadNode(root.left,1);
            ReadNode(root.right,1);
            return this.maxDepth;
        }

        public void ReadNode(TreeNode node, int depth)
        {
            this.maxDepth = this.maxDepth < depth ? depth : this.maxDepth;
            if (node.left != null)
            {
                ReadNode(node.left, depth++);
            }

            if (node.right != null)
            {
                ReadNode(node.right, depth++);
            }
        }
        
        public void ReadNode(TreeNode head)
        {
            var rNode = head.right;
            var lNode = head.left;

            while (rNode != null || lNode != null)
            {
                this.maxDepth++;
                if (rNode != null)
                {
                    rNode = rNode.right;
                }

                if (lNode != null)
                {
                    lNode = lNode.left;
                }
            }
        }

    }
}