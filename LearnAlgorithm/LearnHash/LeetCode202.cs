using System.Collections.Generic;

namespace LearnAlgorithm;

public class LeetCode202
{
    public bool IsHappy(int n) {
        HashSet<int> nums = new HashSet<int>();
        int sum = 0;
        while( sum != 1 )
        {
            sum = 0;
            while( n != 0 )
            {
                var pop = n % 10;
                sum += pop*pop;
                n /= 10;
            }
            if(nums.Contains(sum)){
                return false;
            }
            nums.Add(sum);
            n = sum;
        }
        return true;
    }
}