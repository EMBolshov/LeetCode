namespace LeetCode.OtherProblems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var leftIdx = 0;
            var rightIdx = height.Length - 1;
            var result = 0;

            while (leftIdx < rightIdx)
            {
                if (height[leftIdx] < height[rightIdx])
                {
                    var area = (rightIdx - leftIdx) * height[leftIdx];
                    if (result < area)
                        result = area;
                    leftIdx++;
                }
                else
                {
                    var area = (rightIdx - leftIdx) * height[rightIdx];
                    if (result < area)
                        result = area;
                    rightIdx--;
                }
            }

            return result;
        }
    }
}