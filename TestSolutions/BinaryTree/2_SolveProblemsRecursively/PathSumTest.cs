using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._2_SolveProblemsRecursively;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._2_SolveProblemsRecursively
{
    [TestClass]
    public class PathSumTest
    {
        [TestMethod]
        public void PathSumTestCase1()
        {
            var tree = new MyBinaryTree(5);
            tree.Left = new MyBinaryTree(4);
            tree.Left.Left = new MyBinaryTree(11);
            tree.Left.Left.Left = new MyBinaryTree(7);
            tree.Left.Left.Right = new MyBinaryTree(2);
            tree.Right = new MyBinaryTree(8);
            tree.Right.Left = new MyBinaryTree(4);
            tree.Right.Left.Left = new MyBinaryTree(1);
            tree.Right.Right = new MyBinaryTree(13);
            
            PathSum.HasPathSum(tree, 22).Should().Be(true);
        }
        
        [TestMethod]
        public void PathSumTestCase2()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Right = new MyBinaryTree(3);
            
            PathSum.HasPathSum(tree, 5).Should().Be(false);
        }
        
        [TestMethod]
        public void PathSumTestCase3()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            
            PathSum.HasPathSum(tree,1).Should().Be(false);
        }
    }
}