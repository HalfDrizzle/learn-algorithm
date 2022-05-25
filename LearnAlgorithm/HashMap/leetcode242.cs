namespace LearnAlgorithm.HashMap;

public class leetcode242
{
    public bool IsAnagram(string s, string t)
    {

        int start = (int)'a';
        int[] tableA = new int[26];
        int[] tableB = new int[26];

        foreach (var c in s)
        {
            var key = (int)c - start;
            tableA[key]++;
        }

        foreach (var c in t)
        {
            var key = (int)c - start;
            tableB[key]++;
        }

        for (int i = 0; i < tableA.Length; i++)
        {
            if (tableA[i] != tableB[i])
            {
                return false;
            }
        }

        return true;
    }
}