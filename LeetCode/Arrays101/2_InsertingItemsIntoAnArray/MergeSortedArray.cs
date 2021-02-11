using System;

namespace LeetCode.Arrays101._2_InsertingItemsIntoAnArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
    /// </summary>
    public static class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var shift = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    shift = false;
                    if (nums2[i] < nums1[j])
                    {
                        ShiftRight(ref nums1, j);
                        shift = true;
                        nums1[j] = nums2[i];
                        break;
                    }
                }

                if (!shift)
                    nums1[m + i] = nums2[i];
            }
        }

        private static void ShiftRight(ref int[] nums, int n)
        {
            for (int i = nums.Length - 1; i > n; i--)
            {
                nums[i] = nums[i - 1];
            }
        }
    }
}