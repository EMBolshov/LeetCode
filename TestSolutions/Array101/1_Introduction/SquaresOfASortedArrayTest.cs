using System.Linq;
using FluentAssertions;
using LeetCode.Arrays101._1_Introduction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._1_Introduction
{
    [TestClass]
    public class SquaresOfASortedArrayTest
    {
        [TestMethod]
        public void SquaresOfASortedArrayTestCase1()
        {
            var input = new[] {-4, -1, 0, 3, 10};
            var output = SquaresOfASortedArray.SortedSquares(input);
            output.SequenceEqual(new [] {0, 1, 9, 16, 100}).Should().BeTrue();
        }
        
        [TestMethod]
        public void SquaresOfASortedArrayTestCase2()
        {
            var input = new[] {-7, -3, 2, 3, 11};
            var output = SquaresOfASortedArray.SortedSquares(input);
            output.SequenceEqual(new [] {4, 9, 9, 49, 121}).Should().BeTrue();
        }
    }
}