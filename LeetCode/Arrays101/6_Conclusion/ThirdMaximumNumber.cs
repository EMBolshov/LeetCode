using System.Linq;

namespace LeetCode.Arrays101._6_Conclusion
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3231/
    /// </summary>
    public static class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            var distinct = nums.Distinct().ToArray();
            var first = nums[0];
            int? second = null;
            int? third = null;

            switch (distinct.Length)
            {
                case 1:
                    return first;
                case 2:
                    return distinct[0] > distinct[1] ? distinct[0] : distinct[1];
                case 3:
                    return distinct.Min();
            }

            for (int i = 1; i < distinct.Length; i++)
            {
                if (i == 1)
                {
                    if (distinct[i] > first)
                    {
                        second = first;
                        first = distinct[i];
                    }
                    else
                    {
                        second = distinct[i];
                    }
                    
                    continue;
                }

                if (i == 2)
                {
                    if (distinct[i] > first)
                    {
                        third = second;
                        second = first;
                        first = distinct[i];
                    }
                    else if (distinct[i] > second)
                    {
                        third = second;
                        second = distinct[i];
                    }
                    else
                    {
                        third = distinct[i];
                    }
                    
                    continue;
                }

                if (distinct[i] > first)
                {
                    third = second;
                    second = first;
                    first = distinct[i];
                }
                else if (distinct[i] > second)
                {
                    third = second;
                    second = distinct[i];
                }
                else if (distinct[i] > third)
                {
                    third = distinct[i];
                }
            }

            if (third == null)
                return first;

            return third.Value;
        }
    }
}