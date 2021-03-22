using System.Collections.Generic;
using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._1_TraverseATree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._1_TraverseATree
{
    [TestClass]
    public class CheckSolution
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
            tree.Right.Right = new MyBinaryTree(8);
            tree.Right.Right.Left = new MyBinaryTree(9);

            BinaryTreePreorderTraversal.PreorderTraversal(tree).Should().BeEquivalentTo(new List<int>
            {
                6, 2, 1, 4, 3, 5, 7, 8, 9
            });
        }
        
        [TestMethod]
        public void PreorderTraversalTestCase2()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(4);
            tree.Left.Left = new MyBinaryTree(2);
            tree.Right = new MyBinaryTree(3);

            BinaryTreePreorderTraversal.PreorderTraversal(tree).Should().BeEquivalentTo(new List<int>
            {
                1, 4, 2, 3
            });
        }
        
        [TestMethod]
        public void InorderTraversalTestCase1()
        {
            var tree = new MyBinaryTree(6);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(1);
            tree.Left.Right = new MyBinaryTree(4);
            tree.Left.Right.Left = new MyBinaryTree(3);
            tree.Left.Right.Right = new MyBinaryTree(5);
            tree.Right = new MyBinaryTree(7);
            tree.Right.Right = new MyBinaryTree(8);
            tree.Right.Right.Left = new MyBinaryTree(9);

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().BeEquivalentTo(new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            });
        }
        
        [TestMethod]
        public void InorderTraversalSingleNodeTest()
        {
            var tree = new MyBinaryTree(1);
            
            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().BeEquivalentTo(new List<int>
            {
                1
            });
        }
        
        [TestMethod]
        public void InorderTraversalTestCase2()
        {
            var tree = new MyBinaryTree(2);
            tree.Left = new MyBinaryTree(3);
            tree.Left.Left = new MyBinaryTree(1);

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().BeEquivalentTo(new List<int>
            {
                1, 3, 2
            });
        }
        
        [TestMethod]
        public void InorderTraversalTestCase3()
        {
            var tree = new MyBinaryTree(4);
            tree.Left = new MyBinaryTree(1);
            tree.Left.Left = new MyBinaryTree(2);
            tree.Left.Left.Left = new MyBinaryTree(3);

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().BeEquivalentTo(new List<int>
            {
                3, 2, 1, 4
            });
        }
    }
}