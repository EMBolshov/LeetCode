using System.Collections.Generic;

namespace LeetCode.Recursion_I._3_Memoization
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/255/recursion-memoization/1661/
    /// </summary>
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            var cache = new Dictionary<int, int>();
            return Next(n);

            int Next(int idx)
            {
                switch (idx)
                {
                    case 0:
                        cache[idx] = 0;
                        break;
                    case 1:
                    case 2:
                        cache[idx] = 1;
                        break;
                    default:
                    {
                        if (!cache.ContainsKey(idx))
                        {
                            var value = Next(idx - 1) + Next(idx - 2);
                            cache[idx] = value;
                        }
                        
                        break;
                    }
                }

                return cache[idx];
            }
        }
    }
}