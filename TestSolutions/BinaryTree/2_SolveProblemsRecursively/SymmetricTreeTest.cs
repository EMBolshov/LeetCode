using FluentAssertions;
using LeetCode.BinaryTree._0_BinaryTree;
using LeetCode.BinaryTree._2_SolveProblemsRecursively;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.BinaryTree._2_SolveProblemsRecursively
{
    [TestClass]
    public class SymmetricTreeTest
    {
        [TestMethod]
        public void SymmetricTreeTestCase1()
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
            
            SymmetricTree.IsSymmetric(tree).Should().Be(false);
        }
        
        [TestMethod]
        public void SymmetricTreeTestCase2()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Right = new MyBinaryTree(4);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Left = new MyBinaryTree(4);
            tree.Right.Right = new MyBinaryTree(3);
            
            SymmetricTree.IsSymmetric(tree).Should().Be(true);
        }
        
        [TestMethod]
        public void SymmetricTreeTestCase3()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Right = new MyBinaryTree(3);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Right = new MyBinaryTree(3);
            
            SymmetricTree.IsSymmetric(tree).Should().Be(false);
        }
        
        [TestMethod]
        public void SymmetricTreeTestCase4()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Right = new MyBinaryTree(3);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Left = new MyBinaryTree(3);
            
            SymmetricTree.IsSymmetric(tree).Should().Be(true);
        }
        
        [TestMethod]
        public void SymmetricTreeTestCase5()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Left.Left = new MyBinaryTree(4);
            tree.Left.Left.Right = new MyBinaryTree(5);
            tree.Left.Right = new MyBinaryTree(1);
            tree.Left.Right.Left = new MyBinaryTree(6);
            tree.Left.Right.Right = new MyBinaryTree(7);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Left = new MyBinaryTree(1);
            tree.Right.Left.Left = new MyBinaryTree(7);
            tree.Right.Left.Right = new MyBinaryTree(6);
            tree.Right.Right = new MyBinaryTree(3);
            tree.Right.Right.Left = new MyBinaryTree(5);
            tree.Right.Right.Right = new MyBinaryTree(4);
            
            SymmetricTree.IsSymmetric(tree).Should().Be(true);
        }
        
        [TestMethod]
        public void SymmetricTreeTestCase6()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Left.Left = new MyBinaryTree(4);
            tree.Left.Left.Right = new MyBinaryTree(5);
            tree.Left.Right = new MyBinaryTree(1);
            tree.Left.Right.Left = new MyBinaryTree(6);
            tree.Left.Right.Right = new MyBinaryTree(7);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Left = new MyBinaryTree(1);
            tree.Right.Left.Left = new MyBinaryTree(7);
            tree.Right.Left.Right = new MyBinaryTree(6);
            tree.Right.Right = new MyBinaryTree(3);
            tree.Right.Right.Left = new MyBinaryTree(4);
            tree.Right.Right.Right = new MyBinaryTree(5);
            
            SymmetricTree.IsSymmetric(tree).Should().Be(false);
        }
        
        [TestMethod]
        public void SymmetricTreeTestCase7()
        {
            var tree = new MyBinaryTree(1);
            tree.Left = new MyBinaryTree(2);
            tree.Left.Left = new MyBinaryTree(3);
            tree.Left.Left.Left = new MyBinaryTree(4);
            tree.Left.Left.Right = new MyBinaryTree(5);
            tree.Left.Right = new MyBinaryTree(1);
            tree.Left.Right.Left = new MyBinaryTree(6);
            tree.Left.Right.Right = new MyBinaryTree(7);
            tree.Right = new MyBinaryTree(2);
            tree.Right.Left = new MyBinaryTree(1);
            tree.Right.Left.Right = new MyBinaryTree(6);
            tree.Right.Right = new MyBinaryTree(3);
            tree.Right.Right.Left = new MyBinaryTree(5);
            
            SymmetricTree.IsSymmetric(tree).Should().Be(false);
        }
    }
}