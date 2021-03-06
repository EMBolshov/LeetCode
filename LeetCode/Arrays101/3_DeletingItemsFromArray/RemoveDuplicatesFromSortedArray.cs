﻿using System;
using System.Collections.Generic;

namespace LeetCode.Arrays101._3_DeletingItemsFromArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3248/
    /// </summary>
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var elements = new HashSet<int>();
            var removedCount = 0;
            
            for (int i = 0; i < nums.Length - removedCount;)
            {
                if (elements.Contains(nums[i]))
                {
                    ShiftLeft(ref nums, i);
                    removedCount++;
                }
                else
                {
                    elements.Add(nums[i]);
                    i++;
                }
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