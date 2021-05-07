namespace LeetCode.OtherProblems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public static class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 1)
                return s;

            var result = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                var current = string.Empty;
                current += s[i];

                for (int j = i + 1; j <= s.Length; j++)
                {
                    if (result.Length < current.Length /*&& isPalindromeV2(s[j - 1], current[^1])*/ && isPalindrome(current))
                    {
                        result = current;
                    }

                    if (j != s.Length)
                        current += s[j];
                }
            }

            return result;

            bool isPalindrome(string p)
            {
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] != p[^(i + 1)])
                        return false;
                }

                return true;
            }
            
            /*
            bool isPalindromeV2(char first, char last)
            {
                return first == last;
            }
            */
        }
    }
}