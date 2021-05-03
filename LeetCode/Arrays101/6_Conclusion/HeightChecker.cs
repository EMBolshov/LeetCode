using System;
using System.Linq;

namespace LeetCode.Arrays101._6_Conclusion
{
    /// <summary>
    /// https://leetcode.com/explore/featured/card/fun-with-arrays/523/conclusion/3228/
    /// </summary>
    public static class HeightChecker
    {
        public static int NotMatchingIndices(int[] heights)
        {
            var sorted = new int[heights.Length];
            Array.Copy(heights, sorted, heights.Length);
            Array.Sort(sorted);

            return heights.Where((t, i) => t != sorted[i]).Count();
        }
    }
}