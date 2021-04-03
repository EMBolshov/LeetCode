using LeetCode.BinaryTree._0_BinaryTree;

namespace LeetCode.Recursion_I._2_RecurrenceRelation
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/recursion-i/251/scenario-i-recurrence-relation/3233/
    /// </summary>
    public static class SearchInABinarySearchTree
    {
        // ReSharper disable once InconsistentNaming
        public static MyBinaryTree SearchBST(MyBinaryTree root, int val)
        {
            return SearchNode(root, val);

            MyBinaryTree SearchNode(MyBinaryTree root, int val)
            {
                if (root == null)
                    return null;
                
                if (root.Value == val)
                    return root;

                var searchLeft = SearchNode(root.Left, val);
                
                return searchLeft ?? SearchNode(root.Right, val);
            }
        }
    }
}