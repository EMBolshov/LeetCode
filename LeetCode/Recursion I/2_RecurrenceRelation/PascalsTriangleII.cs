using System.Collections.Generic;

namespace LeetCode.Recursion_I._2_RecurrenceRelation
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/251/scenario-i-recurrence-relation/3234/
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class PascalsTriangleII
    {
        public static IList<int> GetRow(int rowIndex)
        {
            var result = new List<int>();
            var cache = new Dictionary<(int, int), int>();
            
            for (int i = 0; i <= rowIndex; i++)
            {
                result.Add(GetValue(cache, rowIndex, i));
            }

            return result;

            static int GetValue(IDictionary<(int, int), int> cache, int row, int index)
            {
                if (row < 0 || index < 0)
                    return 0;
            
                if (row == 0 || index == row)
                    return 1;

                if (cache.ContainsKey((row, index)))
                {
                    return cache[(row, index)];
                }

                var left = GetValue(cache, row - 1, index - 1);
                var right = GetValue(cache, row - 1, index);

                cache[(row, index)] = left + right;

                return left + right;
            }
        }
    }
}