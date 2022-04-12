using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnStack;

public class LeetCode347
{
    public LeetCode347()
    {
        var nums = new[] {1,2 };
        var k = 2;
        foreach (var result in TopKFrequent(nums, k))
        {
            Console.Write(result+" ");
        }
    }
    
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int,int> test = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            if (test.TryGetValue(n,out int value))
            {
                test[n] = ++value;
            }
            else
            {
                test.Add(n, 0);
            }
        }


        
        foreach (var kv in test)
        {
            if ()
            {
                
            }
        }
    }
}