using System.Linq;

namespace LeetCode.Arrays101._1_Introduction
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/
    /// </summary>
    public static class FindNumbersWithEvenNumberOfDigits
    {
        public static int FindNumbers(int[] nums)
        {
            return nums.Select(GetDigestCount).Count(digestCount => digestCount % 2 == 0);
        }

        private static int GetDigestCount(int num)
        {
            return num.ToString().Length;
        }
    }
}