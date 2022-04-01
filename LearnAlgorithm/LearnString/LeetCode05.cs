using System;

namespace LearnAlgorithm.LearnString;

public class LeetCode05
{
    public LeetCode05()
    {
        var data = "We are happy.";
        Console.WriteLine(ReplaceSpace(data));
    }
    
    public string ReplaceSpace(string s) {
        int count = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == ' ')
                count++;
        }
        char[] result = s.ToCharArray();
        Array.Resize(ref result,s.Length + 2 * count);
        int left = result.Length - 1;
        for (int right = s.Length - 1; right >= 0 ; right--)
        {
            if (result[right] == ' ' )
            {
                result[left--] = '0';
                result[left--] = '2';
                result[left--] = '%';
            }
            else
            {
                result[left] = result[right];
                left--;
            }
        }
        return new string(result);
    }
}