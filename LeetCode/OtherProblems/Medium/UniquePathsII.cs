namespace LeetCode.OtherProblems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths-ii/
    /// </summary>
    public static class UniquePathsII
    {
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid[0][0] == 1) return 0;

            var n = obstacleGrid[0].Length;
            var m = obstacleGrid.Length;

            var result = new int[n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                        result[j] = 0;
                    else if (i == 0 && j == 0)
                        result[j] = 1;
                    else if (i == 0)
                        result[j] = result[j - 1];
                    else if (j == 0)
                        result[j] = result[j];
                    else
                        result[j] += result[j - 1];
                }
            }

            return result[^1];
        }
    }
}