using FluentAssertions;
using LeetCode.Arrays101._6_Conclusion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._6_Conclusion
{
    [TestClass]
    public class HeightCheckerTest
    {
        [TestMethod]
        public void NotMatchingIndicesTestCase1()
        {
            var input = new[] {1, 1, 4, 2, 1, 3};
            HeightChecker.NotMatchingIndices(input).Should().Be(3);
        }
        
        [TestMethod]
        public void NotMatchingIndicesTestCase2()
        {
            var input = new[] {5, 1, 2, 3, 4};
            HeightChecker.NotMatchingIndices(input).Should().Be(5);
        }
        
        [TestMethod]
        public void NotMatchingIndicesTestCase3()
        {
            var input = new[] {1, 2, 3, 4, 5};
            HeightChecker.NotMatchingIndices(input).Should().Be(0);
        }
    }
}