namespace LeetCode.Arrays101._5_InPlaceOperations
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3157/
    /// </summary>
    public static class MoveZeroesInPlace
    {
        public static void MoveZeroes(int[] nums)
        {
            var shifts = 0;
            
            for (int i = 0; i < nums.Length - shifts; i++)
            {
                if (nums[i] == 0)
                {
                    ShiftLeft(ref nums, i, shifts);
                    shifts++;
                    i--;
                }
            }
        }

        private static void ShiftLeft(ref int[] nums, int start, int end)
        {
            for (int i = start; i < nums.Length - 1 - end; i++)
            {
                nums[i] = nums[i + 1];
            }
            
            nums[^(1 + end)] = 0;
        }
    }
}