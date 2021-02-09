using System;

namespace LeetCode.Arrays101._2_InsertingItemsIntoAnArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
    /// </summary>
    public static class MergeSortedArray
    {
        //TODO: подумать о лучшем решении
        //Наверняка имелось в виду, что я должен сразу вставлять в отсортированном порядке
        //Но тогда дайте мне массив через ref!
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }

            Array.Sort(nums1);
        }
    }
}