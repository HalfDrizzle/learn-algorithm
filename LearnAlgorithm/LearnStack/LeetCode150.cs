using System;
using System.Collections.Generic;

namespace LearnAlgorithm.LearnStack;

public class LeetCode150
{
    public LeetCode150()
    {
        var data = new[] { "2", "1", "+", "3", "*" };
        Console.WriteLine(EvalRPN(data));
    }
    public int EvalRPN(string[] tokens)
    {
        Stack<int> chars = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            var c = tokens[i];
            if (c == "+")
            {
                var sum = chars.Pop() + chars.Pop();
                chars.Push(sum);
            }
            else if (c == "-")
            {
                var subtraction = chars.Pop();
                var minuend = chars.Pop();
                var result = minuend - subtraction;
                chars.Push(result);
            }
            else if (c == "*")
            {
                var result = chars.Pop() * chars.Pop();
                chars.Push(result);
            }
            else if (c == "/")
            {
                var diversor = chars.Pop();
                var dividend = chars.Pop();
                var result = dividend / diversor;
                chars.Push(result);
            }
            else
            {
                chars.Push(Convert.ToInt32(c));
            }
        }

        return chars.Pop();
    }
}