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

            foreach (var n in nums)
            {
                if (first == n || second == n || third == n)
                    continue;

                if (n > first)
                {
                    third = second;
                    second = first;
                    first = n;
                }
                else if (second == null || n > second)
                {
                    third = second;
                    second = n;
                }
                else if (third == null || n > third)
                {
                    third = n;
                }
            }

            return third ?? first;
        }
    }
}