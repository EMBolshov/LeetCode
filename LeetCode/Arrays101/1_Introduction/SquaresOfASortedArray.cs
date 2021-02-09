using System.Linq;

namespace LeetCode.Arrays101._1_Introduction
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/
    /// </summary>
    public static class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            return nums.Select(x => x * x).OrderBy(x => x).ToArray();
        }
    }
}