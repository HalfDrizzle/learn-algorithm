using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode654: TreeExample
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTreeTest(nums, 0, nums.Length);
        }

        private TreeNode ConstructMaximumBinaryTreeTest(int[] nums, int beginIndex, int endIndex)
        {
            if (beginIndex >= endIndex)
            {
                return null;
            }

            int max = nums[beginIndex];
            int maxIndex = beginIndex;
            for (int i = beginIndex + 1; i < endIndex; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }

            var midNode = new TreeNode(max);
            var leftBeginIndex = beginIndex;
            var leftEndIndex = maxIndex;
            var rightBeginIndex = maxIndex + 1;
            var rightEndIndex = endIndex;

            midNode.left = ConstructMaximumBinaryTreeTest(nums, leftBeginIndex, leftEndIndex);
            midNode.right = ConstructMaximumBinaryTreeTest(nums, rightBeginIndex, rightEndIndex);
            return midNode;
        }
    }
}
