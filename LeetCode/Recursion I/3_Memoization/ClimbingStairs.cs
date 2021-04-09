using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Recursion_I._3_Memoization
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/255/recursion-memoization/1662/
    /// </summary>
    public static class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            Dictionary<int, int> cache = new();

            return GetSteps(n);

            int GetSteps(int n)
            {
                if (cache.ContainsKey(n))
                    return cache[n];
                
                if (n <= 1)
                {
                    cache[n] = 1;
                    return 1;
                }

                var firstStep = GetSteps(n - 1);
                var secondStep = GetSteps(n - 2);
                cache[n] = firstStep + secondStep;

                return firstStep + secondStep;
            }
        }
    }
}