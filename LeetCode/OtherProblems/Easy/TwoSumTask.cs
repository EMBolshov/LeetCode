namespace LeetCode.OtherProblems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public static class TwoSumTask
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] {i, j};
                }
            }

            return null;
        }
    }
}