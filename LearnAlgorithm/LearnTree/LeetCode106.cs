using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode106
    {
        public LeetCode106()
        {
            BuildTree(new int[] {9, 3, 15, 20, 7},new int[] { 9, 15, 7, 20, 3 } );
        }

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
              this.val = val;
              this.left = left;
              this.right = right;
            }
        }

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return BuildTreeA(inorder, postorder,0,inorder.Length,0, postorder.Length );
        }

        private TreeNode BuildTreeA(int[] inorder, int[] postorder, int inorderBegin, int inorderEnd, int postorderStart, int postorderEnd)
        {
            if (postorderStart == postorderEnd) 
                return null;
            var ele = postorder[postorderEnd - 1];
            var midNode = new TreeNode(ele);

            int leftInorderStart = inorderBegin, leftInorderEnd = 0;
            int rightInorderStart = 0, rightInorderEnd = 0;
            int delimiterInorderIndex = 0;
            for (int i = inorderBegin; i < inorderEnd; i++)
            {
                if (inorder[i] == ele)
                {
                    delimiterInorderIndex = i;
                    leftInorderEnd = delimiterInorderIndex;
                    rightInorderStart = delimiterInorderIndex + 1;
                    rightInorderEnd = inorderEnd;
                }
            }

            int leftPostorderStart = postorderStart;
            int leftPostorderEnd = delimiterInorderIndex - leftInorderStart + postorderStart;

            int rightPostorderStart = postorderStart + delimiterInorderIndex - inorderBegin;
            int rightPostorderEnd = postorderEnd - 1;

            midNode.left = BuildTreeA(inorder, postorder, leftInorderStart, leftInorderEnd, leftPostorderStart, leftPostorderEnd);
            midNode.right = BuildTreeA(inorder, postorder, rightInorderStart, rightInorderEnd, rightPostorderStart, rightPostorderEnd);
            return midNode;
        }
    }
}
