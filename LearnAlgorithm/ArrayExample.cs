
using System;

namespace LearnAlgorithm
{
    public class ArrayExample
    {
        public int[] arrays = new int[30];

        protected ArrayExample()
        {
            int count = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                count += 2;
                arrays[i] = count;
            }
            //arrays = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        }
    }


    public class Array_01 : ArrayExample
    {
        public Array_01() : base()
        {
            int count = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                count += 2;
                arrays[i] = count;
            }
        }

        public int DichotomousMethod1(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int middle = left + ((right - left) / 2);
                if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }

    public class Array_02 : ArrayExample
    {
        public Array_02() : base()
        {
            int count = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                count += 2;
                arrays[i] = count;
            }
        }

        public int RemoveElement(int[] nums, int val)
        {
            int end = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != val)
                {
                    nums[end++] = nums[i];
                }
            }
            return end;
        }
    }

    public class Array_03 : ArrayExample
    {
        public Array_03() : base()
        {
            arrays = new int[] { -4, -1, 0, 3, 10 };
        }

        public int[] SortedSquares(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return nums;
            }
            var results = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int index = nums.Length - 1;
            while (index >= 0)
            {
                var leftValue = nums[left] * nums[left];
                var rightValue = nums[right] * nums[right];
                if (leftValue > rightValue)
                {
                    results[index--] = leftValue;
                    left++;
                }
                else
                {
                    results[index--] = rightValue;
                    right--;
                }
            }

            return results;
        }
    }

    public class Array04 : ArrayExample
    {
        public Array04() 
        {
            arrays = new int[] {2,3,1,2,4,3 };
        }
        
        public int MinSubArrayLen(int target, int[] nums)
        {
            int result = Int32.MaxValue;

            if (nums.Length == 0)
            {
                return 0;
            }
            
            int start = 0;
            int sum = 0;
            for (int end = 0; end < nums.Length; end++)
            {
                sum += nums[end];
                while ( sum >= target )
                {
                    var length = end - start + 1;
                    result = length < result ? length : result;
                    sum -= nums[start++];
                }
            }

            if (result == Int32.MaxValue)
            {
                return 0;
            }
            return result;
        }
    }
}
