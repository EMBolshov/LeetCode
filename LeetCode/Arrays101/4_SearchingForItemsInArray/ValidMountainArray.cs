using System.Linq;

namespace LeetCode.Arrays101._4_SearchingForItemsInArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3251/
    /// </summary>
    public static class ValidMountainArray
    {
        public static bool IsValidMountainArray(int[] arr)
        {
            if (!ValidateStartConditions()) 
                return false;

            var lastNum = arr[0];
            var rising = false;
            var canRise = true;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == lastNum)
                    return false;

                if (arr[i] > lastNum)
                    rising = true;

                if (arr[i] < lastNum)
                {
                    rising = false;
                    canRise = false;
                }

                if (rising && !canRise)
                    return false;

                lastNum = arr[i];
            }

            return !canRise;

            bool ValidateStartConditions()
            {
                var sortedAsc = arr.OrderBy(x => x).ToArray();
                if (arr.SequenceEqual(sortedAsc))
                    return false;

                var sortedDesc = arr.OrderByDescending(x => x).ToArray();
                if (arr.SequenceEqual(sortedDesc))
                    return false;

                if (arr.Length < 3)
                    return false;
                
                return true;
            }
        }
    }
}