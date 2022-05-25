using System;

namespace LearnAlgorithm.LearnString;

public class LeetCode151
{
    public LeetCode151()
    {
        var s = "  the sky is    blue      ";
        Console.WriteLine(ReverseWords(s));
    }

    public string ReverseWords(string s)
    {
        //remove space
        var chars = s.ToCharArray();
        int left = 0, right = 0;

        while (chars[right] == ' ')
        {
            right++;
        }

        for (; right < chars.Length; right++)
        {
            if (right - 1 > 0 && chars[right - 1] == chars[right] && chars[right] == ' ')
            {
                continue;
            }
            else
            {
                chars[left++] = chars[right];
            }
        }

        if (left - 1 > 0 && chars[left - 1] == ' ')
        {
            Array.Resize(ref chars, left - 1);
        }
        else
        {
            Array.Resize(ref chars, left);
        }

        ReverseStrIndex(chars, 0, chars.Length - 1);

        var length = chars.Length - 1;

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

    void ReverseStrIndex(char[] s, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
        {
            (s[i], s[j]) = (s[j], s[i]);
        }
    }
}