using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnTree
{
    internal class LeetCode108:TreeExample
    {
        public LeetCode108()
        {
            var data = new int[] { -10, -3, 0, 5, 9 };
            var node =SortedArrayToBST(data);
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length);
        }

        public TreeNode SortedArrayToBST(int[] nums, int begin, int end)
        {
            if (begin >= end)
            {
                return null;
            }
            var mid = begin+((end - begin) / 2);
            var node = new TreeNode(nums[mid]);
            node.left = SortedArrayToBST(nums, begin, mid);
            node.right = SortedArrayToBST(nums, mid + 1, end);
            return node;
        }
    }
}
