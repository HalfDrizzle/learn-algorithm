using System;

namespace LearnAlgorithm.LearnString;

public class LeetCode344
{
    public LeetCode344()
    {
        // var s = "abcdefg";
        // int index = 2;
        var s = "hyzqyljrnigxvdtneasepfahmtyhlohwxmkqcdfehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl";
        int index = 39;
        Console.WriteLine(ReverseStr(s, index));
    }

    public string ReverseStr(string s, int k)
    {
        char[] chars = s.ToCharArray();
        var stringLength = s.Length - 1;

        if (s.Length < k)
        {
            ReverseStrIndex(chars, 0, stringLength);
            return new string(chars);
        }

        for (int i = 0; i <= chars.Length; i += 2 * k)
        {
            if (i + k < chars.Length)
            {
                ReverseStrIndex(chars, i, i + k - 1);
                continue;
            }

            ReverseStrIndex(chars, i, chars.Length - 1);
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