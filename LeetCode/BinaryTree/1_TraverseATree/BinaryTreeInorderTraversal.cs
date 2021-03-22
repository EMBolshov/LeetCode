using System.Collections.Generic;
using System.Linq;
using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._1_TraverseATree
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/929/
    /// </summary>
    public static class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(MyBinaryTree tree)
        {
            var result = new List<int>();

            var processed = new HashSet<MyBinaryTree>();
            var depthStack = new Stack<MyBinaryTree>();

            if (tree == null)
                return result;

            var root = tree;

            while (root != null)
            {
                depthStack.Push(root);

                if (root.Left != null)
                {
                    root = root.Left;
                }
                else if (root.Right != null)
                {
                    AddIfNotContains(root);
                    
                    depthStack.Pop();
                    root = root.Right;
                }
                else
                {
                    if (depthStack.Any() && depthStack.Peek() == root)
                    {
                        AddIfNotContains(root);
                        
                        depthStack.Pop();

                        if (depthStack.TryPeek(out var node))
                        {
                            AddIfNotContains(node);
                        }

                        var complete = false;
                        while (!complete)
                        {
                            if (depthStack.TryPeek(out node))
                            {
                                if (node.Right == null)
                                {
                                    AddIfNotContains(node);
                                    depthStack.Pop();
                                }
                                else if (processed.Contains(node.Right))
                                {
                                    depthStack.Pop();
                                }
                                else
                                {
                                    complete = true;
                                    AddIfNotContains(node);
                                }
                            }
                            else
                            {
                                complete = true;
                            }
                        }
                    }

                    if (depthStack.Any())
                    {
                        root = depthStack.Peek().Right;
                    }
                    else
                    {
                        root = null;
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
        }
    }
}