using System;

namespace LearnAlgorithm
{
    public abstract class ArrayExample
    {
        public int[] arrays;

        public virtual void InitData()
        {
            throw new NotImplementedException();
        }
        
        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }


    public sealed class Array01 : ArrayExample
    {
        public Array01(bool print = true)
        {
            InitData();
            if (print)
            {
                Print();
            }
        }

        public override void InitData()
        {
            int count = 0;
            arrays = new int[30];
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

    public sealed class Array02 : ArrayExample
    {
        public Array02(bool print = true)
        {
            InitData();
            if (print)
            {
                Print();
            }
        }
        
        public override void InitData()
        {
            int count = 0;
            arrays = new int[30];
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

        public override void Print()
        {
            Console.WriteLine(RemoveElement(arrays, 2));
        }
    }

    public sealed class Array03 : ArrayExample
    {
        public Array03(bool print = true)
        {
            InitData();
            if (print)
            {
                Print();
            }
        }

        public override void InitData()
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

        public override void Print()
        {
            Console.WriteLine(SortedSquares(arrays));
        }
    }

    public sealed class Array04 : ArrayExample
    {
        public Array04(bool print = true)
        {
            InitData();
            if (print)
            {
                Print();
            }
        }
        
        public override void InitData()
        {
            arrays = new int[] { 2, 3, 1, 2, 4, 3 };
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
                while (sum >= target)
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

        public override void Print()
        {
            Console.WriteLine(MinSubArrayLen(7, arrays));
        }
    }

    public sealed class Array05 : ArrayExample
    {
        public Array05(bool print = true)
        {
            InitData();
            if (print)
            {
                Print();
            }
        }
        
        public override void InitData()
        {
        }

        public int[][] GenerateMatrix(int n)
        {
            var result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }

            int count = 1;
            int loop = 0;
            int mid = n / 2;
            int end;
            while (loop <= mid)
            {
                end = n - 1 - loop;
                for (int i = loop; i < end; i++)
                {
                    result[loop][i] = count++;
                }

                for (int i = loop; i < end; i++)
                {
                    result[i][end] = count++;
                }

                for (int i = end; i > loop; i--)
                {
                    result[end][i] = count++;
                }

                for (int i = end; i > loop; i--)
                {
                    result[i][loop] = count++;
                }

                loop++;
            }

            // 如果n为奇数的话，需要单独给矩阵最中间的位置赋值
            if (n % 2 != 0)
            {
                result[mid][mid] = count;
            }

            return result;
        }

        public override void Print()
        {
            var matrix = GenerateMatrix(4);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}