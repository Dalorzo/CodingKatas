using System.Collections.Generic;
using System.Threading;

namespace CodingKatas.Trees
{
    public class TreeDepth
    {
        private int maxDepth;
        
        public int MaxDepth(TreeNode root) {
          /*  ReadNode(root.left,1);
            ReadNode(root.right,1);
            return this.maxDepth;*/
         /*  this.ReadNode(root);
           return this.maxDepth;*/
            return ReadNodeAgain(root);
        }

        public void ReadNode(TreeNode node, int depth)
        {
            this.maxDepth = this.maxDepth < depth ? depth : this.maxDepth;
            depth++;
            if (node.left != null)
            {
                ReadNode(node.left, depth);
            }

            if (node.right != null)
            {
                ReadNode(node.right, depth);
            }
        }
        
        public void ReadNode(TreeNode head)
        {
            var nodes = new Stack<TreeNode>();
            var depth = 1;
            var node = head;
            nodes.Push(head);
            while (node != null)
            {
                node = node.left; 
                if (node != null) {
                    nodes.Push(node);
                }
                else
                {
                    do
                    {
                        if (nodes.Count == 0)
                        {
                            break;
                        }
                        depth = nodes.Count > depth ? nodes.Count : depth;
                        node = nodes.Pop();
                        if (node.right != null)
                        {
                            nodes.Push(node.right);
                            node = node.right;
                        }
                    } while (node.right == null && node != head);
                }
                this.maxDepth = depth ;
            }

           
        }


        public int ReadNodeAgain(TreeNode head)
        {
            var visitedNodes = new Stack<TreeNode>();
            var depth = 1;
            visitedNodes.Push(head);
            var node = head;
            while (node != null)
            {
                node = node.left;
                if (node != null)
                {
                    visitedNodes.Push(node);
                    depth = depth > visitedNodes.Count ? depth : visitedNodes.Count;
                }
                else
                {
                    if (visitedNodes.Count == 0)
                    {
                        break;
                    }
                    node = visitedNodes.Pop();
                    do
                    {
                        if (node.right != null)
                        {
                            node = node.right;
                            visitedNodes.Push(node);  
                            depth = depth > visitedNodes.Count ? depth : visitedNodes.Count;
                        }
                    } while (node == null && node != head);
                }
            }

            return depth;
        }

    }
}