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
            result = GetRowRecursively(result,rowIndex);
            return result;
            
            List<int> GetRowRecursively(List<int> prevRow, int targetIndex, int currentIndex = 0)
            {
                if (currentIndex == targetIndex)
                    return prevRow;

                var currentRow = new List<int>();
                for (int i = 0; i <= targetIndex; i++)
                {
                    if (i == 0 || i == targetIndex)
                    {
                        currentRow.Add(1);
                    }
                    else
                    {
                        currentRow.Add(prevRow[i - 1] + prevRow[i]);
                    }
                }

                return GetRowRecursively(currentRow, targetIndex, currentIndex + 1);
            }
        }
    }
}