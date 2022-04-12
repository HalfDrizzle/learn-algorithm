using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnStack;

public class LeetCode1047
{
    public LeetCode1047()
    {
        var s = "abbaca";
        Console.WriteLine(RemoveDuplicates(s));
    }
    
    public string RemoveDuplicates(string s)
    {
        var chars = s.ToCharArray();
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < chars.Length; i++)
        {
            var e = chars[i];
            if (stack.TryPeek(out var c) && e == c)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(e);
            }
        }

        var length = stack.Count;
        for (int i = stack.Count - 1; stack.Count > 0; i--)
        {
            chars[i] = stack.Pop();
        }

        return new string(chars,0,length);
    }
}