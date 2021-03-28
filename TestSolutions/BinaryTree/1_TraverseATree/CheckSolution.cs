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
            tree.Right.Right = new MyBinaryTree(9);
            tree.Right.Right.Left = new MyBinaryTree(8);

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            });
        }

        [TestMethod]
        public void InorderTraversalSingleNodeTest()
        {
            var tree = new MyBinaryTree(1);

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().ContainInOrder(new List<int>
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

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().ContainInOrder(new List<int>
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

            BinaryTreeInorderTraversal.InorderTraversal(tree).Should().ContainInOrder(new List<int>
            {
                3, 2, 1, 4
            });
        }

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