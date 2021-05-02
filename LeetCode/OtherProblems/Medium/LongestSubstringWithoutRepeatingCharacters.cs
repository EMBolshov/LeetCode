using System.Collections.Generic;

namespace LeetCode.OtherProblems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (s.Length == 1) return 1;

            var result = 1;
            var currentString = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                currentString.Add(s[i]);
                
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (currentString.Contains(s[j]))
                    {
                        result = Complete();
                        break;
                    }

                    currentString.Add(s[j]);

                    if (j == s.Length - 1)
                    {
                        result = Complete();
                        break;
                    }
                }
            }

            return result;

            int Complete()
            {
                var count = currentString.Count;
                if (count > result)
                    result = count;

                currentString.Clear();
                return result;
            }
        }
    }
}