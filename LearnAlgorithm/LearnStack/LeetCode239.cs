using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnStack;

public class LeetCode239
{
    public LeetCode239()
    {
        var data = new[] { 1, 3, -1, -3, 5, 3, 6, 7 };
        var k = 3;
        foreach (var result in MaxSlidingWindow(data, k))
        {
            Console.Write(result + " ");
        }
    }
    
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(nums == null || nums.Length < 2) return nums;
        LinkedList<int> queue = new LinkedList<int>();
        int[] result = new int[nums.Length - k + 1];
        for(int i = 0; i < nums.Length; i++){
            // 保证从大到小 如果前面数小则需要依次弹出，直至满足要求
            while(queue.First != null && nums[queue.Last.Value] <= nums[i]){
                queue.RemoveLast();
            }
            // 添加当前值对应的数组下标
            queue.AddLast(i);
            // 判断当前队列中队首的值是否有效
            if(queue.First != null && queue.First.Value <= i-k){
                queue.RemoveFirst();   
            } 
            // 当窗口长度为k时 保存当前窗口中最大值
            if(i+1 >= k){
                result[i+1-k] = nums[queue.First.Value];
            }
        }

        return result;
    }
}