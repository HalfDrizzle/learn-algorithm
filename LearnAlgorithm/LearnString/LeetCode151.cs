using System;

namespace LearnAlgorithm.LearnString;

public class LeetCode151
{
    public LeetCode151()
    {
        var s = "  the sky is  blue   ";
        Console.WriteLine(ReverseWords(s));
    }
    
    public string ReverseWords(string s)
    {
        //remove space
        var chars = s.ToCharArray();
        int left = 0, right = 0;

        int count = 0;
        for (; right < chars.Length; right++)
        {
            if (chars[right] == ' ')
            {
                chars[left++] = chars[right++];
                if (right == chars.Length - 1)
                {
                    chars[left] = chars[right];
                    count++;
                    break;
                }
                
                while (right < chars.Length && chars[right] == ' ')
                {
                    right++;
                    count++;
                }
                
                if (right >= chars.Length - 1 )
                {
                    break;
                }
                
                chars[left++] = chars[right];
                continue;
            }
            chars[left] = chars[right];
            left++;
        }

        chars[^count] = '\0';

        ReverseStrIndex(chars,0, chars.Length - 1 - count);

        var length = chars.Length - 1 - count;

        left = 0;
        for (right = 0; right <= length; right++)
        {
            if (chars[right] == ' ')
            {
                ReverseStrIndex(chars, left, right - 1);
                left = ++right;
            }
            else if (right == length)
            {
                ReverseStrIndex(chars, left, right);
            }
        }

        return new string(chars);
    }
    
    void ReverseStrIndex(char[] s, int start, int end){
        for(int i = start, j = end; i < j; i++, j--){
            (s[i], s[j]) = (s[j], s[i]);
        }
    }
}