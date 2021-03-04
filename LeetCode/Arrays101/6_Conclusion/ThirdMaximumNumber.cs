using System.Linq;

namespace LeetCode.Arrays101._6_Conclusion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3231/
    /// </summary>
    public static class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            var first = nums[0];
            int? second = null;
            int? third = null;

            for (int i = 0; i < nums.Length; i++)
            {
                if (first == nums[i] || second == nums[i] || third == nums[i])
                    continue;

                if (nums[i] > first)
                {
                    third = second;
                    second = first;
                    first = nums[i];
                }
                else if (second == null || nums[i] > second)
                {
                    third = second;
                    second = nums[i];
                }
                else if (third == null || nums[i] > third)
                {
                    third = nums[i];
                }
            }

            if (third == null)
                return first;

            return third.Value;
        }
    }
}