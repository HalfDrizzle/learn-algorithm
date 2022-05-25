using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnStack;

public class LeetCode20
{
    public LeetCode20()
    {
        Solution s = new Solution();
    }
    public class Solution
    {

        public Solution()
        {
            var s = "()";
            Console.WriteLine(IsValid(s));
        }
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c is '(' or '{' or '[')
                {
                    stack.Push(c);
                }
                else if (c is ')' or '}' or ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var p = stack.Pop();
                    if (c == ')' && p != '(' || c == '}' && p != '{' || c == ']' && p != '[')
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }

            return false;

        }
    }
}