using System;
using System.Collections.Generic;

namespace LearnAlgorithm;

public class LeetCode383
{
    public void InitData()
    {
        string ransomNote = "a";
        string magazine = "b";

        Console.WriteLine(CanConstruct(ransomNote, magazine));
        Console.WriteLine(CanConstructNew(ransomNote, magazine));
    }

    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> maDic = new Dictionary<char, int>();
        foreach (var c in magazine)
        {
            if (maDic.TryGetValue(c, out var count))
            {
                maDic[c] += 1;
            }
            else
            {
                maDic.Add(c, 1);
            }
        }

        foreach (var c in ransomNote)
        {
            if (maDic.TryGetValue(c, out var count))
            {
                if (count <= 0)
                {
                    return false;
                }
                else
                {
                    maDic[c]--;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public bool CanConstructNew(string ransomNote, string magazine)
    {
        int[] maDic = new int[26];
        foreach (var c in magazine)
        {
            maDic[c - 'a'] += 1;
        }

        foreach (var c in ransomNote)
        {
            var index = c - 'a';
            if (maDic[index] <= 0)
            {
                return false;
            }
            maDic[index]--;
        }

        return true;
    }
}