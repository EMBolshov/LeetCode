using System.Linq;
using FluentAssertions;
using LeetCode.OtherProblems.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Easy
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TwoSumTestCase1()
        {
            var input = new[] {2, 7, 11, 15};
            var target = 9;

            TwoSumTask.TwoSum(input, target).SequenceEqual(new[] {0, 1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void TwoSumTestCase2()
        {
            var input = new[] {3, 2, 4};
            var target = 6;

            TwoSumTask.TwoSum(input, target).SequenceEqual(new[] {1, 2}).Should().BeTrue();
        }
        
        [TestMethod]
        public void TwoSumTestCase3()
        {
            var input = new[] {3, 3};
            var target = 6;

            TwoSumTask.TwoSum(input, target).SequenceEqual(new[] {0, 1}).Should().BeTrue();
        }
    }
}