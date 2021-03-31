using System;
using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._2_SolveProblemsRecursively
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/535/
    /// </summary>
    public static class MaximumDepthOfBinaryTree
    {
        public static int MaxDepth(MyBinaryTree root)
        {
            if (root == null)
                return 0;

            return GetDepth(root, 0);

            int GetDepth(MyBinaryTree root, int depth)
            {
                if (root == null)
                    return depth;

                return Math.Max(GetDepth(root.Left, depth + 1), GetDepth(root.Right, depth + 1));
            }
        }
    }
}