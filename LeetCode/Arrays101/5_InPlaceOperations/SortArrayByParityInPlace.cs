using System.Collections.Generic;

namespace LeetCode.Arrays101._5_InPlaceOperations
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3260/
    /// </summary>
    public static class SortArrayByParityInPlace
    {
        public static int[] SortArrayByParity(int[] A)
        {
            var evens = new List<int>();
            var odds = new List<int>();

            foreach (var t in A)
            {
                if (t % 2 == 0)
                    evens.Add(t);
                else
                    odds.Add(t);
            }

            evens.AddRange(odds);

            return evens.ToArray();
        }
    }
}