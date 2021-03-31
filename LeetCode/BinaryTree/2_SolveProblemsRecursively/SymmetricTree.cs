using System.Collections.Generic;
using System.Linq;
using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._2_SolveProblemsRecursively
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/536/
    /// </summary>
    public static class SymmetricTree
    {
        public static bool IsSymmetric(MyBinaryTree root)
        {
            //return IsSymmetricIteratively(root);
            return IsSymmetricRecursively(root);
        }

        private static bool IsSymmetricRecursively(MyBinaryTree root)
        {
            return IsMirror(root, root);

            bool IsMirror(MyBinaryTree left, MyBinaryTree right)
            {
                if (left == null && right == null)
                    return true;

                if (left == null || right == null)
                    return false;

                return left.Value == right.Value && IsMirror(left.Left, right.Right) && IsMirror(left.Right, right.Left);
            }
        }

        private static bool IsSymmetricIteratively(MyBinaryTree root)
        {
            if (root == null)
                return false;

            var left = root.Left;
            var right = root.Right;

            if (left?.Value != right?.Value)
                return false;

            var leftSubtree = GetSubTree(left).ToArray();
            var rightSubtree = GetSubTree(right).ToArray();

            for (int i = 0; i < leftSubtree.Length; i++)
            {
                var leftNodes = leftSubtree[i];
                var rightNodes = rightSubtree[i].Reverse().ToList();
                for (int j = 0; j < leftNodes.Count; j++)
                {
                    if (leftNodes[j]?.Value != rightNodes[j]?.Value)
                        return false;
                }
            }

            return true;
        }
        
        private static IEnumerable<IList<MyBinaryTree>> GetSubTree(MyBinaryTree root)
        {
            var result = new List<List<MyBinaryTree>>();
            var level = GetLevel(new[] {root});
            
            while (level.Any(n => n != null))
            {
                result.Add(level.ToList());
                level = GetLevel(level);
            }

            return result;

            List<MyBinaryTree> GetLevel(IEnumerable<MyBinaryTree> parents)
            {
                var level = new List<MyBinaryTree>();

                foreach (var node in parents)
                {
                    level.Add(node?.Left);
                    level.Add(node?.Right);
                }

                return level;
            }
        }
    }
}