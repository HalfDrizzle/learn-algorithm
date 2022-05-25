using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnTree
{
    public class LeetCode144
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public LeetCode144()
        {

        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Traversal(root, result);
            return result;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            //while (stack.Count)
            //{
            //    var pop = stack.Pop();
            //    result.Add(pop.val);


            //    if (pop.right == null) { stack.Push(pop.right); }
            //    if (pop.left == null) { stack.Push(pop.left); }
            //}
            return result;
        }

        private void Traversal(TreeNode node, List<int> result)
        {
            if (node == null) return;
            result.Add(node.val);
            Traversal(node.left, result);
            Traversal(node.right, result);
        }

    }
}
