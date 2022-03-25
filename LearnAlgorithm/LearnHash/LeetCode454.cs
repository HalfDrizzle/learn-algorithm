using System;
using System.Collections.Generic;

namespace LearnAlgorithm;

public class LeetCode454
{
    public void InitData()
    {
        int[] nums1 = new int[]{1, 2};
        int[] nums2 = { -2, -1 };
        int[] nums3 = {-1,2};
        int[] nums4 = {0,2};

        Console.WriteLine(FourSumCount(nums1, nums2, nums3, nums4));
    }
    
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        Dictionary<int, int> abDic = new Dictionary<int, int>();
        for(int i = 0; i < nums1.Length; i++){
            for(int j = 0; j < nums2.Length; j++){
                var sum = nums1[i]+nums2[j];
                if(abDic.ContainsKey(sum)){
                    abDic[sum]++;
                }else{
                    abDic[sum] = 1;
                }
            }
        }
        
        int count = 0;
        for(int i = 0; i < nums3.Length; i++){
            for(int j = 0; j < nums4.Length; j++){
                var sum = (0-nums3[i]-nums4[j]);
                if(abDic.TryGetValue(sum, out var result)){
                    count += result;
                }
            }
        }
        return count;
    }
}