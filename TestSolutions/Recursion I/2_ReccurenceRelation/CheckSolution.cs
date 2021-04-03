using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.Recursion_I._2_RecurrenceRelation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_I._2_ReccurenceRelation
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void SearchInBinarySearchTreeTestCase1()
        {
            var tree = new MyBinaryTree(4);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(1);
            tree.Left.Right = new MyBinaryTree(3);
            tree.Right = new MyBinaryTree(7);

            var result = SearchInABinarySearchTree.SearchBST(tree, 2);
            result.Value.Should().Be(2);
            result.Left.Value.Should().Be(1);
            result.Right.Value.Should().Be(3);
        }
        
        [TestMethod]
        public void SearchInBinarySearchTreeTestCase2()
        {
            var tree = new MyBinaryTree(4);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(1);
            tree.Left.Right = new MyBinaryTree(3);
            tree.Right = new MyBinaryTree(7);

            var result = SearchInABinarySearchTree.SearchBST(tree, 5);
            result.Should().BeNull();
        }
    }
}