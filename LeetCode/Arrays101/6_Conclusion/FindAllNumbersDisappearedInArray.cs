using System;
using System.Collections.Generic;

namespace LeetCode.Arrays101._6_Conclusion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3270/
    /// </summary>
    public static class FindAllNumbersDisappearedInArray
    {
        //Also bad solution cuz of Array.Sort() -> O(n log n)
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var res = new List<int>();
            
            if (nums.Length == 0)
                return res;
            
            Array.Sort(nums);
            var prev = nums[0];

            var ptr = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                ptr++;
                
                if (nums[i] == prev && i > 0 && i + 1 < nums.Length)
                {
                    ++i;
                }
                
                if (ptr != nums[i] && ptr <= nums.Length)
                {
                    res.Add(ptr);
                    --i;
                }
                else
                    prev = nums[i];
                
            }

            if (nums[^1] != nums.Length && !res.Contains(nums.Length))
                res.Add(nums.Length);

            return res;
        }

        private static IList<int> BadSolution(int[] nums)
        {
            var res = new List<int>();
            for (int i = 1; i < nums.Length + 1; i++)
                res.Add(i);

            foreach (var t in nums)
            {
                if (res.Contains(t))
                    res.Remove(t);
            }

            return res;
        }
    }
}