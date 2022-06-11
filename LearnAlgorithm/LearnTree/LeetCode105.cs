using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode105
    {
        public LeetCode105()
        {
            BuildTree(new int[] { 3, 9, 20, 15, 7}, new int[] {9, 3, 15, 20, 7 });
        }

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

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            //return BuildTreeA(inorder, postorder, 0, inorder.Length, 0, postorder.Length);
            return BuildTreeB(preorder, inorder, 0, preorder.Length, 0, inorder.Length);
        }

        public TreeNode BuildTreeB(int[] preorder, int[] inorder, int beginPreorder, int endPreorder, int beginInorder, int endInorder)
        {
            if (beginPreorder == endPreorder)
            {
                return null;
            }

            var midNode = new TreeNode(preorder[beginPreorder]);
            int delimiterInorderIndex = 0;
            for (int i = beginInorder; i < endInorder; i++)
            {
                if (inorder[i] == midNode.val)
                {
                    delimiterInorderIndex = i;
                    break;
                }
            }

            var leftBeginInorder = beginInorder;
            var leftEndInorder = delimiterInorderIndex;
            var rightBeginInorder = delimiterInorderIndex + 1;
            var rightEndInorder = endInorder;

            var leftBeginPreorder = beginPreorder + 1;
            var leftEndPreorder = beginPreorder + 1 + delimiterInorderIndex - beginInorder;
            var rightBeginPreorder = leftEndPreorder;
            var rightEndPreorder = endPreorder;

            midNode.left = BuildTreeB(preorder, inorder, leftBeginPreorder, leftEndPreorder, leftBeginInorder, leftEndInorder);
            midNode.right = BuildTreeB(preorder, inorder, rightBeginPreorder, rightEndPreorder, rightBeginInorder, rightEndInorder);

            return midNode;
        }
        public TreeNode BuildTreeA(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }

            var midNode = new TreeNode(preorder[0]);
            int delimiterInorderIndex = 0;
            for (int i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == midNode.val)
                {
                    delimiterInorderIndex = i;
                }
            }

            var leftInorderList = new List<int>(inorder.ToList().GetRange(0, delimiterInorderIndex));
            var rightInorderList = new List<int>(inorder.ToList().GetRange(delimiterInorderIndex + 1, inorder.Length - delimiterInorderIndex - 1));

            var leftPreorderList = new List<int>(preorder.ToList().GetRange(1, delimiterInorderIndex));
            var rightPreorderList = new List<int>(preorder.ToList().GetRange(delimiterInorderIndex + 1 , inorder.Length - delimiterInorderIndex - 1));

            midNode.left = BuildTreeA(leftPreorderList.ToArray(),leftInorderList.ToArray());
            midNode.right = BuildTreeA(rightPreorderList.ToArray(),rightInorderList.ToArray());

            return midNode;
        }

    }
}
