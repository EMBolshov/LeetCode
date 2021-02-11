using System.Linq;
using FluentAssertions;
using LeetCode.Arrays101._3_DeletingItemsFromArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.Array101._3_DeletingItemsFromArray
{
    [TestClass]
    public class CheckSolution
    {
        [TestMethod]
        public void RemoveDuplicatesFromSortedArrayTest()
        {
            var testData = new[] {1, 1, 2};
            var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(ref testData);
            result.Should().Be(2);
            testData.SequenceEqual(new[] {1, 2}).Should().BeTrue();

            testData = new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(ref testData);
            result.Should().Be(5);
            testData.SequenceEqual(new[] {0, 1, 2, 3, 4}).Should().BeTrue();
        }
    }
}