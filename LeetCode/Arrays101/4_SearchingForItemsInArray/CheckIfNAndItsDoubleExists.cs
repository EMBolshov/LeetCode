using System.Collections.Generic;

namespace LeetCode.Arrays101._4_SearchingForItemsInArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
    /// </summary>
    public static class CheckIfNAndItsDoubleExists
    {
        public static bool CheckIfExist(int[] arr)
        {
            var hash = new HashSet<int>();
            foreach (var i in arr)
            {
                if (hash.Contains(i * 2) || (i % 2 == 0 && hash.Contains(i / 2)))
                    return true;

                hash.Add(i);
            }

            return false;
        }
    }
}