using System.Linq;

namespace LeetCode.Arrays101._5_InPlaceOperations
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
    /// </summary>
    public static class ReplaceElementsWithGreatestElementOnRightSide
    {
        public static int[] ReplaceElements(int[] arr)
        {
            var res = new int[arr.Length];
            var max = arr[^1];

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                res[i] = max;
                
                if (arr[i] > max)
                    max = arr[i];
            }

            res[^1] = -1;
            return res;            
        }

        // Time Limit Exceeded. :(
        private static int GetMax(int[] arr, int n)
        {
            return arr.Skip(n).Max();
        }
    }
}