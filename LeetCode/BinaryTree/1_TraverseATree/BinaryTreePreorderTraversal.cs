using System.Collections.Generic;
using System.Linq;
using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._1_TraverseATree
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
    /// </summary>
    public static class BinaryTreePreorderTraversal
    {
        public static IList<int> PreorderTraversal(MyBinaryTree tree)
        {
            var result = new List<int>();

            var processed = new HashSet<MyBinaryTree>();
            var depthStack = new Stack<MyBinaryTree>();

            if (tree == null)
                return result;

            var root = tree;

            while (root != null)
            {
                if (!processed.Contains(root))
                {
                    result.Add(root.Value);
                    processed.Add(root);
                }

                depthStack.Push(root);

                if (root.Left != null)
                {
                    root = root.Left;
                }
                else if (root.Right != null)
                {
                    depthStack.Pop();
                    root = root.Right;
                }
                else
                {
                    if (depthStack.Any() && depthStack.Peek() == root)
                    {
                        depthStack.Pop();
                        var complete = false;
                        while (depthStack.Any() && !complete)
                        {
                            if (depthStack.Peek().Right == null)
                            {
                                depthStack.Pop();
                            }
                            else if (processed.Contains(depthStack.Peek().Right))
                            {
                                depthStack.Pop();
                            }
                            else
                                complete = true;
                        }
                    }

                    if (depthStack.Any())
                        root = depthStack.Peek().Right;
                    else
                        root = null;
                }
            }

            return result;
        }
    }
}