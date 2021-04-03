using System.Collections.Generic;
using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._1_TraverseATree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._1_TraverseATree
{
    [TestClass]
    public class PreorderTraversalTest
    {
        [TestMethod]
        public void PreorderTraversalTestCase1()
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

            BinaryTreePreorderTraversal.PreorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                6, 2, 1, 4, 3, 5, 7, 9, 8
            });
        }

        [TestMethod]
        public void PreorderTraversalTestCase2()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(4);
            tree.Left.Left = new MyBinaryTree(2);
            tree.Right = new MyBinaryTree(3);

            BinaryTreePreorderTraversal.PreorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                1, 4, 2, 3
            });
        }
    }
}