using System.Collections.Generic;
using System.Linq;

namespace LeetCode.OtherProblems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var parentheses = new List<char> { '(', ')', '{', '}', '[', ']' };
        
            var parenthesesMap = new Dictionary<char, char>
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };

            var stack = new Stack<char>();
            
            foreach (var c in s)
            {
                if (parentheses.Contains(c))
                {
                    if (parenthesesMap.Keys.Contains(c))
                    {
                        if (!stack.TryPop(out var lastParentheses) || lastParentheses != parenthesesMap[c])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }
            }

            if (stack.Any()) return false;
            
            return true;
        }
    }
}