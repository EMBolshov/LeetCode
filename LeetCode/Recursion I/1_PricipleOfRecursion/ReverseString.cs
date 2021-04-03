using System;
using System.Collections.Generic;

namespace LeetCode.Recursion_I._1_PricipleOfRecursion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/250/principle-of-recursion/1440/
    /// </summary>
    public static class ReverseString
    {
        public static void StringReverse(char[] s)
        {
            Reverse(s, 0, s.Length - 1);

            void Reverse(char[] s, int left, int right)
            {
                if (left > right)
                    return;
                
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                
                Reverse(s, left + 1, right - 1);
            }
        }
    }
}