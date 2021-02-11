using System;
using System.Collections.Generic;

namespace LeetCode.Arrays101._3_DeletingItemsFromArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
    /// </summary>
    public static class RemoveDuplicatesFromSortedArray
    {
        //По условию массив без ref
        public static int RemoveDuplicates(ref int[] nums)
        {
            var elements = new HashSet<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (elements.Contains(nums[i]))
                {
                    //вместо того, чтобы выкидывать один элемент а потом делать снова сорт, лучше все сдвигать
                    nums[i] = nums[nums.Length - 1];
                    Array.Resize(ref nums, nums.Length - 1);
                    i--;
                }

                elements.Add(nums[i]);
            }
            
            Array.Sort(nums);
            return nums.Length;
        }
    }
}