using System;

namespace LeetCode.Arrays101._3_DeletingItemsFromArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
    /// </summary>
    public static class RemoveElementInPlace
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var removedCount = 0;
            for (int i = 0; i < nums.Length - removedCount;)
            {
                if (nums[i] == val)
                {
                    ShiftLeft(ref nums, i);
                    removedCount++;
                }
                else
                    i++;
            }
            
            Array.Resize(ref nums, nums.Length - removedCount);

            return nums.Length;
        }

        private static void ShiftLeft(ref int[] nums, int n)
        {
            for (int i = n; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
        }
    }
}