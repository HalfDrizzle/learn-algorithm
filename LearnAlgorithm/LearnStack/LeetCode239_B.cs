using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnStack;

public class LeetCode239_B
{
    public LeetCode239_B()
    {
        var data = new[] { 1, 3, -1, -3, 5, 3, 6, 7 };
        var k = 3;
        foreach (var result in MaxSlidingWindow(data, k))
        {
            Console.Write(result + " ");
        }
    }
    
    private class Myqueue
    {
        LinkedList<int> queue = new LinkedList<int>();
        public void Pop(int value) {
            if (queue.First != null && value == queue.First.Value)
            {
                queue.RemoveFirst();
            }
        }
        public void Push(int value) {
            while (queue.Last!=null && value > queue.Last.Value)
            {
                queue.RemoveLast();
            }

            queue.AddLast(value);
        }
        
        public int Front() {
            return queue.First.Value;
        }
    }
    
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(nums == null || nums.Length < 2) return nums;
        Myqueue queue = new Myqueue();
        int[] result = new int[nums.Length - k + 1];
        for(int i = 0; i < k; i++){
            queue.Push(nums[i]);
        }
        result[0] = queue.Front();
        for(int i = k; i < nums.Length; i++){
            queue.Pop(nums[i - k]);
            queue.Push(nums[i]);
            result[i - k + 1] = queue.Front();
        }

        return result;
    }
}