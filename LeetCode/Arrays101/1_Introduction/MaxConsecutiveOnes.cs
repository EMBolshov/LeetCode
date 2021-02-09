namespace LeetCode.Arrays101._1_Introduction
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/ 
    /// </summary>
    public static class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            var counter = 0;
            var maxCounter = 0;
            foreach (var i in nums)
            {
                if (i == 1)
                    counter++;

                if (maxCounter < counter)
                    maxCounter = counter;

                if (i == 0)
                    counter = 0;
            }

            return maxCounter;
        }
    }
}