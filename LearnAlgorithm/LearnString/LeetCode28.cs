using System;

namespace LearnAlgorithm.LearnString;

public class LeetCode28
{


    public LeetCode28()
    {
        Console.WriteLine(StrStr("hello","ll"));
    }
    
    public void GetNextArray(int[] next, string needle)
    {
        int j = -1;
        next[0] = j;
        for (int i = 1; i < needle.Length; i++)
        {
            while (j >= 0 && needle[i] != needle[j + 1])
            {
                j = next[j];
            }

            if (needle[i] == needle[j+1])
            {
                j++;
            }

            next[i] = j;
        }
    }
    
    public int StrStr(string haystack, string needle)
    {
        var next = new int[needle.Length];
        GetNextArray(next,needle);
        int j = -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            while (j >= 0 && haystack[i] != needle[j + 1])
            {
                j = next[j];
            }
            if (haystack[i] == needle[j+1])
            {
                j++;
            }

            if (j == needle.Length - 1)
            {
                return i - needle.Length + 1;
            }
        }

        return -1;
    }
}