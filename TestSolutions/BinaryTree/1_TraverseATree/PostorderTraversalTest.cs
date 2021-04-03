using System.Collections.Generic;
using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._1_TraverseATree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._1_TraverseATree
{
    [TestClass]
    public class PostorderTraversalTest
    {
        [TestMethod]
        public void PostorderTraversalTestCase1()
        {
            var tree = new MyBinaryTree(6);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(1);
            tree.Left.Right = new MyBinaryTree(4);
            tree.Left.Right.Left = new MyBinaryTree(3);
            tree.Left.Right.Right = new MyBinaryTree(5);
            tree.Right = new MyBinaryTree(7);
            tree.Right.Right = new MyBinaryTree(9);
            tree.Right.Right.Left = new MyBinaryTree(8);

            BinaryTreePostorderTraversal.PostorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                1, 3, 5, 4, 2, 8, 9, 7, 6
            });
        }

        [TestMethod]
        public void PostorderTraversalTestCase2()
        {
            var tree = new MyBinaryTree(1);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Left = new MyBinaryTree(3);

            BinaryTreePostorderTraversal.PostorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                3, 2, 1
            });
        }

        [TestMethod]
        public void PostorderTraversalTestCase3()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Left.Left = new MyBinaryTree(4);

            BinaryTreePostorderTraversal.PostorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                4, 3, 2, 1
            });
        }
    }
}