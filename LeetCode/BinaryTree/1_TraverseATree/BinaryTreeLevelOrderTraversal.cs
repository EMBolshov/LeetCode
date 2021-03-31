using System.Collections.Generic;
using System.Linq;
using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.BinaryTree._1_TraverseATree
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/931/
    /// </summary>
    public static class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrderTraversal(MyBinaryTree tree)
        {
            var result = new List<IList<int>>();
            
            if (tree == null)
                return result;
            
            var queue = new Queue<MyBinaryTree>();
            var root = tree;
            
            result.Add(new List<int>{root.Value});
            queue.Enqueue(root.Left);
            queue.Enqueue(root.Right);

            while (true)
            {
                var newQueue = new Queue<MyBinaryTree>();
                var currentLevel = new List<int>();

                while (queue.Any())
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        currentLevel.Add(node.Value);

                        newQueue.Enqueue(node.Left);
                        newQueue.Enqueue(node.Right);
                    }
                }
                
                if (currentLevel.Any())
                    result.Add(currentLevel);

                if (newQueue.Any())
                {
                    queue = newQueue;
                    continue;
                }

                break;
            }

            return result;
        }
    }
}