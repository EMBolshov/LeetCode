using System.Linq;
using FluentAssertions;
using LeetCode.Recursion_II._1_DivideAndConquer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Recursion_II._1_DivideAndConquer
{
    [TestClass]
    public class SortAnArrayTest
    {
        [TestMethod]
        public void MergeSortTestCase1()
        {
            var input = new[] {6, 5, 4, 3, 2, 1};

            SortAnArray.SortArray(input).ToList().SequenceEqual(new[] {1, 2, 3, 4, 5, 6}).Should().BeTrue();
        }
        
        [TestMethod]
        public void MergeSortTestCase2()
        {
            var input = new[] {6, 5, 4, 3, 2, 1, 7};

            SortAnArray.SortArray(input).ToList().SequenceEqual(new[] {1, 2, 3, 4, 5, 6, 7}).Should().BeTrue();
        }
    }
}