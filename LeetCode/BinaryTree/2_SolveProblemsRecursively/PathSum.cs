using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._2_SolveProblemsRecursively
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/537/
    /// </summary>
    public static class PathSum
    {
        public static bool HasPathSum(MyBinaryTree root, int targetSum)
        {
            return root != null && HasPathSumRecursively(root, 0, targetSum);

            bool HasPathSumRecursively(MyBinaryTree root, int current, int target)
            {
                var complete = false;
                current += root.Value;

                if (root.Left == null && root.Right == null && current == target)
                    return true;

                if (root.Left != null)
                    complete = HasPathSumRecursively(root.Left, current, target);

                if (root.Right != null)
                    complete = complete || HasPathSumRecursively(root.Right, current, target);

                return complete;
            }
        }
    }
}