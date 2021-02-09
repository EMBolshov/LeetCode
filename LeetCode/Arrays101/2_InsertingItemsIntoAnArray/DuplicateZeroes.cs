namespace LeetCode.Arrays101._2_InsertingItemsIntoAnArray
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
    /// </summary>
    public static class DuplicateZeroes
    {
        public static void DuplicateZeros(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    ShiftRight(ref nums, i);
                    i++;
                }
            }
        }
    
        private static void ShiftRight(ref int[] arr, int idx)
        {
            for (int i = arr.Length - 1; i > idx; i--)
            {
                arr[i] = arr[i - 1];
            }
        }
    }
}