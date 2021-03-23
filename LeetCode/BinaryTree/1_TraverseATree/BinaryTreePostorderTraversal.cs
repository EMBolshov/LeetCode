using System.Collections.Generic;
using System.Linq;
using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._1_TraverseATree
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/930/
    /// </summary>
    public static class BinaryTreePostorderTraversal
    {
        public static IList<int> PostorderTraversal(MyBinaryTree tree)
        {
            var result = new List<int>();
            
            if (tree == null)
                return result;

            if (tree.Right == null && tree.Left == null)
            {
                result.Add(tree.Value);
                return result;
            }

            var processed = new HashSet<MyBinaryTree>();
            var depthStack = new Stack<MyBinaryTree>();

            var root = tree;

            while (root != null)
            {
                if (IsProcessingComplete(tree))
                {
                    root = null;
                    continue;
                }
                
                depthStack.Push(root);

                if (root.Left != null)
                {
                    root = root.Left;
                }
                else if (root.Right != null)
                {
                    root = root.Right;
                }
                else
                {
                    if (depthStack.Any() && depthStack.Peek() == root)
                    {
                        AddIfNotContains(root);

                        depthStack.Pop();

                        var complete = false;
                        while (!complete)
                        {
                            if (depthStack.TryPeek(out var node))
                            {
                                if (node.Right == null)
                                {
                                    AddIfNotContains(node);
                                    depthStack.Pop();
                                }
                                else if (processed.Contains(node.Right))
                                {
                                    AddIfNotContains(node);
                                    depthStack.Pop();
                                }
                                else
                                {
                                    complete = true;
                                    root = node.Right;
                                }
                            }
                            else
                            {
                                complete = true;
                            }
                        }
                    }
                }
            }

            return result;
            
            void AddIfNotContains(MyBinaryTree node)
            {
                if (!processed.Contains(node))
                {
                    result.Add(node.Value);
                    processed.Add(node);
                }
            }

            bool IsProcessingComplete(MyBinaryTree node)
            {
                return node.Left != null && node.Right == null && processed.Contains(node.Left) ||
                       node.Left == null && node.Right != null && processed.Contains(node.Right) ||
                       node.Left != null && node.Right != null && processed.Contains(node.Left) &&
                       processed.Contains(node.Right);
            }
        }
    }
}