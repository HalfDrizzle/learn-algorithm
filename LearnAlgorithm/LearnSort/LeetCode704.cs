using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlgorithm.LearnSort
{
    internal class LeetCode704
    {
        public LeetCode704()
        {
            var data = new int[] { -1, 0, 3, 5, 9, 12 };
            Console.Write(Search(data, 9));
        }
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length;
            int mid = (right - left) / 2;
            while (left <= mid && mid < right)
            {
                var n = nums[mid];
                if (n > target)
                {
                    right = mid;
                }
                else if (n < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
                mid = (right - left) / 2 + left;
            }

            return -1;
        }
    }
}
