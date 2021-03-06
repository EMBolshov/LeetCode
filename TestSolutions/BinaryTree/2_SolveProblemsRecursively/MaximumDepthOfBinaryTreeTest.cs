﻿using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._2_SolveProblemsRecursively;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._2_SolveProblemsRecursively
{
    [TestClass]
    public class MaximumDepthOfBinaryTreeTest
    {
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestCase1()
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
            
            MaximumDepthOfBinaryTree.MaxDepth(tree).Should().Be(4);
        }
        
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestCase2()
        {
            var tree = new MyBinaryTree(3);
            tree.Left = new MyBinaryTree(9);
            tree.Right = new MyBinaryTree(20);
            tree.Right.Left = new MyBinaryTree(15);
            tree.Right.Right = new MyBinaryTree(7);
            
            MaximumDepthOfBinaryTree.MaxDepth(tree).Should().Be(3);
        }
        
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestCase3()
        {
            var tree = new MyBinaryTree(1);
            tree.Right = new MyBinaryTree(2);
            
            MaximumDepthOfBinaryTree.MaxDepth(tree).Should().Be(2);
        }
        
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestCase4()
        {
            var tree = new MyBinaryTree(1);

            MaximumDepthOfBinaryTree.MaxDepth(tree).Should().Be(1);
        }
        
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestCase5()
        {
            MaximumDepthOfBinaryTree.MaxDepth(null).Should().Be(0);
        }
        
        [TestMethod]
        public void MaximumDepthOfBinaryTreeTestCase6()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Left.Left = new MyBinaryTree(4);
            tree.Left.Left.Left.Left = new MyBinaryTree(5);

            MaximumDepthOfBinaryTree.MaxDepth(tree).Should().Be(5);
        }
    }
}