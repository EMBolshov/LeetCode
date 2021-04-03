using System.Linq;
using FluentAssertions;
using LeetCode.Arrays101._5_InPlaceOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._5_InPlaceOperations
{
    [TestClass]
    public class ReplaceElementsTest
    {
        [TestMethod]
        public void ReplaceElementsTestCase1()
        {
            var input = new[] {17, 18, 5, 4, 6, 1};
            var output = ReplaceElementsWithGreatestElementOnRightSide.ReplaceElements(input);
            output.SequenceEqual(new[] {18, 6, 6, 6, 1, -1}).Should().BeTrue();
        }
        
        [TestMethod]
        public void ReplaceElementsTestCase2()
        {
            var input = new[] {400};
            var output = ReplaceElementsWithGreatestElementOnRightSide.ReplaceElements(input);
            output.SequenceEqual(new[] {-1}).Should().BeTrue();
        }
    }
}