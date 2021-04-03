using System.Collections.Generic;
using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._1_TraverseATree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._1_TraverseATree
{
    [TestClass]
    public class LevelOrderTraversalTest
    {
        [TestMethod]
        public void LevelOrderTraversalTestCase1()
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

            var result = BinaryTreeLevelOrderTraversal.LevelOrderTraversal(tree);
            result[0].Should().ContainInOrder(new List<int> {6});
            result[1].Should().ContainInOrder(new List<int> {2, 7});
            result[2].Should().ContainInOrder(new List<int> {1, 4, 9});
            result[3].Should().ContainInOrder(new List<int> {3, 5, 8});
        }
        
        [TestMethod]
        public void LevelOrderTraversalTestCase2()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Left.Left = new MyBinaryTree(4);
            tree.Left.Left.Left.Left = new MyBinaryTree(5);
            

            var result = BinaryTreeLevelOrderTraversal.LevelOrderTraversal(tree);
            result[0].Should().ContainInOrder(new List<int> {1});
            result[1].Should().ContainInOrder(new List<int> {2});
            result[2].Should().ContainInOrder(new List<int> {3});
            result[3].Should().ContainInOrder(new List<int> {4});
            result[4].Should().ContainInOrder(new List<int> {5});
        }
        
        [TestMethod]
        public void LevelOrderTraversalTestCase3()
        {
            var tree = new MyBinaryTree(3);
            tree.Left = new MyBinaryTree(9);
            tree.Right = new MyBinaryTree(20);
            tree.Right.Left = new MyBinaryTree(15);
            tree.Right.Right = new MyBinaryTree(7);

            var result = BinaryTreeLevelOrderTraversal.LevelOrderTraversal(tree);
            result[0].Should().ContainInOrder(new List<int> {3});
            result[1].Should().ContainInOrder(new List<int> {9, 20});
            result[2].Should().ContainInOrder(new List<int> {15, 7});
        }
    }
}