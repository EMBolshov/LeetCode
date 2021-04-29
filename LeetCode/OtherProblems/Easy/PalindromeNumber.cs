namespace LeetCode.OtherProblems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            var arr = x.ToString();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[^(i+1)])
                    return false;
            }
            
            return true;
        }
    }
}